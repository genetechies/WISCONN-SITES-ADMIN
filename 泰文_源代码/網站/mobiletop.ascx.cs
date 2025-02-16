using System;
using System.Data;

public partial class mobiletop : System.Web.UI.UserControl
{
    protected DataTable dtNewsClass;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtNewsClass = new DAL.NewsClass().GetList(" ParentID=1 ").Tables[0];
    }
}
