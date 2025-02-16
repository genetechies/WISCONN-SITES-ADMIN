using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_AboutUs : System.Web.UI.Page
{
    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠日文翻譯社（台北）—可靠、細心的日文翻譯";
        Description = "后冠日文翻譯社立足在台北，國際化的腳步一直未停歇，迄今為止，在深圳、香港、澳門等地都有翻譯據點；翻譯的語言包括英文翻譯、日文翻譯等三十幾種語言，並且在不斷地發展，為爭取每一位客戶而前進，為每一位客戶的期待而努力。";
        Keywords = "日文翻譯 台北、日文翻譯社 台北";
    }
}