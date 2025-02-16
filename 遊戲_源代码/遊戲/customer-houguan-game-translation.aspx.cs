using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class customer_houguan_game_translation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠翻譯公司-各項翻譯服務項目";
        if (Request.Params.AllKeys.Contains("gid"))
        {
            var gid = Request.Params["gid"];
            var teamType = new DAL.guoclass().GetModel(Int32.Parse(gid));
            if (teamType != null)
            {
                Title = "后冠翻譯公司-" + teamType.ClassName + "-各項翻譯服務項目";
                foreach (Control control in Header.Controls)
                {
                    if (control is HtmlMeta)
                    {
                        if ((control as HtmlMeta).Name.ToLower() == "description")
                        {
                            (control as HtmlMeta).Content = teamType.Description;
                        }
                        if ((control as HtmlMeta).Name.ToLower() == "keywords")
                        {
                            (control as HtmlMeta).Content = teamType.Keywords;
                        }
                    }
                }
            }
        }
    }
}