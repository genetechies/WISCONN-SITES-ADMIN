using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_Service : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠翻譯社—英文醫學翻譯、日文醫學翻譯的服務專案";
        Description = "后冠英文、日文醫學翻譯社以優秀的翻譯水準、嚴謹的品質控管、順暢的翻譯流程、專業的審核標準為您提供最完善的英文、日文醫學翻譯服務。客戶的滿意是我們一直不變的追求，希望您能夠給予我們一個機會，讓我們提供給您全新的醫學翻譯體驗！";
        Keywords = "醫學翻譯 英文,醫學翻譯 日文";
    }
}