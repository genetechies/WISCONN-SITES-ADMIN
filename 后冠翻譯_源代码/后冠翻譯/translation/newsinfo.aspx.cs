using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Helper;
using BLL;

public partial class newsinfo : System.Web.UI.Page
{
    public Model.newsdata moarticle = null;
    public string ClassName = "翻譯資訊";
    

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
                    
                    HtmlMeta metaDesc = new HtmlMeta();
                    metaDesc.Name = "description";
                    metaDesc.Content = moarticle.D_Description;
                    Page.Header.Controls.Add(metaDesc);


                    HtmlMeta metaKey = new HtmlMeta();
                    metaKey.Name = "keywords";
                    metaKey.Content = moarticle.D_Keyword;
                    Page.Header.Controls.Add(metaKey);

                    DataView dv = bll.GetListByClass("D_ID>" + Request.QueryString["id"], "D_ID").Tables[0].DefaultView;
                    if (dv.Count > 0)
                    {
                        ltlPreLink.Text = "<a href=\"newsinfo-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    }
                    else
                    {
                        ltlNextLink.Text = "無";
                    }
                    dv = bll.GetListByClass("D_ID<" + Request.QueryString["id"], "D_ID desc").Tables[0].DefaultView;
                    if (dv.Count > 0)
                    {
                        ltlNextLink.Text = "<a href=\"newsinfo-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    }
                    else
                    {
                        ltlPreLink.Text = "無";
                    }

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
