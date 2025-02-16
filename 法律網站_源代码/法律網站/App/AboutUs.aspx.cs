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
        Title = "后冠法律翻譯社提供您最專業的合約翻譯服務！";
        Description = "后冠法律翻譯社發跡於台北，進入法律翻譯領域多年，擁有成熟的法律翻譯技術與忠實的客戶群。我們的團隊極具專業與熱情，以專業的語言能力與豐富的法律知識為您的法律文件保駕護航，請您放心的將文件交予我們，對翻譯負責是后冠堅持不變的信念！";
        Keywords = "法律翻譯,法律翻譯社";
    }
}