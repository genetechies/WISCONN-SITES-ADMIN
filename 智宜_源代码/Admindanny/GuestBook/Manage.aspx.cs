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

namespace ZeroStudio.Web.Admin.GuestBook
{
    public partial class Manage : System.Web.UI.Page
    {
        BLL.GuestBook bll = new BLL.GuestBook();
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonFunction.IsAdmin();
            AspNetPager1.RecordCount = bll.Count();
            Bind();
        }

        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = bll.GetAllList().Tables[0].DefaultView;

            rpt_list.DataSource = pds;
            rpt_list.DataBind();
        }

        protected void Del_Click(object sender, CommandEventArgs e)
        {
            string id = e.CommandName;
            bll.Delete(Convert.ToInt32(id));
            Bind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
