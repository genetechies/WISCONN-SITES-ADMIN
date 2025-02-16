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
        Title = "后冠法律翻譯社(台北、台中、高雄)—真誠期待為您服務！";
        Description = "后冠法律翻譯社(台北、台中、高雄)提供多種聯繫方式，歡迎您提出的翻譯需求或建議事項，一通電話或是一封郵件，提供給您最優質、最滿意的翻譯服務，期待您的聯繫！";
        Keywords = "法律翻譯 台中,法律翻譯 高雄,法律翻譯 台北";
    }
}