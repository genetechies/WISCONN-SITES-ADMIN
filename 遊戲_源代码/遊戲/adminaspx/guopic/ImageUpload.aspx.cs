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
using Helper;

namespace Web.Admin.Product {
    public partial class ImageUpload : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "pluppic", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string jscript = "function UploadComplete(){" + ClientScript.GetPostBackEventReference(LinkButton1, "") + "};";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "FileCompleteUpload", jscript, true);

            if (!IsPostBack)
            {
                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();

                for (int i = 0; i < cbxWeb.Items.Count; i++)
                {
                    cbxWeb.Items[0].Selected = true;
                }
            }
            //Session["temp"] = "product";
            //FormsIdentity cIdentity = User.Identity as FormsIdentity;
            //string encryptString = Session["temp"].ToString();
            //flashUpload.QueryParameters = string.Format("User={0}", encryptString);
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {

            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "pluppic", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            Response.Write("<script>alert('恭喜您，上傳成功!');</script>");


            // MyGrid.DataBind();
        }
    }
}
