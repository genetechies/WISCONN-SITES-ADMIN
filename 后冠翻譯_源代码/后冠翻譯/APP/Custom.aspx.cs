using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class APP_Custom : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }
    public int CurPage { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddl_category.Items.Add(new ListItem("全部", "-1"));
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

        Title = "后冠翻譯公司-各項翻譯服務項目";
        Description = "后冠翻譯公司提供30多種的各國語言翻譯包含：中文、英文、日文、韓文、法文、德文、義文、俄文、越南、泰國、西班牙、葡萄牙、阿拉伯等語系及多元化的服務項目，包括筆譯、口譯、網頁翻譯、影視翻譯、公證文書、打字排版、聽打逐字稿、錄音配音、網站多語化等相關翻譯技術。";
        Keywords = "翻譯公司 英文,翻譯公司 日文";
        if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
        {
            Model.guoclass guoclass = new Model.guoclass();
            guoclass = new BLL.guoclass().GetModel(Convert.ToInt32(ddl_category.SelectedItem.Value.Trim()));
            Title = "后冠翻譯公司-" + guoclass.ClassName + "-各項翻譯服務項目";
            Description = guoclass.Description;
            Keywords = guoclass.Keywords;
        }
    }

    protected void ddl_category_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CurPage = 0;
    }
}