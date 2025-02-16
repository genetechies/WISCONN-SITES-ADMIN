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
        Title = "后冠遊戲翻譯公司—遊戲翻譯的優惠價格";
        Description = "在遊戲翻譯服務中，因為遊戲種類和面向的群體不一樣，所以需要的翻譯價錢往往是不一樣的。后冠遊戲翻譯公司多樣化的服務能夠滿足您各種需求！";
        Keywords = "遊戲翻譯公司,遊戲翻譯 價錢";
    }
}