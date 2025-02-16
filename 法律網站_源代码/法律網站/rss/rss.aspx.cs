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
        channel.Title = "后冠翻譯社-翻譯資訊";
        channel.Link = @"https://www.legal-translationservices.com//translation/";
        channel.Description = "后冠翻譯不斷精進，希望與您分享我們的成果，迷人的翻譯，讓更多人瞭解！";
        List<BCInfo.RssItem> items = new List<BCInfo.RssItem>();
        for (int i = 0; i < table.Rows.Count; i++)
        {
            BCInfo.RssItem item = new BCInfo.RssItem();
            item.Title = table.Rows[i]["ClassName"].ToString();
            item.Link = @"https://www.legal-translationservices.com//translation/Newlist-" + table.Rows[i]["classid"].ToString().Trim() + ".aspx";
            item.Description = table.Rows[i]["D_Description"].ToString();
            item.PubDate = table.Rows[i]["addtime"].ToString();
            item.Author = table.Rows[i]["username"].ToString();
            items.Add(item);
        }
        BCInfo.RssUtil.WriteRSS(channel, items);
    }
}
