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

public partial class center010 : System.Web.UI.Page
{
    BLL.newsdata bll = new BLL.newsdata();
    public string ClassName = "后冠翻譯社-翻譯資訊";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["parentid"] != null)
            {
                Where = "D_Recycle=0 and D_ClassID=" + Request["parentid"].ToString().Trim();   //
                Model.NewsClass NewsClassmo = new Model.NewsClass();
                NewsClassmo =new BLL.NewsClass().GetModel(Convert.ToInt32(Request["parentid"].ToString().Trim()));
                ClassName = "后冠翻譯社-翻譯資訊-" + NewsClassmo.ClassName + "";
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
            AspNetPager2.RecordCount = bll.CountByClass(Where);

            Bind();
        }

    }

    protected void Bind()
    {
        //PagedDataSource pds = new PagedDataSource();
        //pds.AllowPaging = true;
        //pds.PageSize = AspNetPager2.PageSize;
        //pds.CurrentPageIndex = AspNetPager2.CurrentPageIndex - 1;
        //pds.DataSource = bll.GetListByClass(Where, "D_ID desc").Tables[0].DefaultView;
        //newrp.DataSource = pds;
        //newrp.DataBind();


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
