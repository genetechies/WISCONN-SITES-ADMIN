using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string sUserName = HttpUtility.HtmlEncode(ttbUserName.Text.Trim());
            string sPwd = HttpUtility.HtmlEncode(ttbPwd.Text.Trim());
            DataView dv = new DataView();
            string strConnection = @"Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + MapPath("App_Data/db.mdb");

            OleDbConnection objConnection = new OleDbConnection(strConnection);

            objConnection.Open();
            OleDbCommand cmd = objConnection.CreateCommand();
            cmd.CommandText = "select   *   from  userlist where username = '" + sUserName + "'";
            OleDbDataReader odr = cmd.ExecuteReader();
            DataTable dt = new DataTable("translatorlist");
            dt.Load(odr);
            odr.Close();
            dv.Table = dt;
            objConnection.Close();

            if ((dv == null) || (dv.Count < 1))
            {
                lblStatus.Text = "UserName is null.";
                Session["username"] = "";

            }
            else
            {
                if (dv[0]["PWD"].ToString() == sPwd)
                {
                    Session["username"] = sUserName;
                    Response.Redirect("backstage02.aspx");
                }
                else
                {
                    lblStatus.Text = "PassWord is error.";
                    Session["username"] = "";
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}
