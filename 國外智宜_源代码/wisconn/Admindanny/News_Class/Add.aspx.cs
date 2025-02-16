using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ZeroStudio.Web.Admin.News_Class_Manage
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ZeroStudio.Helper.CommonFunction.IsAdmin();
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            Model.NewsClass model = new Model.NewsClass();
            model.ClassName = tb_classname.Text;
            model.Sort = Convert.ToInt32(tb_sort.Text);
            model.Keywords = keywords.Text;
            model.Description = description.Text;
            model.ArtListTitle = txtTitle.Text;
            model.ArtListDescription = txtDescription.Text;

            BLL.NewsClass bll = new BLL.NewsClass();
            if (bll.Exists(model.ClassName))
                MessageBox.Show(this, "欄目已經存在");
            else
            {
                if (bll.Add(model))
                    Response.Redirect("Manage.aspx");
                else
                    MessageBox.Show(this, "添加失敗");
            }
        }
    }
}
