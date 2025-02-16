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
 
        Title = "后冠翻譯社—遊戲客戶的評價";
        Description = "遊戲的玩家是我們的第二客戶，也是非常重要的服務對象之一。讓他們滿足是我們最大的榮幸，而他們的評價更是鞭策我們的動力。這些寶貴的意見都會成為我們不斷提高翻譯品質的動力和保障。";
        Keywords = "遊戲翻譯";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
        {
            Model.guoclass guoclass = new Model.guoclass();
            guoclass = new BLL.guoclass().GetModel(Convert.ToInt32(ddl_category.SelectedItem.Value.Trim()));
            Title = "后冠遊戲翻譯—" + guoclass.ClassName + "";
            Description = guoclass.Description;
            Keywords = guoclass.Keywords;
        }
    }
 
    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CurPage = 0;
    }
}