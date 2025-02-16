using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class medical_translation_information_newsinfo : System.Web.UI.Page
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
        Title = "[" + newsClass.ClassName + "]" + model.D_Title + "-后冠醫學翻譯公司";
    }


    protected static string NewsList = "";
    private void Bindlist()
    {
        DataSet ds = bllnews.GetList_top(12, "D_Recycle=0");
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            string title = ds.Tables[0].Rows[i]["D_Title"].ToString().Length > 15 ? ds.Tables[0].Rows[i]["D_Title"].ToString().Substring(0, 15) : ds.Tables[0].Rows[i]["D_Title"].ToString();
            NewsList += "<li><a href=\"houguan-translation-detail.aspx?id=" + ds.Tables[0].Rows[i]["D_ID"].ToString() + "\">" + title + "</a></li>";
        }
    }
}