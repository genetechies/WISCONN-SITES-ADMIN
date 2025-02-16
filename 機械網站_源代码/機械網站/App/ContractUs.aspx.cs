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
        Title = "真誠期待為您服務─專門處理操作手冊翻譯的機械翻譯社";
        Description = "后冠機械翻譯社提供多種便捷聯繫方式，一通電話或是一封郵件，由優質的操作手冊翻譯公司提供給您滿意的翻譯服務，趕快行動吧！";
        Keywords = "操作手冊翻譯社,機械翻譯社";
    }
}