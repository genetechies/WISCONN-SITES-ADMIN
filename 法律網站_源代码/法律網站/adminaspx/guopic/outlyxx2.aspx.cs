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
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Web.Admin.GuestBook
{
    public partial class Manage : System.Web.UI.Page {
        BLL.guopic bll = new BLL.guopic();
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "outlogo", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

            }
        }

        
        protected void btnImportOut_Click(object sender, EventArgs e)
        {
            //string filename=DateTime.Now.ToString("yyyyMMdd")+"logo";
            //DataSetToCsv(filename);
            //DataSetToXls(filename);

            //string sql = @"select [Product].[P_Code],[ProductClass].[PC_ClassName],[Product].[P_ClassID],[Product].[P_Name],[Product].[P_PhotoUrl] from [Product] inner join [ProductClass] on [Product].[P_ClassID]=[ProductClass].[PC_Id] where [Product].[P_State]=1 order by [Product].[P_SortKey],[Product].[P_Id]";
            string sql = @"select guopic.id ,guopic.title ,guopic.pic ,guoclass.NC_ClassName   from guopic,guoclass  where guopic.guoclassid=guoclass.NC_Id  order by guopic.Sort desc";
            Hashtable nameList = new Hashtable();
            nameList.Add("id", "編號");
            nameList.Add("title", "LOG圖片名稱");
            nameList.Add("pic", "LOG圖文件");
            nameList.Add("NC_ClassName", "服務項目類別");

            //string filename = ExportDataToExcel(DBUtility.DbHelperOledb.GetDataTable(sql), Server.MapPath("~/data/"), nameList, "");
            string filename = ExportDataToExcel(DBUtility.DbHelperOledb.GetDataTable(sql), Server.MapPath("~/data/"), nameList, "");

            string path = Server.MapPath("~/data/logodata.xls");
            FileInfo DownloadFile = new FileInfo(path);//path为文件路径
            Response.Clear();
            Response.ClearHeaders();
            Response.Buffer = false;
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode("logodata.xls"));
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
        //                //if (column.ColumnName == "聯繫電話")
        //                //{
        //                //    data += "\"" + row[column].ToString() + "。 \",";
        //                //}
        //                //else if (column.ColumnName == "應聘時間")
        //                //{
        //                //    data += "\"" + row[column].ToString() + "。  \",";
        //                //}
        //                //else
        //                //{
        //                    //用Tab分隔，可换为其他符号
        //                    data += "\"" + row[column].ToString().Replace("UploadFiles/","") + "  \",";
        //                //}
        //            }
        //            data += "\n";
        //        }
        //        data += "\n";
        //    }

        //    if (data != "")
        //    {
        //        string temp = string.Format("attachment;filename={0}", FileName + ".xls");
        //        Response.ClearHeaders();
        //        Response.ContentEncoding = System.Text.Encoding.Default;
        //        Response.AppendHeader("Content-disposition", temp);
        //        Response.Write(data);
        //        Response.End();
        //    }
        //}



        /// <summary>
        ///// xls导出
        ///// </summary>
        ///// <param name="ds"></param>
        //public void DataSetToXls(string FileName)
        //{
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
        //            data += column.ColumnName + "\t";
        //        }
        //        data += "\n";

        //        //写出数据
        //        foreach (DataRow row in tb.Rows)
        //        {
        //            foreach (DataColumn column in tb.Columns)
        //            {
        //                //if (column.ColumnName == "聯繫電話")
        //                //{
        //                //    data += "\"" + row[column].ToString() + "。 \",";
        //                //}
        //                //else if (column.ColumnName == "應聘時間")
        //                //{
        //                //    data += "\"" + row[column].ToString() + "。  \",";
        //                //}
        //                //else
        //                //{
        //                //用Tab分隔，可换为其他符号
        //                data += "\"" + row[column].ToString().Replace("UploadFiles/", "") + "  \"\t";
        //                //}
        //            }
        //            data += "\n";
        //        }
        //        data += "\n";
        //    }

        //    if (data != "")
        //    {
        //        string temp = string.Format("attachment;filename={0}", FileName + ".xls");
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
            string strFileName = "logodata.xls";
            string tempColumnName = "";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (i == 0)
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
                        workSheet.Cells[titleRowsCount + 1, j + 1] = tempColumnName;
                    }
                    if (j <= 4)
                    {
                        workSheet.Cells[i + titleRowsCount + 2, j + 1] = dt.Rows[i][j].ToString().Replace("UploadFiles/", "");
                    }
                    else
                    {
                        string imageurl = dt.Rows[i][j].ToString();
                        if (imageurl.IndexOf("uploadfiles/", StringComparison.OrdinalIgnoreCase) == 0 || imageurl.IndexOf(@"uploadfiles\", StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            imageurl = imageurl.Substring(11);
                        }
                        workSheet.Cells[i + titleRowsCount + 2, j + 1] = imageurl;
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
}
}
