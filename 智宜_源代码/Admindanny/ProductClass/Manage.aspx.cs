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
using CommonFunc;
using ZeroStudio.DBUtility;

namespace ZeroStudio.Web.Admin.ProductClass
{
    public partial class Manage : System.Web.UI.Page {
        BLL.ProductClass b = new ZeroStudio.BLL.ProductClass();
        private void InitCategory() {
            if (string.IsNullOrEmpty(Request.QueryString["ParentID"])) {
                lblParentID.Text = "0";
                lblSortKey.Text = (b.GetMaxSortKey("PC_ParentID=0") + 1).ToString();
                lblParent.Text = "根類";
            } else {
                lblParentID.Text = Request.QueryString["ParentID"];
                lblSortKey.Text = (b.GetMaxSortKey("PC_ParentID=" + (Convert.ToInt32(Request.QueryString["ParentID"]))) + 1).ToString();
                Model.ProductClass cate = b.GetModel(Convert.ToInt32(Request.QueryString["ParentID"]));
                if (cate != null) {
                    lblParent.Text = cate.PC_ClassName;
                }
            }
            btnAdd.Text = "新增";
        }
        private void reset() {
            btnAdd.Text = "新增";
            txtCategoryName.Text = "";
            txtCategoryNameEn.Text = "";
            lblCategoryID.Text = "";
            txtPhotoUrl.Text = "";
            description.Text = "";
            keywords.Text = "";
            lblSortKey.Text = (b.GetMaxSortKey("PC_ParentID=" + (Convert.ToInt32(string.IsNullOrEmpty(Request.QueryString["ParentID"]) ? "0" : Request.QueryString["ParentID"]))) + 1).ToString();
        }
        public string GetImage(object imageurl, object name) {
            if (imageurl != null && imageurl.ToString() != "") {
                return ("<span class=\"op_pic\"><a href=\"javascript:void(0)\" title=\"<img src='/" + imageurl.ToString() + "'>\" >" + name.ToString() + "</a></span>");
            }
            return ("<span><a href=\"javascript:void(0)\" >" + name.ToString() + "</a></span>");
        }
        protected void UpFile_Click(object sender, EventArgs e) {
            if (FileUpload1.HasFile) {
                string Name = FileUpload1.FileName;
                //文档上傳到的固定目录 如果需要修改必须必须3個都修改
                string SaveSoft = Server.MapPath("~\\uploadfiles\\class\\");
                string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
                string newName = "";
                if (Name != "") {
                    newName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + "." + Fe;
                }
                SaveSoft += newName;
                if (!Directory.Exists(Server.MapPath("~\\uploadfiles\\class\\"))) {
                    Directory.CreateDirectory(Server.MapPath("~\\uploadfiles\\class\\"));
                }
                FileUpload1.SaveAs(SaveSoft);
                txtPhotoUrl.Text = "uploadfiles\\class\\" + newName;
                //上傳缩略图
                //AutoThumb.UploadThumbnail(FileUpload1, tb_PhotoUrlSmall, 140, "_S");
            } else {
                ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的圖片');", true);
                return;
            }
        }
        protected void btnAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(lblCategoryID.Text)) {
                //int count = 0;
                //count = Convert.ToInt32(DbHelperOledb.ExecuteScalar("select count(1) from ProductClass where PC_ClassName='" + txtCategoryName.Text + "'"));
                //if (count > 0) {
                //    ClientScript.RegisterStartupScript(GetType(), "nameerror", "alert('該類別已經存在！');", true);
                //    return;
                //}
                Model.ProductClass info = new ZeroStudio.Model.ProductClass();
                info.PC_ClassName = txtCategoryName.Text;
                info.PC_ClassNameEn = txtCategoryNameEn.Text;
                info.PC_ParentID = Convert.ToInt32(lblParentID.Text);
                info.PC_SortKey = Convert.ToInt32(lblSortKey.Text);
                info.PC_ImageUrl = string.IsNullOrEmpty(txtPhotoUrl.Text) ? "" : txtPhotoUrl.Text;
                info.Description = description.Text;
                info.Keywords = keywords.Text;
                b.Add(info);
                GridDataBind();
                txtCategoryName.Text = "";
                lblSortKey.Text = (b.GetMaxSortKey("PC_ParentID=" + (Convert.ToInt32(string.IsNullOrEmpty(Request.QueryString["ParentID"]) ? "0" : Request.QueryString["ParentID"]))) + 1).ToString();
            } else {
                //int count = 0;
                //count = Convert.ToInt32(DbHelperOledb.ExecuteScalar("select count(1) from ProductClass where PC_ClassName='" + txtCategoryName.Text + "' and PC_Id<>" + lblCategoryID.Text));
                //if (count > 0) {
                //    ClientScript.RegisterStartupScript(GetType(), "nameerror", "alert('該類別已經存在！');", true);
                //    return;
                //}
                Model.ProductClass info = b.GetModel(Convert.ToInt32(lblCategoryID.Text));
                if (info != null) {
                    info.PC_ClassName = txtCategoryName.Text;
                    info.PC_ClassNameEn = txtCategoryNameEn.Text;
                    info.PC_ImageUrl = string.IsNullOrEmpty(txtPhotoUrl.Text) ? "" : txtPhotoUrl.Text;
                    info.Description = description.Text;
                    info.Keywords = keywords.Text;
                    b.Update(info);
                    GridDataBind();
                    reset();
                }
            }
        }
        protected void btnModfiy_Click(object sender, EventArgs e) {
            LinkButton btn = sender as LinkButton;
            int categoryID = Convert.ToInt32(btn.CommandArgument);
            Model.ProductClass info = b.GetModel(categoryID);
            if (info != null) {
                lblCategoryID.Text = info.PC_Id.ToString();
                txtCategoryName.Text = info.PC_ClassName;
                txtCategoryNameEn.Text = info.PC_ClassNameEn;
                lblSortKey.Text = info.PC_SortKey.ToString();
                txtPhotoUrl.Text = info.PC_ImageUrl;
                description.Text = info.Description;
               keywords.Text = info.Keywords ;
                btnAdd.Text = "保存";
            }
        }
        protected void btnDelete_Click(object sender, EventArgs e) {
            LinkButton btn = sender as LinkButton;
            int categoryID = Convert.ToInt32(btn.CommandArgument);
            int count = Convert.ToInt32(DbHelperOledb.ExecuteScalar("select count(1) from ProductClass where PC_ParentID=" + categoryID));
            if (count == 0) {
                Model.ProductClass info = b.GetModel(categoryID);
                b.Delete(categoryID);
                DbHelperOledb.ExecuteSql("update ProductClass set PC_SortKey=PC_SortKey-1 where PC_ParentID=" + info.PC_ParentID + " and PC_SortKey>" + info.PC_SortKey);
                GridDataBind();
                lblSortKey.Text = (b.GetMaxSortKey("PC_ParentID=" + (Convert.ToInt32(string.IsNullOrEmpty(Request.QueryString["ParentID"]) ? "0" : Request.QueryString["ParentID"]))) + 1).ToString();
            } else {
                ClientScript.RegisterStartupScript(GetType(), "delerror", "alert('該類別下還有子類，不能刪除！');", true);
            }
        }
        protected void btnModfiySortKey_Click(object sender, EventArgs e) {
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);
            DropDownList ddlSortKey = categoryGrid.Rows[rowindex].Cells[3].FindControl("ddlSortKey") as DropDownList;
            Label lblCateID = categoryGrid.Rows[rowindex].Cells[3].FindControl("lblCateID") as Label;
            Model.ProductClass info = b.GetModel(Convert.ToInt32(lblCateID.Text));
            DataView ds = b.GetList("PC_ParentID=" + info.PC_ParentID + " and PC_SortKey=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;
            if (info != null ) {
            //string sql = "update ProductClass set PC_SortKey=" + ddlSortKey.SelectedValue + " where PC_Id=" + info.PC_Id.ToString();
            //string sql1 = "update ProductClass set PC_SortKey=" + info.PC_SortKey + " where PC_Id=" + ds[0]["PC_Id"].ToString();
            var sortkey = Convert.ToInt32(ddlSortKey.SelectedValue);
                ArrayList list = new ArrayList();
                if (sortkey < info.PC_SortKey) //数值减少
                {
                    list.Add("update ProductClass set PC_SortKey=PC_SortKey+1 where  PC_SortKey >=" + sortkey + " and PC_SortKey<=" + info.PC_SortKey + " and PC_ParentID=" + info.PC_ParentID + " and PC_SortKey<PC_SortKey+1");
                }
                else //输值增大
                {
                    list.Add("update ProductClass set PC_SortKey=PC_SortKey-1 where  PC_SortKey <=" + sortkey + " and PC_SortKey>=" + info.PC_SortKey + " and PC_ParentID=" + info.PC_ParentID + " and PC_SortKey>PC_SortKey-1");
                }

                list.Add("update ProductClass set PC_SortKey=" + sortkey + " where PC_Id=" + info.PC_Id);
                DbHelperOledb.ExecuteSqlTran(list);
                GridDataBind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }

        private void FormatData(DataView dv) {
            for (int i = 0; i < categoryGrid.Rows.Count; i++) {
                DropDownList ddlSortKey = categoryGrid.Rows[i].Cells[3].FindControl("ddlSortKey") as DropDownList;
                int parentID = 0;
                if (!string.IsNullOrEmpty(Request.QueryString["ParentID"])) {
                    parentID = Convert.ToInt32(Request.QueryString["ParentID"]);
                }
                int maxSortKey = b.GetMaxSortKey("PC_ParentID=" + parentID);
                for (int j = 1; j <= maxSortKey; j++) {
                    ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }
                ddlSortKey.SelectedValue = dv[i]["PC_Sortkey"].ToString();
            }
            if (dv != null) {
                dv.Dispose();
            }
        }

        private void GridDataBind() {
            string where = string.Empty;
            if (string.IsNullOrEmpty(Request.QueryString["ParentID"])) {
                where = "PC_ParentID=0";
            } else {
                where = "PC_ParentID=" + Request.QueryString["ParentID"];
            }

            DataView dv = b.GetList(where).Tables[0].DefaultView;
            categoryGrid.DataSource = dv;
            categoryGrid.DataBind();
            FormatData(dv);
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (!this.Page.IsPostBack) {
                this.GridDataBind();
                InitCategory();
            }
        }
        protected void btnBack_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(Request.QueryString["ParentID"])) {
                Model.ProductClass info =b.GetModel(Convert.ToInt32(Request.QueryString["ParentID"]));
                if (info != null) {
                    if (info.PC_ParentID != 0) {
                        Response.Redirect("Manage.aspx?ParentID=" + info.PC_ParentID);
                    } else {
                        Response.Redirect("Manage.aspx");
                    }
                } else {
                    Response.Redirect("Manage.aspx");
                }
            } else {
                Response.Redirect("Manage.aspx");
            }
        }
        protected void categoryGrid_RowDataBound(object sender, GridViewRowEventArgs e) {
            if (e.Row.RowType == DataControlRowType.DataRow) {
                LinkButton btn = e.Row.Cells[3].FindControl("btnModfiySortKey") as LinkButton;
                btn.CommandArgument = e.Row.RowIndex.ToString();
            }
        }
    }
}
