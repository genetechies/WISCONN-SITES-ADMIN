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
using ZeroStudio.DBUtility;
using ZeroStudio.Helper;
using System.IO;

namespace ZeroStudio.Web.Admin.Product {
    public partial class Edit : System.Web.UI.Page {
        BLL.Product bll = new ZeroStudio.BLL.Product();
        protected void Page_Load(object sender, EventArgs e) {
            ZeroStudio.Helper.CommonFunction.IsAdmin();

            if (!IsPostBack) {
                Model.Product model = null;
                if (!string.IsNullOrEmpty(Request.QueryString["P_id"])) {
                    model = bll.GetModel(Convert.ToInt32(Request["P_id"]));
                }
                txtCode.Text = model.P_Code;
                txtModel.Text = model.P_Model;
                txtDoc.Text = model.P_Doc;
                txtPhotoUrl.Text = model.P_PhotoUrl;
                BindDrpClass();
                MyDL.SelectedValue = model.P_ClassID.ToString();
                description.Text = model.Description;
                keywords.Text = model.Keywords;
                txtUpKey.Text = model.UpKey;
                txtDownKey.Text = model.DownKey;
            }
        }


        protected void Sub_Click(object sender, EventArgs e) {
            //查询選擇类的父类ID和Classcode
            //string sqlClass = "select * from [ProductClass] where PC_id=" + MyDL.SelectedValue;
            int classid = int.Parse(MyDL.SelectedValue);
            if (classid == -1) {
                MessageBox.Show(this, "請選擇一個分類！");
                return;
            }
            BLL.ProductClass cbll = new ZeroStudio.BLL.ProductClass();
            int count = cbll.GetList("PC_ParentID=" + MyDL.SelectedValue).Tables[0].DefaultView.Count;
            if (count > 0) {
                MessageBox.Show(this, "請選擇最下層的分類！");
                return;
            }
            count = bll.Count("P_Code='" + txtCode.Text + "' and P_Id<>" + Request["P_id"]);
            if (count > 0) {
                MessageBox.Show(this, "產品編號已經存在！請重新輸入");
                return;
            }
            //DataTable Dt = DbHelperOledb.GetDataTable(sqlClass);
     

            Model.Product model = bll.GetModel(Convert.ToInt32(Request["P_id"]));

            if (model != null) {

                model.P_Code = txtCode.Text.Trim();
                model.P_Model = txtModel.Text;
                model.P_ClassID = Convert.ToInt32(MyDL.SelectedValue);
                model.P_PhotoUrl = txtPhotoUrl.Text;
                model.P_Doc = txtDoc.Text;
                model.Keywords = keywords.Text;
                model.Description = description.Text;
                model.UpKey = txtUpKey.Text;
                model.DownKey = txtDownKey.Text;

                bll.Update(model);
                Response.Redirect("manage.aspx");
            }
        }

        #region 下拉列表框绑定函数定义标记

        //绑定顶级分类
        private void BindDrpClass() {
            DataTable dt = GetClassList("").Tables[0];
            MyDL.Items.Clear();
            MyDL.Items.Add(new ListItem("請選擇", "-1"));
            DataRow[] drs = dt.Select("PC_ParentID= " + 0, "PC_SortKey asc");

            foreach (DataRow dr in drs) {
                string classid = dr["PC_id"].ToString();
                string classname = dr["PC_ClassName"].ToString();
                //顶级分类显示形式
                classname = "├" + classname;

                MyDL.Items.Add(new ListItem(classname, classid));
                int sonparentid = int.Parse(classid);
                string blank = "├─";
                //递归子分类方法
                BindNode(sonparentid, dt, blank);
            }
            MyDL.DataBind();
        }
        //绑定子分类
        private void BindNode(int parentid, DataTable dt, string blank) {
            DataRow[] drs = dt.Select("PC_ParentID= " + parentid, "PC_SortKey asc");
            foreach (DataRow dr in drs) {
                string classid = dr["PC_id"].ToString();
                string classname = dr["PC_ClassName"].ToString();

                classname = blank + classname;
                MyDL.Items.Add(new ListItem(classname, classid));

                int sonparentid = int.Parse(classid);
                string blank2 = blank + "──";

                BindNode(sonparentid, dt, blank2);
            }
        }
        public DataSet GetClassList(string strWhere) {
            string strsql = "select * from ProductClass";
            if (strWhere.Trim() != "") {
                strsql += strsql;
            }

            return DbHelperOledb.Query(strsql);
        }

        #endregion;

        protected void UpFile_Click(object sender, EventArgs e) {
            if (FileUpload1.HasFile) {
                string Name = FileUpload1.FileName;
                //文档上傳到的固定目录 如果需要修改必须必须3個都修改
                string SaveSoft = Server.MapPath("~/UploadFiles/product/");
                string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
                string newName = Name;
                //if (Name != "") {
                //    newName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + "." + Fe;

                //}
                SaveSoft += newName;
                if (!Directory.Exists(Server.MapPath("~/UploadFiles/product/"))) {
                    Directory.CreateDirectory(Server.MapPath("~/UploadFiles/product/"));
                }
                FileUpload1.SaveAs(SaveSoft);
                txtPhotoUrl.Text = "UploadFiles/product/" + newName;
                //上傳缩略图
                //AutoThumb.UploadThumbnail(FileUpload1, tb_PhotoUrlSmall, 140, "_S");
            } else {
                ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的圖片');", true);
                return;
            }
        }

        protected void UpFileDoc_Click(object sender, EventArgs e) {
            if (FileUpload2.HasFile) {
                string Name = FileUpload2.FileName;
                //文档上傳到的固定目录 如果需要修改必须必须3個都修改
                string SaveSoft = Server.MapPath("~/UploadFiles/doc/");
                string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
                string newName = Name;
                //if (Name != "") {
                //    newName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + "." + Fe;

                //}
                SaveSoft += newName;
                if (!Directory.Exists(Server.MapPath("~/UploadFiles/doc/"))) {
                    Directory.CreateDirectory(Server.MapPath("~/UploadFiles/doc/"));
                }
                FileUpload2.SaveAs(SaveSoft);
                txtDoc.Text = "UploadFiles/doc/" + newName;
                //上傳缩略图
                //AutoThumb.UploadThumbnail(FileUpload1, tb_PhotoUrlSmall, 140, "_S");
            } else {
                ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的檔案');", true);
                return;
            }
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

        private string codetohtml(string str) {
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
    }
}