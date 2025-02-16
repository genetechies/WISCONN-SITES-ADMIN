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
using System.IO;

namespace ZeroStudio.Web.Admin.Product {
    public partial class ImageUpload : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CommonFunction.IsAdmin(); 
            string jscript = "function UploadComplete(){" + ClientScript.GetPostBackEventReference(LinkButton1, "") + "};";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "FileCompleteUpload", jscript, true);

            //Session["temp"] = "product";
            //FormsIdentity cIdentity = User.Identity as FormsIdentity;
            //string encryptString = Session["temp"].ToString();
            //flashUpload.QueryParameters = string.Format("User={0}", encryptString);
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {


            Response.Write("<script>alert('恭喜您，上傳成功!');</script>");


            // MyGrid.DataBind();
        }
    }
}
