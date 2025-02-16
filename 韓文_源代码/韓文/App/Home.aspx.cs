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
        Title = "后冠韓文翻譯設(台北、高雄、台中)—忠實傳譯，切實服務，最專業的韓文翻譯服務";
        Description = "臺灣的臺北、臺中、高雄都是重要的經濟文化中心，不僅地理位置優越，經濟條件也十分優秀。因而設立在這三個城市的韓文翻譯社據點，提供客戶便捷高效的聯繫方式。";
        Keywords = "韓文翻譯社 臺北、韓文翻譯社 高雄、韓文翻譯 台中、韓文翻譯 高雄";
    }
}