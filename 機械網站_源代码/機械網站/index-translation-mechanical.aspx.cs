using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index_translation_mechanical : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var b = CheckAgent();
        if (b)
        {
            Response.Redirect("/APP/Home.aspx");
            return;
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
}