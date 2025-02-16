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

public partial class transzone : System.Web.UI.Page
{
    public Model.newsdata moarticle = null;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["id"] != null)
            {
                BLL.TransZone bll = new BLL.TransZone();
                new BLL.TransZone().Update_clickNew(Convert.ToInt32(Request["id"]));
                moarticle = new BLL.TransZone().GetModelNew(Convert.ToInt32(Request["id"]));
                if (moarticle != null)
                {
                    HtmlMeta metaDesc = new HtmlMeta();
                    metaDesc.Name = "description";
                   
                    metaDesc.Content = moarticle.D_Description;
                    Page.Header.Controls.Add(metaDesc);


                    HtmlMeta metaKey = new HtmlMeta();
                    metaKey.Name = "keywords";
                    metaKey.Content = moarticle.D_Keyword;
                    Page.Header.Controls.Add(metaKey);

                    DataView dv = bll.GetListByClassNew("D_ID>" + Request.QueryString["id"], "D_ID").Tables[0].DefaultView;
                    if (dv.Count > 0)
                    {
                        ltlPreLink.Text = "<a href=\"transzone-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    }
                    else
                    {
                        ltlNextLink.Text = "無";
                    }
                    dv = bll.GetListByClassNew("D_ID<" + Request.QueryString["id"], "D_ID desc").Tables[0].DefaultView;
                    if (dv.Count > 0)
                    {
                        ltlNextLink.Text = "<a href=\"transzone-" + dv[0]["D_ID"].ToString() + ".aspx\" >" + dv[0]["D_Title"].ToString() + "</a>";
                    }
                    else
                    {
                        ltlPreLink.Text = "無";
                    }
                }
                else
                {
                    MyTool.alertback("參數錯誤");
                }
            }
            else
            {
                moarticle = new BLL.TransZone().GetModelNew(1);
            }

            
            
        }

    }

     
}
