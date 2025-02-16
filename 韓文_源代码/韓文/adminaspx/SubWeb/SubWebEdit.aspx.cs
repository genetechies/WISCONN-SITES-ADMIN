using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
public partial class adminaspx_SubWeb_SubWebEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            if (Request.QueryString["swid"] != null)
            {
                Model.SubWeb sw = new BLL.SubWeb().GetModel(Convert.ToInt32(Request.QueryString["swid"].Split(',')[0]));
                ViewState["swid"] = sw.SWID;
                this.txtTitle.Text = sw.SWName;
                this.txtDomain.Text = sw.SWDomainName;
                this.txtDBName.Text = sw.SWDBName;
                this.txtDBID.Text = sw.SWDBID;
                this.txtDBService.Text = sw.SWDBService;
                this.txtDBUser.Text = sw.SWDBUser;
                this.txtDBPwd.Text = sw.SWDBUserPwd;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
           
                Model.SubWeb sw = new Model.SubWeb();
                sw.SWID = Convert.ToInt32(ViewState["swid"]);
                sw.SWName = this.txtTitle.Text.Trim();
                sw.SWDomainName = this.txtDomain.Text.Trim();
                sw.SWDBName = this.txtDBName.Text.Trim();
                sw.SWDBID = this.txtDBID.Text.Trim();
                sw.SWDBService = this.txtDBService.Text.Trim();
                sw.SWDBUser = this.txtDBUser.Text.Trim();
                sw.SWDBUserPwd = this.txtDBPwd.Text.Trim();
                new BLL.SubWeb().Update(sw);
                ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"修改成功！\");location.href=\"SubWebList.aspx\"</script>");
                this.txtTitle.Text = "";
                this.txtDomain.Text = "";
                this.txtDBName.Text = "";
                this.txtDBID.Text = "";
                this.txtDBService.Text = "";
                this.txtDBUser.Text = "";
                this.txtDBPwd.Text = ""; 
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"提交失敗！\")</script>");
        }
    }
}