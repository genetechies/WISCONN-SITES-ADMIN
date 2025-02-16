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
        Title = "后冠法律翻譯社提供您最專業的合約翻譯服務！";
        Description = "法律翻譯需要翻譯師具有優秀的翻譯能力與專業的法律知識。客戶對法律翻譯品質要求較高，對此，后冠法律翻譯社秉持著讓客戶滿意為先的理念，嚴格選拔翻譯師，以專業的翻譯給您最好的服務！";
        Keywords = "法律翻譯社,合約翻譯";
    }
}