using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Houguan_IT_translation_team : System.Web.UI.Page
{
    protected DataTable dtClass;
    protected DataTable dtInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtClass = new DAL.TransTeam().GetAllTeamType().Tables[0];

        string where = " 1=1 ";
        if (!string.IsNullOrEmpty(Request["gid"]))
        {
            where += " and typeid=" + Int32.Parse(Request["gid"]);

            var gid = Request.Params["gid"];
            var teamType = new DAL.TransTeam().GetModelTeamType(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "后冠軟體翻譯公司-" + teamType.ClassName;
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

        dtInfo = new BLL.TransTeam().GetList(where).Tables[0];
    }
}