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
 
        Title = "我們的客戶來自全世界─專業合約翻譯社提供各類翻譯範例";
        Description = "通過多年的不懈努力，后冠法律翻譯社已經擁有忠實的客戶群，眾多合約翻譯範例昭示我們是優秀的合約翻譯社之一，不斷有新客戶變成我們的老客戶，您的肯定，是我們不斷前行的動力！";
        Keywords = "合約翻譯 範例,合約翻譯社";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
        {
            Model.guoclass guoclass = new Model.guoclass();
            guoclass = new BLL.guoclass().GetModel(Convert.ToInt32(ddl_category.SelectedItem.Value.Trim()));
            Title = "后冠法律翻譯社 - " + guoclass.ClassName + "";
            Description = guoclass.Description;
            Keywords = guoclass.Keywords;
        }
    }
 
    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CurPage = 0;
    }
}