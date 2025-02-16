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
public partial class Admin_Email_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {

            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "guestemail", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (!string.IsNullOrEmpty(Request.QueryString["G_Id"]))
            {
                int g_id = Convert.ToInt32(Request.QueryString["G_Id"]);
                DataSet ds = DbHelperOledb.Query("select * from EmailInfo where G_Id=" + g_id);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtUserName.Text = ds.Tables[0].Rows[0]["G_Name"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["G_Email"].ToString();
                }
                gid.Value = g_id.ToString();
            }
            else
            {
                gid.Value = "0";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            
        string sql = "";
        if (gid.Value == "0")
        {
            sql = "insert into emailinfo(g_name,g_email) values ('" + txtUserName.Text + "','" + txtEmail.Text + "')";
        }
        else {
            sql = "update emailinfo set g_name ='" + txtUserName.Text + "',g_email='" + txtEmail.Text + "' where g_id="+gid.Value;
        }
        if (DbHelperOledb.ExecuteSql(sql) > 0)
        {
            Response.Redirect("Index.aspx");
        }
        else {
            ClientScript.RegisterStartupScript(GetType(), "errorshow", "alert('操作失敗！');",true);
        }
        }
        catch (Exception)
        {
             ClientScript.RegisterStartupScript(GetType(), "errorshow", "alert('操作失敗！');",true);
        }
    }
}
