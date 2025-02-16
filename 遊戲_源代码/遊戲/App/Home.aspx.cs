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
        Title = "后冠翻譯公司—給您最好的遊戲翻譯";
        Description = "隨著網路的發展，越來越多人喜歡上網路遊戲，讓不同地域的人都能夠接觸、喜歡你的遊戲，就是遊戲翻譯的最終目的。后冠遊戲翻譯公司提供您最高的遊戲翻譯品質，讓您的遊戲吸引更多玩家。";
        Keywords = "遊戲翻譯,遊戲翻譯公司";
    }
}