using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_News : System.Web.UI.Page
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
        DataSet ds_web = new BLL.SubWeb().GetAllList();
        if (ds_web.Tables.Count == 0) return;
        
        int swid = Convert.ToInt32(ds_web.Tables[0].Rows[0]["SWID"].ToString());
        Model.SubWeb web = new BLL.SubWeb().GetModel(swid);

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

        Title = "后冠翻譯社—醫藥翻譯、醫療器材翻譯的資料與訊息";
        Description = "醫學翻譯資訊是后冠在此領域不斷探求積累的智慧結晶，是深度交流後獲得的經驗和智慧。在此分享我們的成果，希望通過醫藥翻譯、醫療器材翻譯等相關資訊的交流，促進彼此的進步，讓大家在醫學翻譯領域均有所成長。";
        Keywords = "醫藥翻譯,醫療器材翻譯";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1" && NewsClassmo != null)
        {
            Title = "翻譯資訊-" + NewsClassmo.ClassName;
            Description = NewsClassmo.Description;
            Keywords = NewsClassmo.Keywords;
        }

        Pager.RecordCount = bll.Count(Where);
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = Pager.PageSize;
        pds.CurrentPageIndex = Pager.CurPage;
        pds.DataSource = bll.GetListByClass(Where, " D_ID desc", web).Tables[0].DefaultView;
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