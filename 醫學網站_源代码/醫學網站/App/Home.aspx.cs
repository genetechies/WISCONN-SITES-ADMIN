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
        Title = "后冠醫學翻譯公司—醫學翻譯的首選！";
        Description = "醫學翻譯對翻譯師能力要求較高，只懂得語言的翻譯師已難以應對日新月異的醫學翻譯市場需求，后冠醫學翻譯公司擁有多年從業經驗，擁有眾多精通商務、學術等多種醫學相關領域的優秀翻譯師，可以滿足客戶不同的需求。";
        Keywords = "醫學翻譯,醫學翻譯公司";
    }
}