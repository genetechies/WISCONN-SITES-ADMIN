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
 
        Title = "后冠韓文翻譯—用價格和實績做最好的推薦";
        Description = "后冠韓文翻譯憑藉優秀的翻譯品質和合理的翻譯價格，成功積累了一批又一批的舊客戶。我們以多年的客戶實績，以及超越行業的翻譯水準向廣大客戶展現了一個不一樣的韓文翻譯公司。后冠希望，能夠借此做受客戶推薦的韓文翻譯公司。";
        Keywords = "韓文翻譯 推薦、韓文翻譯 價格";
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