using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HTML_index : System.Web.UI.Page
{
    BLL.guoclass bll = new BLL.guoclass();
    public string ClassName = "后冠翻譯公司-各項翻譯服務項目";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Request["guoclassid"] != null)
            {
                Model.guoclass guoclass = new Model.guoclass();
                guoclass = bll.GetModel(Convert.ToInt32(Request["guoclassid"].ToString().Trim()));
                ClassName = "后冠翻譯公司-" + guoclass.ClassName + "-各項翻譯服務項目";
            }
        }
    }
}
