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
using DBUtility;

namespace Web.Admin.News {
    public partial class Edit : System.Web.UI.Page {
        BLL.PageClass bll = new BLL.PageClass();

        protected void Page_Load(object sender, EventArgs e) {
            Model.PageClass model = new Model.PageClass();
            model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]));
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                lb_ParentID.Text = model.ParentID.ToString();
                txtTitle.Text = model.ClassName;
                txtAuthor.Text = model.username;
                txtKeyword.Text = model.D_Keyword;
                txtDescription.Text = model.D_Description;
                FCKeditor1.Value = model.D_Content;

            }
        }

        
        protected void Sub_Click(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Model.PageClass model = new Model.PageClass();
            model.classid = Convert.ToInt32(Request.QueryString["P_id"]);
            model.ClassName = txtTitle.Text;
            model.ParentID = Convert.ToInt32(lb_ParentID.Text.ToString().Trim());
            model.username = txtAuthor.Text.Trim();
            model.C_show = true;
            model.D_Keyword = txtKeyword.Text;
            model.D_Description = txtDescription.Text;
            model.D_Content = FCKeditor1.Value;

            bll.Update(model);
            Response.Redirect("Manage.aspx");
        }
        
}
}