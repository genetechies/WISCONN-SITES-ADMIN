using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.Office.Interop.Excel;

public partial class translation_law_team : System.Web.UI.Page
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
                Title = "后冠法律翻譯社-" + teamType.ClassName;
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

    public DataView DSTable = null;

    protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager2.PageSize;
        pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
        DSTable = web.GetList(Where).Tables[0].DefaultView;
        pds.DataSource = DSTable;
        //rep_Other.DataSource = pds;
        //rep_Other.DataBind();
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
}