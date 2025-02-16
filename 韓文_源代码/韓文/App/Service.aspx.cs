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
        Title = "后冠韓文翻譯社—最好的推薦，最佳的價格";
        Description = "后冠韓文翻譯社的服務專案包括筆譯服務、網頁服務等類型，以期滿足客戶不同的需求。雖然服務類別多樣，但是后冠在價格上一直秉持著為客戶著想的角度，公平公正、公開合理，希望能夠成為客戶心目中最受推薦的韓文翻譯社。";
        Keywords = "韓文翻譯社  推薦、韓文翻譯社  價格";
    }
}