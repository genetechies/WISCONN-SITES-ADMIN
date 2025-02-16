using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class houguan_Thailand_informations : System.Web.UI.Page
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
                Title = "翻譯資訊-" + teamType.ClassName + " -后冠軟體翻譯公司";
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

                ltArtListTitle.Text = teamType.ArtListTitle;
                ltArtListDescription.Text = teamType.ArtListDescription;
            }
        }

        DataSet ds_web = new BLL.SubWeb().GetAllList();
        if (ds_web.Tables.Count > 0)
        {
            int swid = Convert.ToInt32(ds_web.Tables[0].Rows[0]["SWID"].ToString());
            Model.SubWeb web = new BLL.SubWeb().GetModel(swid);
            dtInfo = new BLL.newsdata().GetListByClass(where, "D_ID desc", web).Tables[0];
        }
    }
}