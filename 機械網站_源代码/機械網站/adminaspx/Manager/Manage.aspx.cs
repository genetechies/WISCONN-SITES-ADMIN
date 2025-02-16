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

namespace Web.Admin.Manager {
    public partial class Manage : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CommonFunction.IsAdmin();
            BLL.Manager bll = new BLL.Manager();
            rpt_List.DataSource = bll.GetAll();
            rpt_List.DataBind();
        }

        protected void Del_Click(object sender, CommandEventArgs e) {
            if (Session["Admin"] == null || Session["Admin"].ToString().ToLower() != "admin") {
                ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                return;
            }
            int m_id = Convert.ToInt32(e.CommandName);
            BLL.Manager bll = new BLL.Manager();
            Model.Manager model = bll.GetModel(m_id);
            if (model!=null&&model.AdminName.ToLower()=="admin")
                Response.Write("<script>alert('系統管理員不能刪除！ ');window.location.href='Manage.aspx';</script>");
            else {
                if (bll.Delete(m_id))
                    Response.Write("<script>window.location.href='Manage.aspx';</script>");
                else
                    MessageBox.Show(this, "刪除失敗");
            }
        }
        protected void lbRight_Click(object sender, EventArgs e) {
            LinkButton btn = sender as LinkButton;
            if (Session["Admin"] == null || Session["Admin"].ToString().ToLower() != "admin") {
                ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                return;
            }
            Response.Redirect("EditRight.aspx?m_id=" + btn.CommandArgument);
        }
        protected void Sub_Click(object sender, EventArgs e) {
            if (Session["Admin"] == null || Session["Admin"].ToString().ToLower() != "admin") {
                ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                return;
            }
            if (tb_password.Text != tb_password2.Text)
                Response.Write("<script>alert('兩次密碼不一致!');</script>");
            else {
                Model.Manager model = new Model.Manager();
                BLL.Manager bll = new BLL.Manager();
                model.AdminName = tb_adminname.Text;
                model.Password = CommonFunction.GetMD5string(tb_password.Text);//5-1-a-s-p-x
                if (bll.Exists(tb_adminname.Text.ToString()) == false) {
                    bll.Add(model);
                    Response.Write("<script>window.location.href='Manage.aspx';</script>");
                } else
                    Response.Write("<script>alert('管理員名已存在，添加失敗!');</script>");
            }
        }
    }
}
