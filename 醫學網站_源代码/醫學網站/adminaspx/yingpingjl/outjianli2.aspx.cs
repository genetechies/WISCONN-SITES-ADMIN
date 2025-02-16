using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Helper;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Web.Admin.GuestBook
{
    public partial class Manage : System.Web.UI.Page {
        BLL.yingpin bll = new BLL.yingpin();
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "outjianli", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

            }
        }

        
        protected void btnImportOut_Click(object sender, EventArgs e)
        {
            //string filename=DateTime.Now.ToString("yyyyMMdd");
            //DataSetToCsv(filename);

            //string sql = @"select [Product].[P_Code],[ProductClass].[PC_ClassName],[Product].[P_ClassID],[Product].[P_Name],[Product].[P_PhotoUrl] from [Product] inner join [ProductClass] on [Product].[P_ClassID]=[ProductClass].[PC_Id] where [Product].[P_State]=1 order by [Product].[P_SortKey],[Product].[P_Id]";
            string sql = @"select ID ,UserName ,Age ,Sex ,TopGraduation ,CreateDate ,WorkType ,IsLearning ,MasterLanguage,Seniority ,TranslationAmount,[Language],TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Experience   from TranslatorList  order by id desc";
            Hashtable nameList = new Hashtable();
            nameList.Add("ID", "編號");
            nameList.Add("UserName", "姓名");
            nameList.Add("Age", "年齡");
            nameList.Add("Sex", "性別");
            nameList.Add("TopGraduation", "最高學歷");
            nameList.Add("CreateDate", "應聘時間");
            nameList.Add("WorkType", "工作別");
            nameList.Add("IsLearning", "是否在學");
            nameList.Add("MasterLanguage", "主要語言");
            nameList.Add("Seniority", "翻譯年資");
            nameList.Add("TranslationAmount", "翻譯量");
            nameList.Add("[Language]", "第二外語");
            nameList.Add("TransLationSkill", "翻譯專長");
            nameList.Add("SoftwareSkill", "專長軟件");
            nameList.Add("TEL", "電話");
            nameList.Add("Email", "Email");
            nameList.Add("QQ", "QQ");
            nameList.Add("MSN", "MSN");
            nameList.Add("Experience", "翻譯經歷");

            //string filename = ExportDataToExcel(DBUtility.DbHelperOledb.GetDataTable(sql), Server.MapPath("~/data/"), nameList, "");
            string filename = ExportDataToExcel(DBUtility.DbHelperOledb.GetDataTable(sql), Server.MapPath("~/data/"), nameList, "");

            string path = Server.MapPath("~/data/jianli.xls");
            FileInfo DownloadFile = new FileInfo(path);//path为文件路径
            Response.Clear();
            Response.ClearHeaders();
            Response.Buffer = false;
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode("jianli.xls"));
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AppendHeader("Content-Length", DownloadFile.Length.ToString());
            Response.WriteFile(DownloadFile.FullName);
            Response.Flush();
            Response.End();
        }


        ///// <summary>
        ///// csv导出
        ///// </summary>
        ///// <param name="ds"></param>
        //public void DataSetToCsv(string FileName)
        //{
        //    BLL.TranslatorList bll = new BLL.TranslatorList();
        //    DataSet ds = bll.GetoutList();
        //    string data = "";
        //    //data = ds.DataSetName + "\n";
        //    foreach (DataTable tb in ds.Tables)
        //    {
        //        //data += tb.TableName + "\n";
        //        //写出列名
        //        foreach (DataColumn column in tb.Columns)
        //        {
        //            //用Tab分隔，可换为其他符号
        //            data += column.ColumnName + ",";
        //        }
        //        data += "\n";

        //        //写出数据
        //        foreach (DataRow row in tb.Rows)
        //        {
        //            foreach (DataColumn column in tb.Columns)
        //            {
        //                if (column.ColumnName == "工作別")
        //                {
        //                    data += "\"" + worktype(row[column].ToString()) + " \",";
        //                }
        //                else if (column.ColumnName == "第二外語")
        //                {
        //                    data += "\"" + language(row[column].ToString()) + "  \",";
        //                }
        //                else if (column.ColumnName == "翻譯專長")
        //                {
        //                    data += "\"" + translationskill(row[column].ToString()) + "  \",";
        //                }
        //                else if (column.ColumnName == "專長軟件")
        //                {
        //                    data += "\"" + softwareskill(row[column].ToString()) + "  \",";
        //                }
        //                else
        //                {
        //                    //用Tab分隔，可换为其他符号
        //                    data += "\"" + row[column].ToString() + "  \",";
        //                }
        //            }
        //            data += "\n";
        //        }
        //        data += "\n";
        //    }

        //    if (data != "")
        //    {
        //        string temp = string.Format("attachment;filename={0}", FileName + ".csv");
        //        Response.ClearHeaders();
        //        Response.ContentEncoding = System.Text.Encoding.Default;
        //        Response.AppendHeader("Content-disposition", temp);
        //        Response.Write(data);
        //        Response.End();
        //    }
        //}


        /// <summary>  
        /// 将DataTable的数据导出到Excel中。  
        /// </summary>  
        /// <param name="dt">DataTable</param>  
        /// <param name="xlsFileDir">导出的Excel文件存放目录（绝对路径，最后带“\”）</param>  
        /// <param name="nameList">DataTable中列名的中文对应表</param>  
        /// <param name="strTitle">Excel表的标题</param>  
        /// <returns>Excel文件名</returns>  
        private string ExportDataToExcel(System.Data.DataTable dt, string xlsFileDir, Hashtable nameList, string strTitle)
        {

            if (dt == null) return "";
            Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            Microsoft.Office.Interop.Excel.Workbooks workBooks = excel.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workBook = workBooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets[1];

            int titleRowsCount = 0;
            if (strTitle != null && strTitle.Trim() != "")
            {
                titleRowsCount = 1;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).Font.Bold = true;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).Font.Size = 16;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).MergeCells = true;
                workSheet.Cells[1, 1] = strTitle;
            }
            if (!System.IO.Directory.Exists(xlsFileDir))
            {
                System.IO.Directory.CreateDirectory(xlsFileDir);
            }
            string strFileName = "jianli.xls";
            string tempColumnName = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    tempColumnName = dt.Columns[j].ColumnName.Trim();
                    if (nameList != null)
                    {
                        IDictionaryEnumerator Enum = nameList.GetEnumerator();
                        while (Enum.MoveNext())
                        {
                            if (Enum.Key.ToString().Trim() == tempColumnName)
                            {
                                tempColumnName = Enum.Value.ToString();
                                break;
                            }
                        }
                    }


                    if (i == 0)
                    {
                        workSheet.Cells[titleRowsCount + 1, j + 1] = tempColumnName;
                    }
                    else
                    {


                        if (tempColumnName == "工作別")
                        {
                            workSheet.Cells[i + titleRowsCount + 2, j + 1] = worktype(dt.Rows[i][j].ToString());
                        }
                        else if (tempColumnName == "第二外語")
                        {
                            workSheet.Cells[i + titleRowsCount + 2, j + 1] = language(dt.Rows[i][j].ToString());
                        }
                        else if (tempColumnName == "翻譯專長")
                        {
                            workSheet.Cells[i + titleRowsCount + 2, j + 1] = translationskill(dt.Rows[i][j].ToString());
                        }
                        else if (tempColumnName == "專長軟件")
                        {
                            workSheet.Cells[i + titleRowsCount + 2, j + 1] = softwareskill(dt.Rows[i][j].ToString());
                        }
                        else
                        {
                            //workSheet.Cells[i + titleRowsCount + 2, j + 1] = dt.Rows[i][j].ToString().Replace("UploadFiles/", "");
                            workSheet.Cells[i + titleRowsCount + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }
                        

                }
            }
            excel.get_Range(excel.Cells[titleRowsCount + 1, 1], excel.Cells[titleRowsCount + 1, dt.Columns.Count]).Font.Bold = true;
            //excel.get_Range(excel.Cells[1, 1], excel.Cells[titleRowsCount + 1 + dt.Rows.Count, dt.Columns.Count]).HorizontalAlignment = XlVAlign.xlVAlignCenter;
            excel.get_Range(excel.Cells[titleRowsCount + 1, 1], excel.Cells[titleRowsCount + 1, dt.Columns.Count]).HorizontalAlignment = XlVAlign.xlVAlignCenter;
            excel.get_Range(excel.Cells[1, 1], excel.Cells[titleRowsCount + 1 + dt.Rows.Count, dt.Columns.Count]).EntireColumn.AutoFit();
            workBook.Saved = true;
            workBook.SaveCopyAs(xlsFileDir + strFileName);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            workSheet = null;
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workBook);
            workBook = null;
            workBooks.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workBooks);
            workBooks = null;
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            excel = null;
            return strFileName;
        }


        public string worktype(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "筆譯,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "口譯,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "專有名詞,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "潤稿,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "排版,";
                }
            }

            return temp;
        }

        public string language(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "英文,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "日文,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "繁中,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "簡中,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "韓文,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "德文,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "西文,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "法文,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "俄文,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "義文,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "葡文,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "荷文,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "波蘭,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "阿文,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "越文,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "泰文,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "馬來文,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "印尼文,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "其它,";
                }

            }

            return temp;
        }


        public string translationskill(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "醫學,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "醫療器材,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "中醫,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "藥學,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "生物化學,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "物理/光學,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "理工,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "化學/化工,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "數學,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "電機,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "電子,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "電信通訊,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "電腦硬體,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "地球科學,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "電腦軟體,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "電玩遊戲,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "交通/運輸,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "資訊,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "機械,";
                }

                if (arr[i].Trim() == "20")
                {
                    temp = temp + "工業安全,";
                }
                if (arr[i].Trim() == "21")
                {
                    temp = temp + "汽車,";
                }
                if (arr[i].Trim() == "22")
                {
                    temp = temp + "捷運/高鐵,";
                }
                if (arr[i].Trim() == "23")
                {
                    temp = temp + "都市計劃,";
                }
                if (arr[i].Trim() == "24")
                {
                    temp = temp + "航太,";
                }
                if (arr[i].Trim() == "25")
                {
                    temp = temp + "土木,";
                }
                if (arr[i].Trim() == "26")
                {
                    temp = temp + "建築裝璜,";
                }
                if (arr[i].Trim() == "27")
                {
                    temp = temp + "環保,";
                }
                if (arr[i].Trim() == "28")
                {
                    temp = temp + "能源/發電,";
                }
                if (arr[i].Trim() == "29")
                {
                    temp = temp + "石油科學,";
                }
                if (arr[i].Trim() == "30")
                {
                    temp = temp + "核能/核子科學,";
                }
                if (arr[i].Trim() == "31")
                {
                    temp = temp + "半導體,";
                }
                if (arr[i].Trim() == "32")
                {
                    temp = temp + "營造工程,";
                }
                if (arr[i].Trim() == "33")
                {
                    temp = temp + "法律,";
                }
                if (arr[i].Trim() == "34")
                {
                    temp = temp + "保險,";
                }
                if (arr[i].Trim() == "35")
                {
                    temp = temp + "財務經濟,";
                }
                if (arr[i].Trim() == "36")
                {
                    temp = temp + "外匯金融,";
                }
                if (arr[i].Trim() == "37")
                {
                    temp = temp + "會計稅務,";
                }
                if (arr[i].Trim() == "38")
                {
                    temp = temp + "會計,";
                }

                if (arr[i].Trim() == "39")
                {
                    temp = temp + "企管,";
                }
                if (arr[i].Trim() == "40")
                {
                    temp = temp + "商業/貿易,";
                }
                if (arr[i].Trim() == "41")
                {
                    temp = temp + "證券,";
                }
                if (arr[i].Trim() == "42")
                {
                    temp = temp + "統計,";
                }
                if (arr[i].Trim() == "43")
                {
                    temp = temp + "歷史,";
                }
                if (arr[i].Trim() == "44")
                {
                    temp = temp + "天文,";
                }
                if (arr[i].Trim() == "45")
                {
                    temp = temp + "人文,";
                }
                if (arr[i].Trim() == "46")
                {
                    temp = temp + "人口發展,";
                }
                if (arr[i].Trim() == "47")
                {
                    temp = temp + "政治,";
                }
                if (arr[i].Trim() == "48")
                {
                    temp = temp + "新聞,";
                }
                if (arr[i].Trim() == "49")
                {
                    temp = temp + "大眾傳播,";
                }
                if (arr[i].Trim() == "50")
                {
                    temp = temp + "教育,";
                }
                if (arr[i].Trim() == "51")
                {
                    temp = temp + "哲學,";
                }
                if (arr[i].Trim() == "52")
                {
                    temp = temp + "文化,";
                }
                if (arr[i].Trim() == "53")
                {
                    temp = temp + "文學,";
                }
                if (arr[i].Trim() == "54")
                {
                    temp = temp + "心理,";
                }
                if (arr[i].Trim() == "55")
                {
                    temp = temp + "藝術,";
                }
                if (arr[i].Trim() == "56")
                {
                    temp = temp + "社會學,";
                }
                if (arr[i].Trim() == "57")
                {
                    temp = temp + "消防,";
                }

                if (arr[i].Trim() == "58")
                {
                    temp = temp + "紡織,";
                }
                if (arr[i].Trim() == "59")
                {
                    temp = temp + "傳記,";
                }
                if (arr[i].Trim() == "60")
                {
                    temp = temp + "軍事/國防,";
                }
                if (arr[i].Trim() == "61")
                {
                    temp = temp + "美容,";
                }
                if (arr[i].Trim() == "62")
                {
                    temp = temp + "體育,";
                }
                if (arr[i].Trim() == "63")
                {
                    temp = temp + "宗教,";
                }
                if (arr[i].Trim() == "64")
                {
                    temp = temp + "酒類,";
                }
                if (arr[i].Trim() == "65")
                {
                    temp = temp + "觀光/旅遊,";
                }
                if (arr[i].Trim() == "66")
                {
                    temp = temp + "地理,";
                }
                if (arr[i].Trim() == "67")
                {
                    temp = temp + "食品/餐飲,";
                }
                if (arr[i].Trim() == "68")
                {
                    temp = temp + "時裝,";
                }
                if (arr[i].Trim() == "69")
                {
                    temp = temp + "音樂,";
                }
                if (arr[i].Trim() == "70")
                {
                    temp = temp + "農林漁牧,";
                }
                if (arr[i].Trim() == "71")
                {
                    temp = temp + "廣告行銷,";
                }
                if (arr[i].Trim() == "72")
                {
                    temp = temp + "電影,";
                }
                if (arr[i].Trim() == "73")
                {
                    temp = temp + "體育/運動,";
                }
                if (arr[i].Trim() == "74")
                {
                    temp = temp + "珠寶,";
                }
                if (arr[i].Trim() == "75")
                {
                    temp = temp + "採礦/礦物,";
                }
                if (arr[i].Trim() == "76")
                {
                    temp = temp + "戲劇,";
                }

                if (arr[i].Trim() == "77")
                {
                    temp = temp + "動物,";
                }
                if (arr[i].Trim() == "78")
                {
                    temp = temp + "植物,";
                }
                if (arr[i].Trim() == "79")
                {
                    temp = temp + "留學,";
                }
                if (arr[i].Trim() == "80")
                {
                    temp = temp + "論文,";
                }
                if (arr[i].Trim() == "81")
                {
                    temp = temp + "ISO,";
                }
                if (arr[i].Trim() == "82")
                {
                    temp = temp + "公證/移民,";
                }
                if (arr[i].Trim() == "83")
                {
                    temp = temp + "專利,";
                }
                if (arr[i].Trim() == "84")
                {
                    temp = temp + "技術手冊,";
                }
                if (arr[i].Trim() == "85")
                {
                    temp = temp + "公司章程,";
                }
                if (arr[i].Trim() == "86")
                {
                    temp = temp + "印刷/出版,";
                }
                if (arr[i].Trim() == "87")
                {
                    temp = temp + "合約書,";
                }

            }

            return temp;
        }


        public string softwareskill(string str)
        {
            string[] arr = str.Split('|');
            string temp = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim() == "1")
                {
                    temp = temp + "Access,";
                }
                if (arr[i].Trim() == "2")
                {
                    temp = temp + "Publisher,";
                }
                if (arr[i].Trim() == "3")
                {
                    temp = temp + "Visio,";
                }
                if (arr[i].Trim() == "4")
                {
                    temp = temp + "FrontPage,";
                }
                if (arr[i].Trim() == "5")
                {
                    temp = temp + "Dreamweaver,";
                }
                if (arr[i].Trim() == "6")
                {
                    temp = temp + "PageMaker,";
                }
                if (arr[i].Trim() == "7")
                {
                    temp = temp + "FrameMaker,";
                }
                if (arr[i].Trim() == "8")
                {
                    temp = temp + "QuarkXPress,";
                }
                if (arr[i].Trim() == "9")
                {
                    temp = temp + "Robohelp,";
                }
                if (arr[i].Trim() == "10")
                {
                    temp = temp + "AcrobatWriter,";
                }
                if (arr[i].Trim() == "11")
                {
                    temp = temp + "Photoshop,";
                }
                if (arr[i].Trim() == "12")
                {
                    temp = temp + "Illustrator,";
                }
                if (arr[i].Trim() == "13")
                {
                    temp = temp + "Corel Draw,";
                }
                if (arr[i].Trim() == "14")
                {
                    temp = temp + "InDesign,";
                }
                if (arr[i].Trim() == "15")
                {
                    temp = temp + "Trados,";
                }
                if (arr[i].Trim() == "16")
                {
                    temp = temp + "SDLX,";
                }
                if (arr[i].Trim() == "17")
                {
                    temp = temp + "Deja vu,";
                }
                if (arr[i].Trim() == "18")
                {
                    temp = temp + "STAR Transit,";
                }
                if (arr[i].Trim() == "19")
                {
                    temp = temp + "IBM TM,";
                }

            }

            return temp;
        }

}
}
