using System;
using System.Data;

public partial class houguan_Thailand_informations_detail : System.Web.UI.Page
{
    protected DataTable dtClass;
    private BLL.newsdata bllnews = new BLL.newsdata();
    protected string Title = "";
    protected Model.newsdata model = new Model.newsdata();
    protected Model.newsdata pre = new Model.newsdata();
    protected Model.newsdata next = new Model.newsdata();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            dtClass = new DAL.NewsClass().GetList(" ParentID=1 ").Tables[0];
            BindModel(id);
            BindNext(id);
        }
        else
        {
            Response.Redirect("houguan-Thailand-index.aspx");
        }
    }

    private void BindModel(int id)
    {
        model = bllnews.GetModel(id);
        model.D_Content = model.D_Content.Replace("/Content/ueditorUTF8/net/upload/", System.Configuration.ConfigurationManager.AppSettings["motherUrl"] + "/Content/ueditorUTF8/net/upload/");

        Model.NewsClass newsClass = new BLL.NewsClass().GetModel(model.D_ClassID);
        Title = "[" + newsClass.ClassName + "]" + model.D_Title + "-后冠軟體翻譯公司";
    }

    private void BindNext(int id)
    {
        DataSet ds1 = bllnews.GetList_top(1, "D_Recycle=0 and D_ID<" + id);
        if (ds1.Tables[0].Rows.Count > 0)
        {
            pre = new Model.newsdata();
            pre.D_ID = Convert.ToInt32(ds1.Tables[0].Rows[0]["D_ID"]);
            pre.D_Title = Convert.ToString(ds1.Tables[0].Rows[0]["D_Title"]);
        }
        DataSet ds2 = bllnews.GetList_top(1, "D_Recycle=0 and D_ID>" + id);
        if (ds2.Tables[0].Rows.Count > 0)
        {
            next = new Model.newsdata();
            next.D_ID = Convert.ToInt32(ds2.Tables[0].Rows[0]["D_ID"]);
            next.D_Title = Convert.ToString(ds2.Tables[0].Rows[0]["D_Title"]);
        }

    }
}