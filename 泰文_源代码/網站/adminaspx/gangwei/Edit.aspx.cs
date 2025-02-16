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
using DBUtility;

namespace Web.Admin.News {
    public partial class Edit : System.Web.UI.Page {
        BLL.zhaopin bll = new BLL.zhaopin();

        protected void Page_Load(object sender, EventArgs e) {
            Model.zhaopin model = new Model.zhaopin();
            model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]));
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Update)) {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                txt_gangwei.Text = model.gangwei;
                txt_xueli.Text = model.xueli;
                txt_renshu.Text = model.renshu;
                txt_didian.Text = model.didian;
                txt_daiyu.Text = model.daiyu;
                txt_qixian.Text = model.qixian;
                FCKeditor1.Value = model.yaoqiu;
                

            }
        }

        
        protected void Sub_Click(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Update)) {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Model.zhaopin model = new Model.zhaopin();
            model.id = Convert.ToInt32(Request.QueryString["P_id"]);
            model.gangwei = txt_gangwei.Text.Trim();
            model.xueli = txt_xueli.Text.Trim();
            model.renshu = txt_renshu.Text.Trim();
            model.didian = txt_didian.Text.Trim();
            model.daiyu = txt_daiyu.Text.Trim();
            model.qixian = txt_qixian.Text.Trim();
            model.yaoqiu = FCKeditor1.Value;

            bll.Update(model);
            Response.Redirect("Manage.aspx");
        }
    }
}