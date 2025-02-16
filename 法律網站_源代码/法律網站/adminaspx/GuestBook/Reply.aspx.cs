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

namespace Web.Admin.GuestBook {
    public partial class Reply : System.Web.UI.Page {
        BLL.XunJia b = new BLL.XunJia();
        public Model.XunJia book = null;

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "guest", RightStatus.Select)) {
                //    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //    return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                if (!string.IsNullOrEmpty(Request.QueryString["G_Id"])) {
                    book =b.GetModel(Convert.ToInt32(Request.QueryString["G_Id"]));
                    if (book != null)
                    {
                        //lblTitle.Text = book.G_Title;
                        //lblUserName.Text = book.G_Username;
                        //lblCompanyName.Text = book.G_CompanyName;
                        //lblTelphone.Text = book.G_Telphone;
                        //lblEmail.Text = book.G_Email;
                        //lblWebsite.Text = book.G_Website;
                        //lblAddress.Text = book.G_Address;
                        //lblCharge.Text = book.G_Charge;
                        //lblRuntime.Text = book.G_Runtime;
                        //lblIsFinish.Text = book.G_IsFinish == 0 ? "未處理" : "已處理";
                        //lblTime.Text = book.G_Datetime.ToString("yyyy-MM-dd HH:mm:ss");
                        //string sql = "select G_IpAddress from GuestBook where G_Id=" + Request.QueryString["G_Id"];
                        ///*
                        //State1 = 1,//Seo網站專用空間
                        //State2 = 1 << 1,//Seo專業網頁設計
                        //State3 = 1 << 2,//全球搜尋引擎登錄
                        //State4 = 1 << 3,//網站排名
                        //State5 = 1 << 4, //社群行銷
                        //State6 = 1 << 5,//論壇行銷
                        //State7 = 1 << 6, //部落格行銷
                        //State8 = 1 << 7,//專業行銷分析系統
                        // */
                        //string result =string.Empty;
                        //if (book.G_Items.IndexOf("1")>0) {
                        //    result = result + "Seo網站專用空間;";
                        //}
                        //if (book.G_Items.IndexOf("2")>0) {
                        //    result = result + "Seo專業網頁設計;";
                        //}
                        //if (book.G_Items.IndexOf("3") > 0)
                        //{
                        //    result = result + "全球搜尋引擎登錄;";
                        //}
                        //if (book.G_Items.IndexOf("4") > 0)
                        //{
                        //    result = result + "網站排名;";
                        //}
                        //if (book.G_Items.IndexOf("5") > 0)
                        //{
                        //    result = result + "社群行銷;";
                        //}
                        //if (book.G_Items.IndexOf("6") > 0)
                        //{
                        //    result = result + "論壇行銷;";
                        //}
                        //if (book.G_Items.IndexOf("7") > 0)
                        //{
                        //    result = result + "部落格行銷;";
                        //}
                        //if (book.G_Items.IndexOf("8") > 0)
                        //{
                        //    result = result + "專業行銷分析系統;";
                        //}
                        //lblItems.Text = result;
                        //ltlContent.Text = book.G_Content;
                        //lblIPAddress.Text = book.G_IpAddress;
                    }
                    else
                    {
                        MyTool.alertback("參數錯誤");
                    }

                }
            }
        }
    }
}
