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
using DBUtility;
using Helper;
using System.IO;

namespace Web.Admin.Product {
    public partial class Edit : System.Web.UI.Page {
        BLL.sysconfig bll = new BLL.sysconfig();
        protected void Page_Load(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "webset", RightStatus.Update)) {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (!IsPostBack) {
                Model.sysconfig model = null;
                model = bll.GetModel(1);
                txt_sys_Title.Text = model.sys_Title;
                txt_searchkey.Text = model.searchkey;
                txt_sys_description.Text = model.sys_description;

            }
        }


        protected void Sub_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "webset", RightStatus.Update)) {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }



            Model.sysconfig model = new Model.sysconfig();
            model.id = 1;
            model.sys_Title = txt_sys_Title.Text.Trim();
            model.searchkey = txt_searchkey.Text.Trim();
            model.sys_description = txt_sys_description.Text.Trim();
            bll.Update(model);
            MyTool.alert("修改成功","../WebInfo.aspx");
           
        }

       


    }
}