using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ZeroStudio.DBUtility;
using ZeroStudio.Helper;
using System.Data.OleDb;
using System.Text;

namespace ZeroStudio.Web.Admin.Product {
    public partial class AutoUpload : System.Web.UI.Page {
        // Fields
        public string category_id;
        public string strHtml;
        public DataTable table;
        public BLL.ProductClass pclass = new ZeroStudio.BLL.ProductClass();

        public void AddProducts() {
            BLL.Product bll = new ZeroStudio.BLL.Product();
            StringBuilder err = new StringBuilder();
            string str = (base.Request["productids"] != null) ? base.Request["productids"].ToString() : "";
            try {
                if (str != "") {
                    string[] strArray = str.TrimEnd(new char[] { ',' }).TrimStart(new char[] { ',' }).Split(new char[] { ',' });
                    if (strArray.Length > 0) {
                        int addcount = 0;
                        int modfiycount = 0;
                        int errcount = 0;
                        for (int i = 0; i < strArray.Length; i++) {
                            string pcode = (Request["pcode[" + strArray[i] + "]"] != null) ? Request["pcode[" + strArray[i] + "]"].ToString() : "";
                            string pclassid = (Request["pclassid[" + strArray[i] + "]"] != null) ? Request["pclassid[" + strArray[i] + "]"].ToString() : "";
                            string pmodel = (Request["pmodel[" + strArray[i] + "]"] != null) ? Request["pmodel[" + strArray[i] + "]"].ToString() : "";
                            string pimageurl = (Request["pimageurl[" + strArray[i] + "]"] != null) ? Request["pimageurl[" + strArray[i] + "]"].ToString() : "";
                            string pdoc = (Request["pdoc[" + strArray[i] + "]"] != null) ? Request["pdoc[" + strArray[i] + "]"].ToString() : "";

                            //string categoryid = (Request["category_id"] != null) ? Request["category_id"].ToString() : "0";
                            int classid = 0;
                            if (int.TryParse(pclassid, out classid)) {
                                if (pclass.Exists(classid)) {
                                    IList<Model.ProductClass> categorysByParentId = pclass.GetModelList("PC_ParentID=" + classid);
                                    if ((categorysByParentId != null) && (categorysByParentId.Count > 0)) {
                                        err.Append("產品編號:" + pcode + ";錯誤:類別編號不是最下層\r\n");
                                        errcount++;
                                    } else {
                                        if (!string.IsNullOrEmpty(pcode)) {
                                            if (bll.Count("P_Code='" + pcode + "'") == 0) {
                                                Model.Product product = new ZeroStudio.Model.Product();

                                                product.P_ParentID = bll.GetMaxSortKey("") + 1;
                                                product.P_Code = pcode;
                                                product.P_Name = "";
                                                product.P_Name_En = "";
                                                product.P_Model = pmodel;
                                                product.P_Spec = "";
                                                product.P_Stock = "";
                                                product.P_Identity = "";
                                                product.P_PhotoUrl = "uploadfiles/product/" + pimageurl;
                                                product.P_Doc = "uploadfiles/doc/" + pdoc;
                                                product.P_Evinr = "";
                                                product.P_ClassID = classid;
                                                product.P_Uptime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                                product.P_State = 1;
                                                 product.Keywords="";
                                                product.Description="";
                                                bll.Add(product);
                                                addcount++;
                                            } else {
                                                Model.Product product = bll.GetModel(pcode);
                                                product.P_Model = pmodel;
                                                product.P_PhotoUrl = "uploadfiles/product/" + pimageurl;
                                                product.P_Doc = "uploadfiles/doc/" + pdoc;
                                                product.P_ClassID = classid;
                                                product.P_State = 1;
                                                bll.Update(product);
                                                modfiycount++;
                                            }
                                        } else {
                                            err.Append("產品編號: ;錯誤:產品編號有誤\r\n");
                                            errcount++;
                                        }
                                    }
                                } else {
                                    err.Append("產品編號:" + pcode + ";錯誤:類別編號不存在\r\n");
                                    errcount++;
                                }
                            } else {
                                err.Append("產品編號:" + pcode + ";錯誤:類別編號有誤\r\n");
                                errcount++;
                            }
                        }
                        Session["Info"] = err.ToString();
                        Session["AddCount"] = addcount;
                        Session["ModfiyCount"] = modfiycount;
                        Session["ErrCount"] = errcount;
                    }
                }
            } catch (Exception) {
                Response.Redirect("error.aspx?err=產品信息添加失敗!");
                return;
            }

            Response.Redirect("success.aspx?success=產品訊息添加成功!&backurl=Manage.aspx&otherurl=AutoUpload.aspx&action=add&title=產品");

        }

        private void DownloadExcel() {
            string url = "~/data/product.xls";
            base.Response.Redirect(url);
        }

        public void GetProduct() {
            //this.category_id = (base.Request["category"] != null) ? base.Request["category"].ToString() : "0";
            //IList<Model.ProductClass> categorysByParentId = pclass.GetModelList("PC_ParentID=" + this.category_id);
            //if ((categorysByParentId != null) && (categorysByParentId.Count > 0)) {
            //    base.Response.Redirect("error.aspx?err=請選擇最下層分類");
            //}
            string filename = "";
            HttpPostedFile file = base.Request.Files.Get("excelfile");
            if (file.FileName != "") {
                filename = base.Server.MapPath("~") + @"\data\productdata.xls";
                file.SaveAs(filename);
            }
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=Excel 12.0 Xml;";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            string selectCommandText = "";
            OleDbDataAdapter adapter = null;
            DataSet dataSet = null;
            selectCommandText = "select * from [Sheet1$]";
            adapter = new OleDbDataAdapter(selectCommandText, connectionString);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "table1");
            connection.Close();
            if (dataSet != null) {
                this.table = dataSet.Tables[0];
            }
        }
        
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                CommonFunction.IsAdmin();
                if (Request["action"] != null) {
                    if (Request["action"] == "downloadexcel") {
                        this.DownloadExcel();
                    } else if (Request["action"] == "importconfirm") {
                        this.GetProduct();
                    } else if (Request["action"] == "importinsert") {
                        this.AddProducts();
                    }
                }
            }
        }
        protected string GetCategoryList(string checkId, int count, string pid) {
            string str = "";
            IList<Model.ProductClass> categorysByParentId = pclass.GetModelList("PC_ParentID=" + pid);
            if ((categorysByParentId != null) && (categorysByParentId.Count > 0)) {
                foreach (Model.ProductClass category in categorysByParentId) {
                    if (category.PC_ClassName!= "") {
                        str = str + "<option value='" + category.PC_Id.ToString() + "'";
                    }
                    if (category.PC_Id.ToString() == checkId) {
                        str = str + " selected='selected'";
                    }
                    str = str + ">";
                    for (int i = 1; i < count; i++) {
                        str = str + "──";
                    }
                    str = str + category.PC_ClassName + "</option>";
                    str = str + GetCategoryList(checkId, count + 1, category.PC_Id.ToString());
                }
            }
            return str;
        }
        public string codetohtml(string str) {
            string newstr;
            if (string.IsNullOrEmpty(str)) {
                return "";
            }
            newstr = str.Replace("<", "&lt;");
            newstr = newstr.Replace(">", "&gt;");
            newstr = newstr.Replace("\r\n", "<br>");
            newstr = newstr.Replace(" ", "&nbsp;");
            return newstr;
        }
        public string htmltocode(string str) {
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
    }
}
