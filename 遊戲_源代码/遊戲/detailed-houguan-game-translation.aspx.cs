using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class detailed_houguan_game_translation : System.Web.UI.Page
{
    BLL.newsdata bllnews = new BLL.newsdata();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                BindModel(id);
                BindSimilar(id);
                BindNext(id);
            }
            else
            {
                Response.Redirect("index-houguan-game-translation.aspx");
            }
            Bindlist();
        }
    }


    protected static string keywords = "";
    protected static string description = "";
    protected static string title = "";
    protected static string author = "";
    protected static string adddate = "";
    protected static string clickcount = "";
    protected static string contentinfo = "";
    private void BindModel(int id)
    {
        Model.newsdata model = bllnews.GetModel(id);
        title = model.D_Title.ToString();
        author = model.D_Editor.ToString();
        adddate = model.D_Time.ToShortDateString();
        clickcount = model.D_Count.ToString();
        contentinfo = model.D_Content.ToString();
        // 修正图片在母站后台
        contentinfo = contentinfo.Replace("/Content/ueditorUTF8/net/upload/", System.Configuration.ConfigurationManager.AppSettings["motherUrl"] + "/Content/ueditorUTF8/net/upload/");
        keywords = model.D_Keyword.ToString();
        description = model.D_Description.ToString();


        Model.NewsClass newsClass = new BLL.NewsClass().GetModel(model.D_ClassID);
        Title = "[" + newsClass.ClassName + "]" + model.D_Title + "-后冠翻譯公司";
    }


    protected static string NewsList = "";
    private void Bindlist()
    {
        DataSet ds = bllnews.GetList_top(12, "D_Recycle=0");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            string title = ds.Tables[0].Rows[i]["D_Title"].ToString().Length > 15 ? ds.Tables[0].Rows[i]["D_Title"].ToString().Substring(0, 15) : ds.Tables[0].Rows[i]["D_Title"].ToString();
            NewsList += "<li><a href=\"detailed-houguan-game-translation.aspx?id=" + ds.Tables[0].Rows[i]["D_ID"].ToString() + "\">" + title + "</a></li>";
        }
    }

    /// <summary>
    /// 绑定相关新闻
    /// </summary>
    protected static string SimilarNews = "";
    private void BindSimilar(int id)
    {
        Model.newsdata model = bllnews.GetModel(id);
        DataSet ds = bllnews.GetList_top(5, " D_ID!=" + id + " and D_Recycle=0 and D_ClassID=" + model.D_ClassID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                SimilarNews += "<a href=\"detailed-houguan-game-translation.aspx?id=" + ds.Tables[0].Rows[i]["D_ID"].ToString() + "\" >" + ds.Tables[0].Rows[i]["D_Title"].ToString() + "</a> <br />";
            }
        }

    }

    /// <summary>
    /// 绑定相关新闻
    /// </summary>
    protected static string NextNews, LastNews = "";
    private void BindNext(int id)
    {
        DataSet ds1 = bllnews.GetList_top(1, "D_Recycle=0 and D_ID<" + id);
        if (ds1.Tables[0].Rows.Count > 0)
        {
            NextNews = "<a href=\"detailed-houguan-game-translation.aspx?id=" + ds1.Tables[0].Rows[0]["D_ID"].ToString() + "\" >" + ds1.Tables[0].Rows[0]["D_Title"].ToString() + "</a>";
        }
        else
        {
            NextNews = "<a href=\"javascript:void(0)\" >没有上一篇了！</a>";
        }
        DataSet ds2 = bllnews.GetList_top(1, "D_Recycle=0 and D_ID>" + id);
        if (ds2.Tables[0].Rows.Count > 0)
        {
            LastNews = "<a href=\"detailed-houguan-game-translation.aspx?id=" + ds2.Tables[0].Rows[0]["D_ID"].ToString() + "\" >" + ds2.Tables[0].Rows[0]["D_Title"].ToString() + "</a>";
        }
        else
        {
            LastNews = "<a href=\"javascript:void(0)\" >没有下一篇了！</a>";
        }

    }
}