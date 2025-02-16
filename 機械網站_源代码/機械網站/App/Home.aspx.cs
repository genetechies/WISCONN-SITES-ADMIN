using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_Home : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠機械翻譯公司—最專業的機械翻譯服務！";
        Description = "機械製造業屬於綜合性基礎產業，與眾多行業有著較高關聯度，因此對翻譯師的綜合能力有很高的要求，后冠機械翻譯公司跨足世界各地，由資深翻譯組成的翻譯團隊有著豐富的翻譯經驗，有效保障翻譯品質。";
        Keywords = "機械翻譯,機械翻譯公司";
    }
}