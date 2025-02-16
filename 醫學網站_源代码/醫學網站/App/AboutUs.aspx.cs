using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_AboutUs : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠翻譯社—為您提供最佳的醫藥翻譯、醫療器材翻譯服務！";
        Description = "后冠翻譯社從事醫藥翻譯多年，致力於為客戶提供高品質的醫藥、醫療器材翻譯服務。我們擁有專業的醫學翻譯能力，以及熱情的服務態度，對翻譯負責是后冠堅持不變的信念，請您放心地將文件交予我們，我們將提供給您最滿意的翻譯！";
        Keywords = "醫療器材翻譯,醫藥翻譯";
    }
}