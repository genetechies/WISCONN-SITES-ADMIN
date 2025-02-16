using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Helper;
using System.Data.SqlClient;

public partial class adminaspx_SubWeb_SubWebList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataSet ds = new BLL.SubWeb().GetAllList();
            this.productGrid.DataSource = ds;
            this.productGrid.DataBind();
        }
    }
    protected void Del_Click(object sender, EventArgs e)
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Delete))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            // return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
           
        }
        try
        {
           int swid = int.Parse((((sender as LinkButton).Parent as RepeaterItem).FindControl("Del") as LinkButton).CommandArgument.Split(',')[0]);
           new BLL.SubWeb().Delete(swid);
           string databaseName = (((sender as Label).Parent as RepeaterItem).FindControl("Del") as Label).Text;

           //new BLL.SubWeb().SubWebDelDatabase(databaseName);//刪除子网站数据库

          ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"刪除成功！\")</script>");
          this.productGrid.DataSource = new BLL.SubWeb().GetAllList();
          this.productGrid.DataBind();
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"刪除失敗！\")</script>");
        }
    }
    protected void Test_Click(object sender, EventArgs e)
    {

        try
        {
            int swid = int.Parse((((sender as LinkButton).Parent as RepeaterItem).FindControl("Test") as LinkButton).CommandArgument.Split(',')[0]);
           Model.SubWeb demo = new BLL.SubWeb().GetModel(swid);

           //创建一个 SqlConnection对象 
           string strCon = "server="+demo.SWDBService+";database=" + demo.SWDBName + ";uid=" + demo.SWDBUser + ";Password=" + demo.SWDBUserPwd + ";Connect Timeout=5";
           //string strCon = "server=.;database=Manage;uid=sa;Password=123;Connect Timeout=30";
            SqlConnection myConn = new SqlConnection(strCon);

            //创建一个 DataSet对象
            myConn.Open();
            myConn.Close();
            //关闭连接
            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"連接成功！\")</script>");
        }
        catch (Exception ex1)
        {
            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"連接失败！\")</script>");
        }

        
    }
    protected void btnDelAll_Click(object sender, EventArgs e)
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Delete))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            // return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            
        }

        try
        {
            string swid = "";
            for (int i = 0; i < this.productGrid.Items.Count; i++)
            {
                if ((this.productGrid.Items[i].FindControl("cbSelect") as CheckBox).Checked)
                {
                    if (i == this.productGrid.Items.Count - 1)
                    {
                        swid += (this.productGrid.Items[i].FindControl("Del") as LinkButton).CommandArgument.Split(',')[0];
                    }
                    else
                    {
                        swid += (this.productGrid.Items[i].FindControl("Del") as LinkButton).CommandArgument.Split(',')[0] + ",";
                    }
                }
            }
            if (swid != "")
            {
                new BLL.SubWeb().DeleteList(swid);
                ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"刪除成功！\")</script>");
                this.productGrid.DataSource = new BLL.SubWeb().GetAllList();
                this.productGrid.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"請至少選擇一行刪除！\")</script>");
            }
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(GetType(), "alert", "<script>alert(\"刪除失敗！\")</script>");
        }
    }
    protected void productGrid_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void productGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        this.productGrid.DataSource = new BLL.SubWeb().GetModelList("SWName like '%"+this.searchText1.Text.Trim()+"%'");
        this.productGrid.DataBind();
    }
    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {

    }
}