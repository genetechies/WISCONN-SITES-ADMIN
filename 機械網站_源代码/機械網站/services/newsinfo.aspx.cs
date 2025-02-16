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

public partial class newsinfo : System.Web.UI.Page
{
    public Model.newsdata moarticle = null;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Request["id"] != null)
            //{
            //    moarticle = new BLL.newsdata().GetModel(Convert.ToInt32(Request["id"]));
            //    if (moarticle != null)
            //    {
            //        HtmlMeta metaDesc = new HtmlMeta();
            //        metaDesc.Name = "description";
            //        metaDesc.Content = moarticle.D_Description;
            //        Page.Header.Controls.Add(metaDesc);


            //        HtmlMeta metaKey = new HtmlMeta();
            //        metaKey.Name = "keywords";
            //        metaKey.Content = moarticle.D_Keyword;
            //        Page.Header.Controls.Add(metaKey);

            //        new BLL.newsdata().Update_click(moarticle.D_ID);
            //    }
            //    else
            //    {
            //        MyTool.alertback("參數錯誤");
            //    }
            //}
            //else
            //{
            //    moarticle = new BLL.newsdata().GetModel(1);
            //}

            
            
        }

    }

     
}
