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

namespace ZeroStudio.Web.Admin.News_Class
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                BLL.NewsClass bll = new BLL.NewsClass();
                Model.NewsClass model = new Model.NewsClass();
                model = bll.GetModel(Convert.ToInt32(Request.QueryString["NC_Id"]));
                tb_ClassName.Text = model.ClassName;
                tb_Sort.Text = model.Sort.ToString();
                description.Text = model.Description;
                keywords.Text = model.Keywords;
                txtTitle.Text = model.ArtListTitle;
                txtDescription.Text = model.ArtListDescription;
            }
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            BLL.NewsClass bll = new BLL.NewsClass();
            Model.NewsClass model = new Model.NewsClass();
            model.Id=Convert.ToInt32(Request.QueryString["NC_Id"]);
            model.ClassName = tb_ClassName.Text;
            model.Sort=Convert.ToInt32(tb_Sort.Text);
            model.Keywords = keywords.Text;
            model.Description = description.Text;
            model.ArtListTitle = txtTitle.Text;
            model.ArtListDescription = txtDescription.Text;
            if (bll.Update(model))
                Response.Redirect("Manage.aspx");
            else
                MessageBox.Show(this, "修改失敗");
        }
    }
}
