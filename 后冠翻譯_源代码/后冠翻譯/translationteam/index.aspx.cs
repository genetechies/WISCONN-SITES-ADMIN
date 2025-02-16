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

public partial class translationteam_index : System.Web.UI.Page
{
    BLL.TransTeam bll = new BLL.TransTeam();
    public string ClassName = "后冠翻譯公司-擁有英語,英文校稿,日語,韓語等九大國際翻譯語言團隊";
    protected Model.guoclass NewsClassmo = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["typeid"] != null)
            {
                Where = " typeid=" + Request["typeid"].ToString().Trim();   //不在回收站 1,不在回收站
                 NewsClassmo = new Model.guoclass(); 
                NewsClassmo = new BLL.TransTeam().GetModelTeamType(Convert.ToInt32(Request["typeid"].ToString().Trim()));
                ClassName = "后冠翻譯公司-" + NewsClassmo.ClassName + "";
                
                foreach (Control headerControl in Page.Header.Controls)
                {
                    if (headerControl is HtmlMeta)
                    {
                        var metaKey = (HtmlMeta) headerControl;
                        if (metaKey.Name == "keywords")
                        {
                            metaKey.Content = NewsClassmo.Keywords;
                        }
                        else if (metaKey.Name == "description")
                        {
                            metaKey.Content = NewsClassmo.Description;
                        }
                    }
                }
            }
            else
            {
                Where = " 1=1";
            }
            AspNetPager2.RecordCount = bll.Count(Where);
            Bind();
        }

    }

    protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager2.PageSize;
        pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
        pds.DataSource = bll.GetListByClass(Where, " sort desc").Tables[0].DefaultView;
        newrp.DataSource = pds;
        newrp.DataBind();


    }

    protected void AspNetPager2_PageChanged(object sender, EventArgs e)
    {
        Bind();
    }

    public string Where
    {
        get
        {
            if (ViewState["Where"] == null)
                ViewState["Where"] = "";
            return (string)ViewState["Where"];
        }
        set
        {
            ViewState["Where"] = value;
        }
    }
}
