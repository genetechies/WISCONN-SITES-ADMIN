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
using ZeroStudio.Helper;

namespace ZeroStudio.Web.Admin.GuestBook {
    public partial class Reply : System.Web.UI.Page {
        BLL.GuestBook b = new ZeroStudio.BLL.GuestBook();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                CommonFunction.IsAdmin();
                if (!string.IsNullOrEmpty(Request.QueryString["G_Id"])) {
                    Model.GuestBook book = b.GetModel(Convert.ToInt32(Request.QueryString["G_Id"]));
                    if (book != null) {
                        lblTitle.Text = book.G_Title;
                        lblUserName.Text = book.G_Username;
                        lblEmail.Text = book.G_Email;
                        lblTime.Text = book.G_Datetime.ToString("yyyy-MM-dd HH:mm:ss");
                        ltlContent.Text = book.G_Content;
                    }
                }
            }
        }
    }
}
