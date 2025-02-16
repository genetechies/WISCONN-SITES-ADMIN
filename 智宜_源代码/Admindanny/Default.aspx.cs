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
using ZeroStudio.Helper;

namespace ZeroStudio.Web.Admin {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            tb_Name.Focus();
        }

        protected void Sub_Click(object sender, EventArgs e) {
            BLL.Manager bll = new BLL.Manager();
            if (Session["Code"].ToString() == ChkCode.Text) {
                string pwd = CommonFunction.GetMD5string(tb_Pwd.Text);
                if (bll.Exists(tb_Name.Text, pwd)) {
                    Session["Admin"] = tb_Name.Text;
                    Response.Redirect("./Main.aspx");
                } else
                    Response.Write("<script>alert('用戶名或密碼錯誤!');history.go(-1);</script>");
            } else {
                Response.Write("<script>alert('驗證碼錯誤!');history.go(-1);</script>");
            }
        }
    }
}
