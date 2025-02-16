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
using System.IO;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Text;

namespace ZeroStudio.Web.Admin.Product {
    public partial class ImportOut : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                downloadPanel.Visible = false;
            }
            //string path = Server.MapPath("~/data/");
            //string sql = @"select [P_Name] as [產品名稱(中文)],[P_Name_En] as [產品名稱(英文)],[P_Model] as 產品型號,[P_Spec] as 產品規格,[P_Stock] as 產品原料,[P_Identity] as 產品特性,[P_Evinr] as 產品適用環境,[P_PhotoUrl] as 產品圖片,[P_Doc] as 產品文檔  into [excel 8.0;database=" + path + @"productdata.xls].[Table1] from [Product]";
            //ZeroStudio.DBUtility.DbHelperOledb.ExecuteSql(sql);
        }

        protected void btnImportOut_Click(object sender, EventArgs e) {
            string sql = @"select [Product].[P_Code],[ProductClass].[PC_ClassName],[Product].[P_ClassID],[P_ClassID_Zh],[Product].[P_Model],[Product].[P_PhotoUrl],[Product].[P_Doc] from [Product] inner join [ProductClass] on [Product].[P_ClassID]=[ProductClass].[PC_Id] where [Product].[P_State]=1 
order by [Product].[P_Code],[Product].[P_ParentID],[Product].[P_Id]";
            Hashtable nameList = new Hashtable();
            nameList.Add("P_Code", "產品編號");
            nameList.Add("PC_ClassName", "第三層欄位名稱");
            nameList.Add("P_ClassID", "類別編號");
            nameList.Add("P_ClassID_Zh", "類別編號(中文)");
            nameList.Add("P_Model", "產品料號");
            nameList.Add("P_PhotoUrl", "第四層JPG圖片檔");
            nameList.Add("P_Doc", "產品詳細PDF文檔");

            string filename = ExportDataToExcel(ZeroStudio.DBUtility.DbHelperOledb.GetDataTable(sql), Server.MapPath("~/data/"), nameList, "");
            
            importPanel.Visible = false;
            downloadPanel.Visible = true;
            //ClientScript.RegisterStartupScript(GetType(), "success", "alert('匯出Excel成功!');", true);
            //ExportToExcel(ZeroStudio.DBUtility.DbHelperOledb.GetDataTable(sql), "productdata.xls");
        }

        /// <summary>  
        /// 将DataTable的数据导出到Excel中。  
        /// </summary>  
        /// <param name="dt">DataTable</param>  
        /// <param name="xlsFileDir">导出的Excel檔案存放目录（绝对路径，最后带“\”）</param>  
        /// <param name="nameList">DataTable中列名的中文对应表</param>  
        /// <param name="strTitle">Excel表的标题</param>  
        /// <returns>Excel檔案名</returns>  
        private string ExportDataToExcel(System.Data.DataTable dt, string xlsFileDir, Hashtable nameList, string strTitle) {

            if (dt == null) return "";
            Microsoft.Office.Interop.Excel.ApplicationClass excel = new Microsoft.Office.Interop.Excel.ApplicationClass();
            Microsoft.Office.Interop.Excel.Workbooks workBooks = excel.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workBook = workBooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets[1];

            int titleRowsCount = 0;
            if (strTitle != null && strTitle.Trim() != "") {
                titleRowsCount = 1;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).Font.Bold = true;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).Font.Size = 16;
                excel.get_Range(excel.Cells[1, 1], excel.Cells[1, dt.Columns.Count]).MergeCells = true;
                workSheet.Cells[1, 1] = strTitle;
            }
            if (!System.IO.Directory.Exists(xlsFileDir)) {
                System.IO.Directory.CreateDirectory(xlsFileDir);
            }
            string strFileName = "productdata.xls";
            string tempColumnName = "";

            for (int i = 0; i < dt.Rows.Count; i++) {
                for (int j = 0; j < dt.Columns.Count; j++) {
                    if (i == 0) {
                        tempColumnName = dt.Columns[j].ColumnName.Trim();
                        if (nameList != null) {
                            IDictionaryEnumerator Enum = nameList.GetEnumerator();
                            while (Enum.MoveNext()) {
                                if (Enum.Key.ToString().Trim() == tempColumnName) {
                                    tempColumnName = Enum.Value.ToString();
                                    break;
                                }
                            }
                        }
                        workSheet.Cells[titleRowsCount + 1, j + 1] = tempColumnName;
                    }
                    if (j <= 3) {
                        workSheet.Cells[i + titleRowsCount + 2, j + 1] = dt.Rows[i][j].ToString();
                    } else if (j == 4) {
                        string imageurl = dt.Rows[i][j].ToString();
                        if (imageurl.IndexOf("uploadfiles/product/", StringComparison.OrdinalIgnoreCase) == 0 || imageurl.IndexOf(@"uploadfiles\product\", StringComparison.OrdinalIgnoreCase) == 0) {
                            imageurl = imageurl.Substring(20);
                        }
                        workSheet.Cells[i + titleRowsCount + 2, j + 1] = imageurl;
                    } else if (j == 5) {
                        string docurl = dt.Rows[i][j].ToString();
                        if (docurl.IndexOf("uploadfiles/doc/", StringComparison.OrdinalIgnoreCase) == 0 || docurl.IndexOf(@"uploadfiles\doc\", StringComparison.OrdinalIgnoreCase) == 0) {
                            docurl = docurl.Substring(16);
                        }
                        workSheet.Cells[i + titleRowsCount + 2, j + 1] = docurl;
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

        private string htmltocode(string str) {
            string newstr;
            if (string.IsNullOrEmpty(str)) {
                return "";
            }
            newstr = str.Replace("&lt;", "<");
            newstr = newstr.Replace("&gt;", ">");
            newstr = newstr.Replace("<br>", "\r\n");
            newstr = newstr.Replace("&nbsp;", " ");
            return newstr;
        }

        private string ExportExcel(System.Data.DataTable dt, Hashtable nameList) {
            // 表開始
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\"?>");
            sb.AppendLine("<?mso-application progid=\"Excel.Sheet\"?>");
            sb.AppendLine("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\">");
            sb.AppendLine(" <Worksheet ss:Name=\"Sheet1\">");
            sb.AppendLine("  <Table>");
            //
            // 输出标题
            //
            sb.AppendLine("   <Row>");
            if (dt != null) {
                // 输出指定列标题
                for (int j = 0; j < dt.Columns.Count; j++) {
                    string tempColumnName = dt.Columns[j].ColumnName.Trim();
                    if (nameList != null) {
                        IDictionaryEnumerator Enum = nameList.GetEnumerator();
                        while (Enum.MoveNext()) {
                            if (Enum.Key.ToString().Trim() == tempColumnName) {
                                tempColumnName = Enum.Value.ToString();
                                break;
                            }
                        }
                    }
                    sb.AppendLine("    <Cell><Data ss:Type=\"String\">" + tempColumnName + "</Data></Cell>");
                }
            }
            sb.AppendLine("   </Row>");
            //
            // 输出数据
            //
            //输出所有列数据
            for (int i = 0; i < dt.Rows.Count; i++) {
                sb.AppendLine("   <Row>");
                for (int j = 0; j < dt.Columns.Count; j++) {

                    if (j <= 5) {
                        sb.AppendLine("    <Cell><Data ss:Type=\"String\">" + dt.Rows[i][j].ToString() + "</Data></Cell>");
                    } else if (j > 5 && j <= 9) {
                        sb.AppendLine("    <Cell><Data ss:Type=\"String\">" + htmltocode(dt.Rows[i][j].ToString()) + "</Data></Cell>");
                    } else if (j == 10) {
                        string imageurl = dt.Rows[i][j].ToString();
                        if (imageurl.IndexOf("uploadfiels/product/", StringComparison.OrdinalIgnoreCase) == 0) {
                            imageurl = imageurl.Substring(20);
                        }
                        sb.AppendLine("    <Cell><Data ss:Type=\"String\">" + imageurl + "</Data></Cell>");
                    } else if (j == 11) {
                        string docurl = dt.Rows[i][j].ToString();
                        if (docurl.IndexOf("uploadfiels/doc/", StringComparison.OrdinalIgnoreCase) == 0) {
                            docurl = docurl.Substring(16);
                        }
                        sb.AppendLine("    <Cell><Data ss:Type=\"String\">" + docurl + "</Data></Cell>");
                    }
                }
                sb.AppendLine("   </Row>");
            }
            // 表结束
            sb.AppendLine("  </Table>");
            sb.AppendLine(" </Worksheet>");
            sb.AppendLine("</Workbook>");
            return sb.ToString();
        }
        private void ExportToExcel(System.Data.DataTable dt, string fileName) {
            //转换为物理路径 
            string newFileName = HttpContext.Current.Server.MapPath("~/data/" + fileName);
            //根据模板正式生成该Excel檔案 
            File.Copy(HttpContext.Current.Server.MapPath("~/data/product.xls"), newFileName, true);
            //建立指向该Excel檔案的数据库连接
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + newFileName + ";Extended Properties='Excel 8.0;HDR=yes;IMEX=2'";
            OleDbConnection Conn = new OleDbConnection(strConn);
            //打开连接，为操作该檔案做准备
            Conn.Open();
            OleDbCommand Cmd = new OleDbCommand("", Conn);
            for (int i = 0; i < dt.Rows.Count; i++) {
                string XSqlString = "insert into [Sheet1$]";
                string imageurl = dt.Rows[i]["P_PhotoUrl"].ToString();
                if (imageurl.IndexOf("uploadfiels/product/", StringComparison.OrdinalIgnoreCase) == 0) {
                    imageurl = imageurl.Substring(20);
                }
                string docurl = dt.Rows[i]["P_Doc"].ToString();
                if (docurl.IndexOf("uploadfiels/doc/", StringComparison.OrdinalIgnoreCase) == 0) {
                    docurl = docurl.Substring(16);
                }

                XSqlString += "([產品編號],[類別名稱],[類別編號],[產品名稱(中文)],[產品名稱(英文)],[產品型號],[產品規格],[產品原料],[產品特性],[產品適用環境],[產品圖片],[產品文檔]) values(";
                XSqlString += "'" + dt.Rows[i]["P_Code"] + "','" + dt.Rows[i]["PC_ClassName"] + "','" + dt.Rows[i]["P_ClassID"] + "','" + dt.Rows[i]["P_Name"] + "','" + dt.Rows[i]["P_Name_En"] + "','" + dt.Rows[i]["P_Model"] + "','" + htmltocode(dt.Rows[i]["P_Spec"].ToString()) + "','" + dt.Rows[i]["P_Stock"] + "','" +htmltocode(dt.Rows[i]["P_Identity"].ToString()) + "','" + htmltocode(dt.Rows[i]["P_Evinr"].ToString()) + "','" + imageurl + "','" + docurl + "')";
                Cmd.CommandText = XSqlString;
                Cmd.ExecuteNonQuery();
            }
            //操作结束，关闭连接
            Conn.Close();
            //打开要下载的檔案，并把该檔案存放在FileStream中
            System.IO.FileStream Reader = System.IO.File.OpenRead(newFileName);
            //檔案传送的剩余字节数：初始值为檔案的总大小
            long Length = Reader.Length;
            HttpContext.Current.Response.Buffer = false;
            HttpContext.Current.Response.AddHeader("Connection", "Keep-Alive");
            HttpContext.Current.Response.ContentType = "application/octet-stream";
            HttpContext.Current.Response.Charset = "utf-8";
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            HttpContext.Current.Response.AddHeader("Content-Length", Length.ToString());
            byte[] Buffer = new Byte[10000];//存放欲发送数据的缓冲区
            int ByteToRead;//每次实际读取的字节数
            while (Length > 0) {
                //剩余字节数不为零，繼續传送                    
                if (HttpContext.Current.Response.IsClientConnected) {
                    //客户端浏览器还打开着，繼續传送 
                    ByteToRead = Reader.Read(Buffer, 0, 10000);
                    //往缓冲区读入数据
                    HttpContext.Current.Response.OutputStream.Write(Buffer, 0, ByteToRead);
                    //把缓冲区的数据写入客户端浏览器                       
                    HttpContext.Current.Response.Flush();
                    //立即写入客户端                        
                    Length -= ByteToRead;     //剩余字节数减少 
                } else {
                    //客户端浏览器已经断开，阻止繼續循环
                    Length = -1;
                }
            }
            //关闭该檔案                
            Reader.Close();
            //删除该Excel檔案                
            if (File.Exists(newFileName))
                File.Delete(newFileName);
        }
    }
}