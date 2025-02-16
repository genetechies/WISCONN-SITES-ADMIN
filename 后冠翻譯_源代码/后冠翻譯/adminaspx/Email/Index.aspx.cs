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
using System.Text;

public partial class Admin_Email_Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "guestemail", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Bind();
        }
    }
    protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.DataSource = GetList().Tables[0].DefaultView;
        rpt_list.DataSource = pds;
        rpt_list.DataBind();
    }
    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * ");
        strSql.Append(" FROM EmailInfo ");
        return DbHelperOledb.Query(strSql.ToString());
    }
    protected void Del_Click(object sender, CommandEventArgs e)
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "guestemail", RightStatus.Delete))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        try
        {
            
        string id = e.CommandName;
        DbHelperOledb.ExecuteSql("delete from EmailInfo where G_Id="+id);
        Bind();
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "errorshow", "alert('操作失敗！');",true);
        }
    }
}
