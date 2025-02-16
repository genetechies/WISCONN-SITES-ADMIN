using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Helper;

public partial class App_NewsInfo : System.Web.UI.Page
{   public string Keywords { get; set; }
    public string Description { get; set; }

    public Model.newsdata moarticle = null;
    public string ClassName = "后冠翻譯—最詳盡的遊戲資訊";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["id"] != null)
            {
                BLL.newsdata bll = new newsdata();

                moarticle = new BLL.newsdata().GetModel(Convert.ToInt32(Request["id"]));
                if (moarticle != null)
                {
                    Model.NewsClass newsClassmo = new BLL.NewsClass().GetModel(moarticle.D_ClassID);
                    if (newsClassmo != null)
                    {
                        ClassName = newsClassmo.ClassName;
                    }

                    Title = "["+ClassName+"]"+moarticle.D_Title+"-后冠翻譯公司";
                    Keywords = moarticle.D_Keyword;
                    Description = moarticle.D_Description;

                    //DataView dv = bll.GetListByClass("D_ID>" + Request.QueryString["id"], "D_ID").Tables[0].DefaultView;
                    //if (dv.Count > 0)
                    //{
                    //    ltlPreLink.Text = "<a href=\"newsinfo-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    //}
                    //else
                    //{
                    //    ltlNextLink.Text = "無";
                    //}
                    //dv = bll.GetListByClass("D_ID<" + Request.QueryString["id"], "D_ID desc").Tables[0].DefaultView;
                    //if (dv.Count > 0)
                    //{
                    //    ltlNextLink.Text = "<a href=\"newsinfo-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    //}
                    //else
                    //{
                    //    ltlPreLink.Text = "無";
                    //}

                    new BLL.newsdata().Update_click(moarticle.D_ID);
                }
                else
                {
                    MyTool.alertback("參數錯誤");
                }
            }
            else
            {
                moarticle = new BLL.newsdata().GetModel(1);
            }



        }

    }
}