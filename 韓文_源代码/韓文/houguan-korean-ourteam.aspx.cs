using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class houguan_korean_ourteam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEnglishTeam();
        }

        if (Request.Params.AllKeys.Contains("cid"))
        {
            var gid = Request.Params["cid"];
            var teamType = new DAL.TransTeam().GetModelTeamType(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "后冠韓文翻譯社 - " + teamType.ClassName;
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


    private void BindEnglishTeam()
    {
        BLL.TransTeam web = new BLL.TransTeam();
        DataView dv = web.GetList("1=1").Tables[0].DefaultView;
        rep_list.DataSource = dv;
        rep_list.DataBind();
    }
}