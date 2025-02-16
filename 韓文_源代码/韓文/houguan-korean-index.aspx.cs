using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class houguan_korean_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var b = CheckAgent();
        if (b)
        {
            Response.Redirect("/APP/Home.aspx");
            return;
        }

        if (!IsPostBack)
        {
            BindTeam();
            BindNews();
            BindGuos();
        }
    }

    private void BindTeam()
    {
        BLL.TransTeam web = new BLL.TransTeam();
        DataView dv = web.GetList("1=1").Tables[0].DefaultView;
        rep_team.DataSource = dv;
        rep_team.DataBind();
    }


    private void BindNews()
    {
        BLL.newsdata news = new BLL.newsdata();
        DataView dv = news.GetList_top(5, "D_Recycle=0").Tables[0].DefaultView;
        rep_list.DataSource = dv;
        rep_list.DataBind();
    }

    private void BindGuos()
    {
        BLL.guopic guos = new BLL.guopic();
        DataView dv = guos.GetList("").Tables[0].DefaultView;
        rep_kh.DataSource = dv;
        rep_kh.DataBind();
    }

    public static bool CheckAgent()
    {
        bool flag = false;
        string agent = HttpContext.Current.Request.UserAgent;
        string[] keywords = { "Android", "iPhone", "iPod", "iPad", "Windows Phone", "MQQBrowser" };
        //排除Window 桌面系统 和 苹果桌面系统
        if (!agent.Contains("Windows NT") && !agent.Contains("Macintosh"))
        {
            foreach (string item in keywords)
            {
                if (agent.Contains(item))
                {
                    flag = true;
                    break;
                }
            }
        }
        return flag;
    }
}