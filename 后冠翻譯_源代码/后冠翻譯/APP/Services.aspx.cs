using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APP_Services : System.Web.UI.Page
{    public string Keywords { get; set; }
    public string Description { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Title = "后冠翻譯公司 - 各項英文、日文翻譯等服務項目";
        Keywords = "英文 校稿,翻譯公司";
        Description = "后冠翻譯公司提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。";
    }
}