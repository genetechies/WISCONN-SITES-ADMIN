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

namespace ZeroStudio.Web.Admin.News
{
    public partial class Edit : System.Web.UI.Page
    {
        BLL.News bll = new BLL.News();
        protected string oldContext = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Model.News model = new Model.News();
            model = bll.GetModel(Convert.ToInt32(Request.QueryString["N_id"]));
            if (!IsPostBack)
            {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                DDLBind();
                int count = bll.Count("N_IsShow=1 and N_State=1");
                //ltlIsShow.Text = "<span style='color:Red'>當前已經有" + count + "篇文章顯示</span>";

                txtTitle.Text = model.N_title;
                FCK_Content.Value = model.N_Content;
                ddl_newsclass.SelectedValue = model.N_ClassID.ToString();
                txtAuthor.Text = model.N_Author;
                txtDateTime.Text = model.N_DateTime.ToString("yyyy-MM-dd");
                txtDescription.Text = model.N_Description;
                txtKeyword.Text = model.N_Keyword;
                txtSource.Text = model.N_Source;
                txtProduct.Text = model.N_Product;
                oldContext = model.N_Content;

                //cbIsShow.Checked = model.N_IsShow == 1 ? true : false;
            }
        }

        public void DDLBind()
        {
            BLL.NewsClass bll = new BLL.NewsClass();
            ddl_newsclass.DataSource = bll.GetAll();
            ddl_newsclass.DataTextField = "NC_ClassName";
            ddl_newsclass.DataValueField = "NC_Id";
            ddl_newsclass.DataBind();
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            //int count = bll.Count("N_IsShow=1 and N_State=1 and N_Id<>" + Request.QueryString["N_id"]);
            //if (count >= 5 && cbIsShow.Checked) {
            //    ClientScript.RegisterStartupScript(GetType(), "errorshow", "alert('跑馬燈一次最多可顯示5篇文章，當前已經有" + count + "篇文章顯示');", true);
            //    return;
            //}
            Model.News model = bll.GetModel(Convert.ToInt32(Request.QueryString["N_id"]));
            model.N_title = txtTitle.Text;
            model.N_ClassID = Convert.ToInt32(ddl_newsclass.SelectedValue);
            model.N_Content = FCK_Content.Value;
            model.N_Author = txtAuthor.Text;
            model.N_Source = txtSource.Text;
            model.N_Keyword = txtKeyword.Text;
            model.N_Description = txtDescription.Text;
            model.N_DateTime = Convert.ToDateTime(txtDateTime.Text);
            //model.N_IsShow = cbIsShow.Checked ? 1 : 0;
            model.N_Product = txtProduct.Text.Trim();

            bll.Update(model);
            Response.Redirect("Manage.aspx");
        }
    }
}