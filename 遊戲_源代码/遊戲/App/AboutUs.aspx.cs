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
        Title = "后冠翻譯公司—遊戲翻譯創造高科技時代";
        Description = "后冠翻譯公司是一個以人為本的，非常人性化的翻譯公司。我們有著優秀的遊戲翻譯人員，這些遊戲翻譯人員在這裡才華得到施展，夢想得以實現。這是翻翻譯師的家園，也是客戶的家園！";
        Keywords = "遊戲翻譯,遊戲翻譯公司";
    }
}