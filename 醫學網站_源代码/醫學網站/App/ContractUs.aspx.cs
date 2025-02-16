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
        Title = "后冠醫學翻譯公司—竭誠期待為您服務，最厲害的醫學翻譯！";
        Description = "后冠醫學翻譯公司提供多種聯繫方式，期待您提出翻譯需求或建議事項，一通電話或是一封郵件，提供給您最優質、最滿意的醫學翻譯服務，真誠期待您的聯繫！";
        Keywords = "醫學翻譯,醫學翻譯公司";
    }
}