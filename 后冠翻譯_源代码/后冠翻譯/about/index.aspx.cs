using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Helper;

public partial class about_index : System.Web.UI.Page
{
    public Model.PageClass moarticle = null;

    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
         {
             if (Request["id"] != null)
             {
                 moarticle =new BLL.PageClass().GetModel(Convert.ToInt32(Request["id"]));
                 if (moarticle == null)
                 {
                     MyTool.alertback("參數錯誤");
                 }
             }
             else
             {
                 moarticle = new BLL.PageClass().GetModel(6);
             }
             
         }
    }


}
