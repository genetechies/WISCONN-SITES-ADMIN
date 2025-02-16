using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using SubWeb = DAL.SubWeb;

public partial class App_Team : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    BLL.TransTeam bll = new BLL.TransTeam();
    protected Model.guoclass NewsClassmo = null;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Title = "后冠韓文翻譯社—打造頂級韓文翻譯團隊";
            ddl_category.Items.Add(new ListItem("全部", "-1"));

            System.Data.DataSet ds = new BLL.TransTeam().GetAllTeamType();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Split('|')[0];
                string id = ds.Tables[0].Rows[i]["NC_Id"].ToString();
                var item = new ListItem(name, id);
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
        int typeid = -1;
        if (ddl_category.SelectedItem != null)
        {
            typeid = Int32.Parse(ddl_category.SelectedItem.Value);
        }
        Description = "后冠韓文翻譯社的韓文翻譯團隊有多年經驗，不僅保留了自己的特色，還不斷吸取行業內的經驗，以此完善自我。此外，后冠韓文翻譯團隊還有母語譯者的加入，更讓后冠如虎添翼，為翻譯服務的品質增添了保障。";
        Keywords = "韓文翻譯、韓文翻譯社";
        if (typeid != -1)
        {
            Where = " typeid=" + typeid;
            NewsClassmo = new BLL.TransTeam().GetModelTeamType(typeid);
            Title = "后冠韓文翻譯團隊-" + NewsClassmo.ClassName + "";
            Keywords = NewsClassmo.Keywords;
            Description = NewsClassmo.Description;
        }
        else
        {
            Where = "1=1";
            NewsClassmo = new Model.guoclass();
            Title = "后冠韓文翻譯社—打造頂級韓文翻譯團隊";
        }


        Pager.RecordCount = bll.Count(Where);
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = Pager.PageSize;
        pds.CurrentPageIndex = Pager.CurPage;
        pds.DataSource = bll.GetListByClass(Where, " sort desc", web).Tables[0].DefaultView;
        newrp.DataSource = pds;
        newrp.DataBind();
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

    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        Bind();
    }

}