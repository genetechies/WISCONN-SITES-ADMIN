using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class japanese_houguan_translation_informations : System.Web.UI.Page
{
    BLL.newsdata newbll = new BLL.newsdata();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["cid"] != null)
            {
                Where = "D_Recycle=0 and D_ClassID=" + Request["cid"].ToString().Trim();
            }
            else
            {
                Where = "D_Recycle=0 ";
            }
            AspNetPager2.RecordCount = newbll.CountByClass(Where);
            Bind();
        }

        if (Request.Params.AllKeys.Contains("cid"))
        {
            var gid = Request.Params["cid"];
            var classType = new DAL.NewsClass().GetModel(Int32.Parse(gid));
            if (classType != null)
            {
                Title = "翻譯資訊-" + classType.ClassName + " -后冠日文翻譯公司";
                foreach (Control control in Header.Controls)
                {
                    if (control is HtmlMeta)
                    {
                        if ((control as HtmlMeta).Name.ToLower() == "description")
                        {
                            (control as HtmlMeta).Content = classType.Description;
                        }
                        if ((control as HtmlMeta).Name.ToLower() == "keywords")
                        {
                            (control as HtmlMeta).Content = classType.Keywords;
                        }
                    }
                }

                ltArtListTitle.Text = classType.ArtListTitle;
                ltArtListDescription.Text = classType.ArtListDescription;
            }
        }
    }

    protected string RightList = "";
    private void BindNewList()
    {

        DataSet ds = newbll.GetList_top(10, "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string content = ds.Tables[0].Rows[i]["D_Content"].ToString().Length > 430 ? ds.Tables[0].Rows[i]["D_Content"].ToString().Substring(0, 430) + "..." : ds.Tables[0].Rows[i]["D_Content"].ToString();
                RightList += "<div class=\"list-1\"><div class=\"list-title\"><span class=\"left\"><a href=href=\"houguan-translation-gd-Detailed-information.aspx?id=" + ds.Tables[0].Rows[i]["D_ID"].ToString() + "\" style=\"color:#586f92;\">" + ds.Tables[0].Rows[i]["D_Title"].ToString() + "</a></span><span class=\"right\">" + Convert.ToDateTime(ds.Tables[0].Rows[i]["D_Time"]).ToShortDateString() + "</span></div><div class=\"con\"> " + content + "</div></div>";
            }
        }

    }


    protected void AspNetPager2_PageChanged(object sender, EventArgs e)
    {
        Bind();
    }


    protected void Bind()
    {
        DataSet ds_web = new BLL.SubWeb().GetAllList();
        if (ds_web.Tables.Count > 0)
        {
            int swid = Convert.ToInt32(ds_web.Tables[0].Rows[0]["SWID"].ToString());
            Model.SubWeb web = new BLL.SubWeb().GetModel(swid);

            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager2.PageSize;
            pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
            pds.DataSource = newbll.GetListByClass(Where, "D_ID desc", web).Tables[0].DefaultView;
            rep_list.DataSource = pds;
            rep_list.DataBind();
        }

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