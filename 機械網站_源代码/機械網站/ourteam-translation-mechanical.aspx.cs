using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class ourteam_translation_mechanical : System.Web.UI.Page
{
    BLL.TransTeam web = new BLL.TransTeam();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["gid"] != null)
            {
                Where = "typeid=" + Request.QueryString["gid"];               
            }
            AspNetPager2.RecordCount = web.Count(Where);
            Bind();
        }



        if (Request.Params.AllKeys.Contains("gid"))
        {
            var gid = Request.Params["gid"];
            var teamType = new DAL.TransTeam().GetModelTeamType(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "后冠機械翻譯公司-" + teamType.ClassName;
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

    protected void AspNetPager2_PageChanged(object sender, EventArgs e)
    {
        Bind();
    }


    public string Where
    {
        get
        {
            if (ViewState["Where"] == null)
                ViewState["Where"] = "";
            return (string)ViewState["Where"];
        }
        set
        {
            ViewState["Where"] = value;
        }
    }

    private void Bind()
    {
        

        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager2.PageSize;
        pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
        pds.DataSource = web.GetList(Where).Tables[0].DefaultView;
        rep_english.DataSource = pds;
        rep_english.DataBind();
    }
}