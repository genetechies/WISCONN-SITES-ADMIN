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
        Title = "后冠日文翻譯公司—誠信為先，專業為本";
        Description = "后冠日文翻譯公司成立以來，已經承接眾多各類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，盡心盡力為每一位客戶提供超越想像價格和品質，給客戶最優質專業的翻譯服務。";
        Keywords = "日文翻譯公司";
    }
}