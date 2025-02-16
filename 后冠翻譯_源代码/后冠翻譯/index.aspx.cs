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

public partial class index : System.Web.UI.Page
{
    public Model.sysconfig mosys = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        var b = CheckAgent();
        if (b)
        {
            Response.Redirect("/APP/Home.aspx");
            return;
        }

        mosys = new BLL.sysconfig().GetModel(1);

        HtmlMeta metaDesc = new HtmlMeta();
        metaDesc.Name = "description";
        metaDesc.Content = mosys.sys_description;
        Page.Header.Controls.Add(metaDesc);

        HtmlMeta metaKey = new HtmlMeta();
        metaKey.Name = "keywords";
        metaKey.Content = mosys.searchkey;
        Page.Header.Controls.Add(metaKey);

        BLL.TransTeam bll = new BLL.TransTeam();
        DataView dv = bll.GetListByClass("1=1", "sort desc").Tables[0].DefaultView;
        rpt_list.DataSource = dv;
        rpt_list.DataBind();
        this.Repeater1.DataSource = dv;
        this.Repeater1.DataBind();


        BLL.guopic picbll = new BLL.guopic();
        DataView dv2 = picbll.GetListByClass("1=1", "id desc").Tables[0].DefaultView;
        Repeater2.DataSource = dv2;
        Repeater2.DataBind();

        Repeater3.DataSource = dv2;
        Repeater3.DataBind();
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
