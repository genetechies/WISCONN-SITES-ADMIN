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
        Title = "后冠日文翻譯社(台北、桃園、台中、台南、高雄)—線上諮詢立即瞭解相關訊息";
        Description = "后冠立足台灣，並且在台北、桃園、台中、台南、高雄等地設立了翻譯據點，憑藉優越的地理條件，為各地客戶提供及時便捷的線上諮詢。";
        Keywords = "日文翻譯社 台中、日文翻譯社 高雄、日文翻譯社 桃園、日文翻譯社 台南";
    }
}