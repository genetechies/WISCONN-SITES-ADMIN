using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class japanese_houguan_translation_team : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["gid"] != null)
            {
                BindEnglishTeam("typeid=" + Request.QueryString["gid"]);
            }
            else
            {
                BindEnglishTeam("");
            }

        }

        if (Request.Params.AllKeys.Contains("gid"))
        {
            var gid = Request.Params["gid"];
            var teamType = new DAL.TransTeam().GetModelTeamType(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "后冠日文翻譯公司-" + teamType.ClassName;
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
    }

    private void BindEnglishTeam(string where)
    {
        BLL.TransTeam web = new BLL.TransTeam();
        DataView dv = web.GetList(where).Tables[0].DefaultView;
        rep_english.DataSource = dv;
        rep_english.DataBind();
    }
}