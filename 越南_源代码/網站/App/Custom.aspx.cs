using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_Custom : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }
    public int CurPage { get; set; }
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddl_category.Items.Add(new ListItem("All", "-1"));
            System.Data.DataSet ds = new BLL.guoclass().GetAll();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Split('|')[0];
                string id = ds.Tables[0].Rows[i]["NC_Id"].ToString();
                var item = new ListItem(name, id);
                ddl_category.Items.Add(item);
            }
 
            if (Request["page"] != null)
                CurPage = Int32.Parse(Request["page"]);
            
        }
 
        Title = "后冠日語翻譯（高雄、台南）—以實績見證實力";
        Description = "高雄和台南是台灣重要的中心城市，人流量大，日語翻譯的需求也極大。而后冠設立在此的日語翻譯社不斷壯大，一路走來以絕佳的實績讓廣大客戶見證后冠的翻譯實力";
        Keywords = "日語翻譯 高雄、日語翻譯 台南";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
        {
            Model.guoclass guoclass = new Model.guoclass();
            guoclass = new BLL.guoclass().GetModel(Convert.ToInt32(ddl_category.SelectedItem.Value.Trim()));
            Title = "后冠韓文翻譯—" + guoclass.ClassName + "";
            Description = guoclass.Description;
            Keywords = guoclass.Keywords;
        }
    }
 
    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CurPage = 0;
    }
}