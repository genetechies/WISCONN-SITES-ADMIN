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
using System.Text;
using ZeroStudio.DBUtility;

namespace ZeroStudio.Web.Admin.Product {
    public partial class Manage : System.Web.UI.Page {
        BLL.Product bll = new ZeroStudio.BLL.Product();
        BLL.ProductClass cate = new ZeroStudio.BLL.ProductClass();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                Where = "[Product].[P_State]=1";
                AspNetPager1.RecordCount = bll.CountByClass(Where);
                Bind();
                BindClass();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            if (Where.Contains(" and "))
            {
                pds.DataSource = bll.GetListByClass(Where, "P_ParentId").Tables[0].DefaultView;
            }
            else
            {
                pds.DataSource = bll.GetListByClass(Where, "P_Code").Tables[0].DefaultView;
            }
            productGrid.DataSource = pds;
            productGrid.DataBind();
        }
        public string GetImage(object productId, object name) {
            Model.Product product = bll.GetModel((int)productId);
            if (product != null) {
                if (product.P_PhotoUrl != "") {
                    return ("<span class=\"op_pic\"><a href=\"/Products-detail.aspx?P_Id="  + productId.ToString() + "\" title=\"<img src='/" + product.P_PhotoUrl + "'>\" target=\"_blank\">" + name.ToString() + "</a></span>");
                }
                return ("<span><a href=\"/Products-detail.aspx?P_Id=" + productId.ToString() + "\" target=\"_blank\">" + name.ToString() + "</a></span>");
            }
            return ("<span><a href=\"/Products-detail.aspx?P_Id=" +  productId.ToString() + "\" target=\"_blank\">" + name.ToString() + "</a></span>");
        }
        
        protected void Del_Click(Object sender, EventArgs e) {
            LinkButton btn = sender as LinkButton;
            int p_id=Convert.ToInt32(btn.CommandArgument);
            bll.UpdateState(p_id, 0);
            Bind();
            /*
            Model.Product model = bll.GetModel(p_id);
            if (model != null) {
                bll.Delete(p_id);
                if (!string.IsNullOrEmpty(model.P_PhotoUrl)) {
                    try {
                        System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_PhotoUrl);
                    } catch (Exception) { }
                }
                if (!string.IsNullOrEmpty(model.P_Doc)) {
                    try {
                        System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_Doc);
                    } catch (Exception) { }
                }
                Bind();
            }
            */
        }
        protected void btnDelAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < productGrid.Items.Count; i++) {
                Label lblPID = productGrid.Items[i].FindControl("lblPID") as Label;
                CheckBox cbSelect = productGrid.Items[i].FindControl("cbSelect") as CheckBox;
                if (lblPID != null && cbSelect != null) {
                    if (cbSelect.Checked) {
                        int p_id = Convert.ToInt32(lblPID.Text.Trim());
                        bll.UpdateState(p_id, 0);
                        /*
                        Model.Product model = bll.GetModel(p_id);
                        if (model != null) {
                            bll.Delete(p_id);
                            if (!string.IsNullOrEmpty(model.P_PhotoUrl)) {
                                try {
                                    System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_PhotoUrl);
                                } catch (Exception) { }
                            }
                            if (!string.IsNullOrEmpty(model.P_Doc)) {
                                try {
                                    System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_Doc);
                                } catch (Exception) { }
                            }
                        }
                        */
                    }
                }
            }
            Bind();
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e) {
            Bind();
        }
        private void BindClass() {
            DataView dv = cate.GetList("PC_ParentID=0").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                ddlCategory.Items.Add(new ListItem(dv[i]["PC_ClassName"].ToString(), dv[i]["PC_Id"].ToString()));
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(searchText1.Text) && searchText1.Text.Trim() != "查詢產品訊息") {
                Where = "[Product].[P_State]=1 and [Product].[P_Model] like '%" + searchText1.Text + "%'";
            } else {
                Where = "[Product].[P_State]=1";
            }
            if (ddlCategory3.SelectedValue != "-1")
            {
                if (!string.IsNullOrEmpty(Where))
                {
                    Where = Where + " and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory3.SelectedValue)) + ")";
                }
                else
                {
                    Where = "[Product].[P_State]=1 and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory3.SelectedValue)) + ")";
                }
            }
            else if (ddlCategory2.SelectedValue != "-1")
            {
                if (!string.IsNullOrEmpty(Where))
                {
                    Where = Where + " and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory2.SelectedValue)) + ")";
                }
                else
                {
                    Where = "[Product].[P_State]=1 and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory2.SelectedValue)) + ")";
                }
            }
            else if (ddlCategory.SelectedValue != "-1") {
                if (!string.IsNullOrEmpty(Where)) {
                    Where = Where + " and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory.SelectedValue)) + ")";
                } else {
                    Where = "[Product].[P_State]=1 and [Product].[P_ClassID] in(" + QueryStr(Convert.ToInt32(ddlCategory.SelectedValue)) + ")";
                }
            }


            AspNetPager1.RecordCount = bll.CountByClass(Where);
            Bind();
        }

        private string QueryStr(int classid) {
            StringBuilder append = new StringBuilder(classid.ToString() + ",");
            DataView dv = cate.GetList("PC_ParentID=" + classid).Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                QueryStrChild(Convert.ToInt32(dv[i]["PC_Id"].ToString()), append);
            }
            string result = append.ToString();
            if (append.ToString().EndsWith(",")) {
                result = result.Substring(0, result.Length - 1);
            }
            return result;
        }
        private void QueryStrChild(int classid, StringBuilder append) {
            append.Append(classid.ToString() + ",");
            DataView dv = cate.GetList("PC_ParentID=" + classid).Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                QueryStrChild(Convert.ToInt32(dv[i]["PC_Id"].ToString()), append);
            }
        }
       
        protected void productGrid_ItemCommand(object source, RepeaterCommandEventArgs e) {
            if (e.CommandName == "modfiy") {
                LinkButton link = e.CommandSource as LinkButton;
                int index = Convert.ToInt32(e.CommandArgument);
                Label lblPID = productGrid.Items[index].FindControl("lblPID") as Label;
                TextBox sortkey = productGrid.Items[index].FindControl("txtParentID") as TextBox;
                if (lblPID != null && sortkey != null) {
                    int p_id = Convert.ToInt32(lblPID.Text.Trim());
                    Model.Product p = bll.GetModel(p_id);
                    int sort = 0;
                    try {
                        sort = Convert.ToInt32(sortkey.Text);
                    } catch (Exception) {
                        ClientScript.RegisterStartupScript(GetType(), "error", "alert('無效的排序號');", true);
                        return;
                    }
                    if (sort < 0) {
                        ClientScript.RegisterStartupScript(GetType(), "error", "alert('排序號必須為大於零的正整數');", true);
                        return;
                    }
                    if (p.P_ParentID != sort) {
                        bll.UpdateSortKey(p_id, sort);
                    }
                    Bind();
                }
            }
        }
        protected void productGrid_ItemDataBound(object sender, RepeaterItemEventArgs e) {
            if (e.Item.ItemType ==ListItemType.Item||e.Item.ItemType==ListItemType.AlternatingItem) {
                TextBox sortkey =e.Item.FindControl("txtParentID") as TextBox;
                LinkButton modfiy =e.Item.FindControl("btnModfiySortKey") as LinkButton;
                if (modfiy != null && sortkey != null) {
                    modfiy.Attributes.Add("onclick", "return validText('" + sortkey.ClientID + "');");
                    modfiy.CommandArgument = e.Item.ItemIndex.ToString();
                }
            }
        }

        public string Where {
            get {
                if (ViewState["Where"] == null)
                    ViewState["Where"] = "";
                return (string)ViewState["Where"];
            }
            set {
                ViewState["Where"] = value;
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCategory2.Items.Clear();
            ddlCategory2.Items.Add(new ListItem("請選擇第二層產品分類", "-1"));
            ddlCategory3.Items.Clear();
            ddlCategory3.Items.Add(new ListItem("請選擇第三層產品分類", "-1"));
            DataView dv = cate.GetList("PC_ParentID=" + ddlCategory.SelectedValue).Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                ddlCategory2.Items.Add(new ListItem(dv[i]["PC_ClassName"].ToString(), dv[i]["PC_Id"].ToString()));
            }
        }

        protected void ddlCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCategory3.Items.Clear();
            ddlCategory3.Items.Add(new ListItem("請選擇第三層產品分類", "-1"));
            DataView dv = cate.GetList("PC_ParentID=" + ddlCategory2.SelectedValue).Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                ddlCategory3.Items.Add(new ListItem(dv[i]["PC_ClassName"].ToString(), dv[i]["PC_Id"].ToString()));
            }
        }

        protected void btnUpdateDB_Click(object sender, EventArgs e)
        {
            DbHelperOledb.ExecuteSql("ALTER TABLE Product ADD COLUMN UpKey TEXT(255);");
            DbHelperOledb.ExecuteSql("ALTER TABLE Product ADD COLUMN DownKey TEXT(255);");
        }
    }
}