using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class index_houguan_game_translation : System.Web.UI.Page
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
        }
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

    private void BindTeam() {
        BLL.TransTeam web = new BLL.TransTeam();
        DataView dv = web.GetList("1=1").Tables[0].DefaultView;
        rpt_list.DataSource = dv;
        rpt_list.DataBind();        
    }

    private void BindNews()
    {
        BLL.newsdata newdll = new BLL.newsdata();
        DataView dv = newdll.GetList_top(3,"").Tables[0].DefaultView;
        
        rpt_nlist.DataSource = dv;
        rpt_nlist.DataBind();
    }
}