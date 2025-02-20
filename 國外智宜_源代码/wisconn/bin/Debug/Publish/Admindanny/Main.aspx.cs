﻿using System;
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

namespace ZeroStudio.Web.Admin {
    public partial class Main : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            //要验证Session
            CommonFunction.IsAdmin();

        }
        protected void Quit_Click(object sender, EventArgs e) {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }
    }

}
