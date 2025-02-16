using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APP_Home : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠翻譯公司-受到客戶推薦專業翻譯公司";
        Description = "位於台北的后冠翻譯公司擁有高素質的翻譯專員，翻譯專員由世界各地國家級、外籍專家、留學歸國人員以及各大研究所碩士及博士組成，能提供中文、英語、日語、韓語、德語、俄語、西班牙語等30多種的語言互譯，多元化的服務內容包含：英語翻譯、日語翻譯、韓語翻譯、論文翻譯等相關翻譯技術，受到客戶一致的推薦。";
        Keywords = "翻譯公司,翻譯公司 推薦";
    }
}