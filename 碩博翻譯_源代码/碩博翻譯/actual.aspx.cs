using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class actual : System.Web.UI.Page
{
    protected DataTable dtClass;
    protected DataTable dtInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtClass = new DAL.guoclass().GetList("").Tables[0];

        string where = " 1=1 ";
        if (!string.IsNullOrEmpty(Request["gid"]))
        {
            where += " and guoclassid=" + Int32.Parse(Request["gid"]);

            var gid = Request.Params["gid"];
            var teamType = new DAL.guoclass().GetModel(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "碩博企業翻譯社-" + teamType.ClassName;
                foreach (Control control in Header.Controls)
                {
                    if (control is HtmlMeta)
                    {
                        if ((control as HtmlMeta).Name.ToLower() == "description")
                        {
                            (control as HtmlMeta).Content = teamType.Description;
                        }
                        if ((control as HtmlMeta).Name.ToLower() == "keywords")
                        {
                            (control as HtmlMeta).Content = teamType.Keywords;
                        }
                    }
                }
            }
        }

        dtInfo = new BLL.guopic().GetList(where).Tables[0];
    }
}