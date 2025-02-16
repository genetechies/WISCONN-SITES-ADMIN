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
        Title = "台灣后冠翻譯社—需要遊戲翻譯就聯繫我們吧！";
        Description = "台灣后冠遊戲翻譯社一直在努力完善各項服務，爭取為大家提供更加專業、更加貼心的遊戲翻譯服務。如果您有任何這個方面的翻譯需要，請聯繫我們吧！";
        Keywords = "遊戲翻譯社,遊戲翻譯 台灣";
    }
}