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

namespace ZeroStudio.Web.Admin.Product {
    public partial class success : System.Web.UI.Page {

        protected string aciton;
        protected string backurl;
        protected string otherurl;
        protected string successstr = "Successful!";
        protected string title;

        protected void Page_Load(object sender, EventArgs e) {
            ZeroStudio.Helper.CommonFunction.IsAdmin();
            if (!base.IsPostBack) {
                this.successstr = base.Request.QueryString["success"];
                this.backurl = (base.Request.QueryString["backurl"] == null) ? "" : base.Request.QueryString["backurl"].Replace("|", "&");
                this.otherurl = (base.Request.QueryString["otherurl"] == null) ? "" : base.Request.QueryString["otherurl"].Replace("|", "&");
                this.title = base.Request.QueryString["title"];
                this.aciton = base.Request.QueryString["action"];
            }
        }
    }
}
