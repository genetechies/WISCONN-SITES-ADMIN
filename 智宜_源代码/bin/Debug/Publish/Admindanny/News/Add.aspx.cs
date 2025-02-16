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



namespace ZeroStudio.Web.Admin.News {
    public partial class Add : System.Web.UI.Page {
        BLL.News bll = new BLL.News();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                int count = bll.Count("N_IsShow=1 and N_State=1");
                //ltlIsShow.Text = "<span style='color:Red'>當前已經有" + count + "篇文章顯示</span>";
                txtDateTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
                DDLBind();
            }
        }

        public void DDLBind() {
            BLL.NewsClass bll = new BLL.NewsClass();
            ddl_newsclass.DataSource = bll.GetAll();
            ddl_newsclass.DataTextField = "NC_ClassName";
            ddl_newsclass.DataValueField = "NC_Id";
            ddl_newsclass.DataBind();
        }

        protected void Sub_Click(object sender, EventArgs e) {
            //int count = bll.Count("N_IsShow=1 and N_State=1");
            //if (count >= 5 && cbIsShow.Checked) {
            //    ClientScript.RegisterStartupScript(GetType(), "errorshow", "alert('當前已經有" + count + "篇文章顯示');", true);
            //    return;
            //}
            Model.News model = new Model.News();
            model.N_title = txtTitle.Text;
            model.N_ClassID = Convert.ToInt32(ddl_newsclass.SelectedValue);
            model.N_Content = FCK_Content.Value;
            model.N_Input = Session["Admin"].ToString();
            model.N_Author = txtAuthor.Text;
            model.N_Source = txtSource.Text;
            model.N_Keyword = txtKeyword.Text;
            model.N_Description = txtDescription.Text;
            model.N_DateTime = Convert.ToDateTime(txtDateTime.Text);
            model.N_HitNum = 0;
            //model.N_IsShow = cbIsShow.Checked ? 1 : 0;
            model.N_State = 1;
            model.N_Product = txtProduct.Text.Trim();


            try
            {
                bll.Add(model);
                Response.Redirect("Manage.aspx");
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                throw;
            }
        }
    }
}