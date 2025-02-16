using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
using System.Diagnostics;
using System.Data.SqlClient;
using DBUtility;

public partial class adminaspx_SubWeb_SubWebAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Model.SubWeb sw = new Model.SubWeb();
            sw.SWName = this.txtTitle.Text.Trim();
            sw.SWDomainName = this.txtDomain.Text.Trim();
            sw.SWDBName = this.txtDBName.Text.Trim();
            sw.SWDBID = this.txtDBID.Text.Trim();
            sw.SWDBService = this.txtDBService.Text.Trim();
            sw.SWDBUser = this.txtDBUser.Text.Trim();
            sw.SWDBUserPwd = this.txtDBPwd.Text.Trim();
            new BLL.SubWeb().Add(sw);

            new BLL.SubWeb().SubWebDatabase(txtDBName.Text);//创建子网站数据库

            new BLL.SubWeb().SubWebTable(txtDBName.Text);//复制子网站数据库

            new BLL.SubWeb().SubWebDelTable(txtDBName.Text);//删除表数据

            new BLL.SubWeb().SubWebCopyTable(txtDBName.Text);//复制表数据



            string pwd = CommonFunction.GetMD5string("0000");
            string SQL = string.Format("insert into {0}.dbo.admin(username,password)values('admin','{1}') ", txtDBName.Text, pwd);
            SQL += string.Format(" insert into {0}.dbo.Manager(M_AdminName, M_Password, M_DateTime)values('admin','{1}',getdate()) ", txtDBName.Text, pwd);

            SQL += string.Format(" insert into {0}.dbo.SubWeb(SWName, SWDomainName, SWDBService, SWDBName, SWDBID, SWDBUser, SWDBUserPwd) select SWName, SWDomainName, SWDBService, SWDBName, SWDBID, SWDBUser, SWDBUserPwd from SubWeb where SWName='{1}' ", txtDBName.Text, txtDBName.Text);

            DbHelperSQL.ExecuteSql(SQL);

            this.txtTitle.Text = "";
            this.txtDomain.Text = "";
            this.txtDBName.Text = "";
            this.txtDBID.Text = "";
            this.txtDBService.Text = "";
            this.txtDBUser.Text = "";
            this.txtDBPwd.Text = "";

            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"提交成功！\")</script>");

        }
        catch (Exception ex)
        {
            throw ex;
        }
        

    }
}