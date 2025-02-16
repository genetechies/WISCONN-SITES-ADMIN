using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class translationnews_index : System.Web.UI.Page
{
    protected DataTable dtClass;
    protected DataTable dtInfo;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtClass = new DAL.NewsClass().GetList(" ParentID=1 ").Tables[0];

        string where = " D_Recycle=0 ";
        if (!string.IsNullOrEmpty(Request["cid"]))
        {
            where += " and D_ClassID= " + Int32.Parse(Request["cid"]);

            var gid = Request.Params["cid"];
            var teamType = new DAL.NewsClass().GetModel(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "翻譯資訊-" + teamType.ClassName + " -碩博翻譯社";
                foreach (Control control in Header.Controls)
                {
                    if (control is HtmlMeta)
                    {
                        if ((control as HtmlMeta).Name.ToLower() == "description")
                        {
                            (control as HtmlMeta).Content = teamType.Desciption;
                        }
                        if ((control as HtmlMeta).Name.ToLower() == "keywords")
                        {
                            (control as HtmlMeta).Content = teamType.Keyword;
                        }
                    }
                }

                ltArtListTitle.Text = teamType.ArtListTitle;
                ltArtListDescription.Text = teamType.ArtListDescription;
            }
        }

        dtInfo = new BLL.newsdata().GetListByClass(where, "D_ID desc").Tables[0];
    }
}