using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class HTML_index : System.Web.UI.Page
{
    BLL.TransZone bll = new BLL.TransZone();
    public string ClassName = "后冠翻譯公司-翻譯領域";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Request["typeid"] != null)
            {
                Where = "D_Recycle=0 and D_ClassID=" + Request["typeid"].ToString().Trim();   //不在回收站 1,不在回收站
                Model.guoclass NewsClassmo = new Model.guoclass();
                NewsClassmo = new BLL.TransZone().GetModel(Convert.ToInt32(Request["typeid"].ToString().Trim()));
                ClassName = "后冠翻譯公司-翻譯領域-" + NewsClassmo.ClassName + "";
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
                //string strParentId = "";
                //DataSet dsleft = bll.GetList(" D_ClassID=3 ");
                //for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                //{
                //    strParentId += dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() + ",";
                //}
                //strParentId.Substring(0, strParentId.LastIndexOf(","));
                //Where = "D_Recycle=0 and parentid in (" + strParentId + ")";
                Where = "D_Recycle=0 ";
            }
            AspNetPager2.RecordCount = bll.CountByClassNew(Where);

            Bind();
        }
    }

         protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager2.PageSize;
        pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
        pds.DataSource = bll.GetListByClassNew(Where, "D_ID desc").Tables[0].DefaultView;
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
