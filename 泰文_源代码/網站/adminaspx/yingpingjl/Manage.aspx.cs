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
        BLL.TranslatorList bll = new BLL.TranslatorList();
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                AspNetPager1.RecordCount = bll.Count();
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            if (!string.IsNullOrEmpty(Where)) {
                pds.DataSource = bll.GetList(Where).Tables[0].DefaultView;
            } else {
                pds.DataSource = bll.GetAllList().Tables[0].DefaultView;
            }

            rpt_list.DataSource = pds;
            rpt_list.DataBind();
            for (int i = 0; i < rpt_list.Items.Count; i++) {
                Label lblIsFinish = rpt_list.Items[i].FindControl("lblIsFinish") as Label;
                DropDownList ddlFinish = rpt_list.Items[i].FindControl("ddlFinish") as DropDownList;
                if (lblIsFinish != null && ddlFinish != null) {
                    ddlFinish.SelectedValue = lblIsFinish.Text.Trim();
                }
            }
        }

        protected void Del_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Delete)) {
            //    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //    return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string id = e.CommandName;
            bll.Delete(Convert.ToInt32(id));
            Bind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e) {
            Bind();
        }
        protected void btnSearch_Click(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Where = "";
            if (!string.IsNullOrEmpty(txtUserName.Text)) {
                Where = " UserName like '%" + txtUserName.Text + "%'";
            }
            //if (!string.IsNullOrEmpty(txtCompanyName.Text)) {
            //    if (string.IsNullOrEmpty(Where)) {
            //        Where = "G_CompanyName like '%" + txtCompanyName.Text + "%'";
            //    } else {
            //        Where = Where + " and G_CompanyName like '%" + txtCompanyName.Text + "%'";
            //    }
            //}
            //if (!string.IsNullOrEmpty(txtTitle.Text)) {
            //    if (string.IsNullOrEmpty(Where)) {
            //        Where = "G_Title like '%" + txtTitle.Text + "%'";
            //    } else {
            //        Where = Where + " and G_Title like '" + txtTitle.Text + "%'";
            //    }
            //}
            if (string.IsNullOrEmpty(Where)) {
                AspNetPager1.RecordCount = bll.Count();
            } else {
                AspNetPager1.RecordCount = bll.GetList(Where).Tables[0].DefaultView.Count;
            }
            Bind();
        }
        protected void ddlFinish_SelectedIndexChanged(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Update)) {
            //    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //    return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            RepeaterItem item = (RepeaterItem)((Control)sender).Parent;
            DropDownList ddlFinish = sender as DropDownList;
            Label lblGID = item.FindControl("lblGID") as Label;
            if (lblGID != null) {
                
                bll.UpdateIsFinish(Convert.ToInt32(lblGID.Text.Trim()), Convert.ToInt32(ddlFinish.SelectedValue));
                Bind();
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
    }
}
