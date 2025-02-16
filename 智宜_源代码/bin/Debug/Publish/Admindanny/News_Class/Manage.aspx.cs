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
using ZeroStudio.DBUtility;

namespace ZeroStudio.Web.Admin.News_Class
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZeroStudio.Helper.CommonFunction.IsAdmin();
            BLL.NewsClass bll=new BLL.NewsClass();
            rpt_list.DataSource = bll.GetAll();
            rpt_list.DataBind();
        }

        protected void Del_Click(object sender, CommandEventArgs e)
        {
            BLL.NewsClass bll = new BLL.NewsClass();
            Model.NewsClass model = new Model.NewsClass();
            model.Id = Convert.ToInt32(e.CommandName);
            if (bll.Delete(model.Id))
                Response.Redirect("Manage.aspx");
            else
                MessageBox.Show(this, "刪除失敗");
        }

        protected void btnUpdateDB_Click(object sender, EventArgs e)
        {
            DbHelperOledb.ExecuteSql("ALTER TABLE NewsClass ADD COLUMN NC_ArtList_Title TEXT(255);");
            DbHelperOledb.ExecuteSql("ALTER TABLE NewsClass ADD COLUMN NC_ArtList_Description Memo;");
        }
    }
}
