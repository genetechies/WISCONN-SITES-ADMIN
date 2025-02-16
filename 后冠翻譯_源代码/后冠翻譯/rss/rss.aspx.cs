using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;

public partial class rss_rss : System.Web.UI.Page
{
    BLL.PageClass bll = new BLL.PageClass();
    BLL.newsdata news_bll = new BLL.newsdata();
    BLL.TransZone transzone_bll = new BLL.TransZone();
    protected void Page_Load(object sender, EventArgs e)
    {
        BindRss();
    }

    public void BindRss()
    {
        DataTable dt = bll.GetList(" parentid=3").Tables[0];
        string strWhere = "";
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strWhere += dt.Rows[i]["classid"].ToString() + ",";
            }
        }
        if (strWhere != "")
            strWhere = strWhere.Substring(0, strWhere.LastIndexOf(","));
        string Where = "P_State=1 and parentid in ( " + strWhere + " )";
        DataTable table = bll.GetListByClass(Where, "classid desc").Tables[0];
        BCInfo.RssChannel channel = new BCInfo.RssChannel();
        channel.Title = "后冠翻譯公司-翻譯資訊";
        channel.Link = @"https://www.houguan-translation-services.com/translation/newlist.aspx";
        channel.Description = "后冠翻譯不斷精進，希望與您分享我們的成果，迷人的翻譯，讓更多人瞭解！";
        List<BCInfo.RssItem> items = new List<BCInfo.RssItem>();

        DataTable t_table = transzone_bll.GetListByClassNew("", "D_ID desc").Tables[0];
        DataTable n_table = news_bll.GetListByClass("", "D_ID desc").Tables[0];
        for (int i = 0; i < t_table.Rows.Count; i++)
        {
            BCInfo.RssItem item = new BCInfo.RssItem();
            item.Title = t_table.Rows[i]["d_title"].ToString();
            item.Link = @"https://www.houguan-translation-services.com/translation/transzone-" + t_table.Rows[i]["d_id"].ToString().Trim() + ".aspx";
            item.Description = t_table.Rows[i]["D_Description"].ToString();
            item.PubDate = t_table.Rows[i]["d_time"].ToString();
            item.Author = t_table.Rows[i]["d_editor"].ToString();
            items.Add(item);
        }
        for (int i = 0; i < n_table.Rows.Count; i++)
        {
            BCInfo.RssItem item = new BCInfo.RssItem();
            item.Title = n_table.Rows[i]["d_title"].ToString();
            item.Link = @"https://www.houguan-translation-services.com/translation/newsinfo-" + n_table.Rows[i]["d_id"].ToString().Trim() + ".aspx";
            item.Description = n_table.Rows[i]["D_Description"].ToString();
            item.PubDate = n_table.Rows[i]["d_time"].ToString();
            item.Author = n_table.Rows[i]["d_editor"].ToString();
            items.Add(item);
        }
        BCInfo.RssUtil.WriteRSS(channel, items);
    }
}

