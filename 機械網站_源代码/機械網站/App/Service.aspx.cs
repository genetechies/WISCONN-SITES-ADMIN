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
        Title = "后冠機械翻譯社--提供各式機械翻譯服務─操作手冊翻譯、工業翻譯與其他翻譯";
        Description = "后冠操作手冊翻譯社秉持客戶至上的原則，嚴格把關所有流程，力求獲得每一位客戶的滿意。我們堅持品質第一，在工作中不斷總結，追求進步，並不斷擴充翻譯領域，擅長的類別包括有機械翻譯、工業翻譯、科技翻譯、操作手冊翻譯等。";
        Keywords = "操作手冊翻譯社、機械翻譯社";
    }
}