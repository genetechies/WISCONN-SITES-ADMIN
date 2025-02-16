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
        Title = "后冠英文科技翻譯社—優質的英文科技翻譯公司！";
        Description = "專業的英文科技翻譯團隊，豐富的翻譯經驗，為您提供品質保證，帶給您全新的翻譯體驗。后冠的翻譯團隊擁有專業的語言能力與科技相關知識，技術成熟，口碑良好，請放心的將文件交予我們，優秀的英文科技翻譯公司提供您高品質的機械翻譯！";
        Keywords = "英文科技翻譯,科技翻譯公司";
    }
}