using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_ContractUs : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "台北后冠韓文翻譯社(臺北、臺中、高雄)—線上諮詢立即瞭解相關訊息";
        Description = "后冠韓文翻譯社成立於臺灣臺北，目前設立的據點遍佈全球各地，包括香港、加拿大、澳門、新加坡、美國等地，從事全球翻譯服務，為全球客戶提供各類翻譯幫助。";
        Keywords = "韓文翻譯社,韓文翻譯社 臺北";
    }
}