using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    public Model.sysconfig mosys = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        mosys = new BLL.sysconfig().GetModel(1);

        Title = "碩博翻譯社 提供英文,日文,韓文,論文翻譯服務";
        foreach (Control control in Header.Controls)
        {
            if (control is HtmlMeta)
            {
                if ((control as HtmlMeta).Name.ToLower() == "description")
                {
                    (control as HtmlMeta).Content =mosys.sys_description;
                }
                if ((control as HtmlMeta).Name.ToLower() == "keywords")
                {
                    (control as HtmlMeta).Content = mosys.searchkey;
                }
            }
        }

        //BLL.TransTeam bll = new BLL.TransTeam();
        //DataView dv = bll.GetListByClass("1=1", "sort desc").Tables[0].DefaultView;
        //rpt_list.DataSource = dv;
        //rpt_list.DataBind();
        //this.Repeater1.DataSource = dv;
        //this.Repeater1.DataBind();


        //BLL.guopic picbll = new BLL.guopic();
        //DataView dv2 = picbll.GetListByClass("1=1", "id desc").Tables[0].DefaultView;
        //Repeater2.DataSource = dv2;
        //Repeater2.DataBind();

        //Repeater3.DataSource = dv2;
        //Repeater3.DataBind();
    }
}