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
        Title = "后冠日文翻譯（台中、高雄）—全方位的服務專案";
        Description = "台中和高雄都是台灣直轄市，是經濟、政治、文化中心，也是典型的國際城。后冠成立在此的日文翻譯社不僅能夠滿足市場的需求，也能為廣大客戶提供便利的日文翻譯服務。后冠提供的服務類型多種多樣，包括筆譯、校對、潤飾、網站翻譯、影片翻譯、打字排版等等。";
        Keywords = "日文翻譯 台中、日文翻譯 高雄";
    }
}