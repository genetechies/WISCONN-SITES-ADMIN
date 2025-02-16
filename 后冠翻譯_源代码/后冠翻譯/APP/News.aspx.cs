using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class APP_News : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    BLL.newsdata bll = new BLL.newsdata();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            System.Data.DataSet ds = new DAL.NewsClass().GetList(" ParentID=1 ");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i]["ClassName"].ToString().Split('|')[0];
                string id = ds.Tables[0].Rows[i]["ClassID"].ToString();
                var item = new ListItem(name, id);
                if (i == 0) item.Selected = true;
                ddl_category.Items.Add(item);
            }
        }

        Pager.PageChanged += (o, args) => { Bind(); };
        Bind();
    }

    protected void Bind()
    {
        Where = "D_Recycle=0 ";
        int parentID = -1;
        if (ddl_category.SelectedItem != null)
        {
            parentID = Int32.Parse(ddl_category.SelectedItem.Value);
        }

        if (parentID != -1)
        {
            Where += "and D_ClassID=" + parentID;   //不在回收站 1,不在回收站
        }
        Model.NewsClass NewsClassmo = new Model.NewsClass();
        NewsClassmo = new BLL.NewsClass().GetModel(parentID);

        Title = "后冠翻譯公司-翻譯資訊";
        Description = "后冠翻譯公司提供30多種的各國語言翻譯包含：中、英、日、韓、法、德、義、俄、越南、泰國、西班牙、葡萄牙、阿拉伯等語系及多元化的服務項目，包括筆譯、口譯、網頁翻譯、影視翻譯、公證文書、打字排版、聽打逐字稿、錄音配音、網站多語化、英文校稿等相關翻譯技術。";
        Keywords = "英文 校稿,翻譯公司";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1" && NewsClassmo != null)
        {
            Title = "翻譯資訊-" + NewsClassmo.ClassName;
            Description = NewsClassmo.Desciption;
            Keywords = NewsClassmo.Keyword;
        }

        Pager.RecordCount = bll.Count(Where);
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = Pager.PageSize;
        pds.CurrentPageIndex = Pager.CurPage;
        pds.DataSource = bll.GetListByClass(Where, " D_ID desc").Tables[0].DefaultView;
        newrp.DataSource = pds;
        newrp.DataBind();
    }

    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
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