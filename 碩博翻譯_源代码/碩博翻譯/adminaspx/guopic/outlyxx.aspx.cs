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
            string filename=DateTime.Now.ToString("yyyyMMdd")+"logo";
            DataSetToCsv(filename);
        }


        /// <summary>
        /// csv导出
        /// </summary>
        /// <param name="ds"></param>
        public void DataSetToCsv(string FileName)
        {
            DataSet ds = bll.GetoutList();
            string data = "";
            //data = ds.DataSetName + "\n";
            foreach (DataTable tb in ds.Tables)
            {
                //data += tb.TableName + "\n";
                //写出列名
                foreach (DataColumn column in tb.Columns)
                {
                    //用Tab分隔，可换为其他符号
                    data += column.ColumnName + ",";
                }
                data += "\n";

                //写出数据
                foreach (DataRow row in tb.Rows)
                {
                    foreach (DataColumn column in tb.Columns)
                    {
                        //if (column.ColumnName == "聯繫電話")
                        //{
                        //    data += "\"" + row[column].ToString() + "。 \",";
                        //}
                        //else if (column.ColumnName == "應聘時間")
                        //{
                        //    data += "\"" + row[column].ToString() + "。  \",";
                        //}
                        //else
                        //{
                            //用Tab分隔，可换为其他符号
                            data += "\"" + row[column].ToString().Replace("UploadFiles/","") + "  \",";
                        //}
                    }
                    data += "\n";
                }
                data += "\n";
            }

            if (data != "")
            {
                string temp = string.Format("attachment;filename={0}", FileName + ".csv");
                Response.ClearHeaders();
                Response.ContentEncoding = System.Text.Encoding.Default;
                Response.AppendHeader("Content-disposition", temp);
                Response.Write(data);
                Response.End();
            }
        }
}
}
