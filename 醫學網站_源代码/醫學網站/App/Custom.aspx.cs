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
 
        Title = "后冠翻譯社—我們的客戶來自全世界，最頂尖的醫療器材翻譯、醫學翻譯公司！";
        Description = "經過多年的不懈努力，后冠醫藥翻譯社已經擁有忠實的客戶群，眾多醫學翻譯、醫療器材翻譯案例昭示了我們在此領域的努力，不斷有新客戶變成我們的老客戶，客戶的肯定，是我們不斷前進的動力！";
        Keywords = "醫療器材翻譯,醫藥翻譯";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
        {
            Model.guoclass guoclass = new Model.guoclass();
            guoclass = new BLL.guoclass().GetModel(Convert.ToInt32(ddl_category.SelectedItem.Value.Trim()));
            Title = "后冠醫療器材翻譯—" + guoclass.ClassName + "";
            Description = guoclass.Description;
            Keywords = guoclass.Keywords;
        }
    }
 
    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CurPage = 0;
    }
}