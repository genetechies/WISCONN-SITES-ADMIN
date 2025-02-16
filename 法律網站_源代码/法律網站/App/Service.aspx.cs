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
        Title = "后冠法律翻譯社—高品質英文法律合約翻譯的首選";
        Description = "后冠法律翻譯社嚴格把關所有完成的作品，每一位來過后冠的客戶都對我們的翻譯品質有著高評價。我們追求進步，在每一次的英文法律合約翻譯中總結經驗，不斷完善自己，希望能夠獲得更多的翻譯機會，藉由一次次的實務更加完善我們的服務。";
        Keywords = "法律合約翻譯,英文法律合約";
    }
}