using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Helper;

public partial class adminaspx_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tb_Name.Focus();

    }
    protected void Sub_Click(object sender, EventArgs e)
    {
        BLL.Manager bll = new BLL.Manager();
        if (Session["code"] != null)
        {
            if (Session["Code"].ToString() == ChkCode.Text)
            {
                string pwd = CommonFunction.GetMD5string(tb_Pwd.Text);
                if (bll.Exists(tb_Name.Text, pwd))
                {
                    Session["Admin"] = tb_Name.Text;
                    Response.Redirect("./Main.aspx");
                }
                else
                {
                    //Response.Write("<script>alert('用戶名或密碼錯誤!');history.go(-1);</script>");
                    Response.Write("<script>alert('用戶名或密碼錯誤!');location.href='default.aspx';</script>");
                }
            }
            else
            {
                //Response.Write("<script>alert('驗證碼錯誤!');history.go(-1);</script>");
                Response.Write("<script>alert('驗證碼錯誤!');location.href='default.aspx';</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('驗證碼錯誤!');location.href='default.aspx';</script>");
        }
    }
}
