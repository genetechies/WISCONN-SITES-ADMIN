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

namespace Web.Admin {
    public partial class WebInfo : System.Web.UI.Page {
        protected string inqCount;
        protected string nowTime;
        protected string proCount;
        protected string verTime;

        protected void Page_Load(object sender, EventArgs e) {
            if (!base.IsPostBack) {
                this.nowTime = DateTime.Now.ToString("今天是yyyy年MM月dd日") + "&nbsp;" + this.GetWeek() + "&nbsp;:-)";
                
            }
        }
        private string GetWeek() {
            switch (DateTime.Now.DayOfWeek.ToString().ToLower()) {
                case "monday":
                    return "星期一";

                case "tuesday":
                    return "星期二";

                case "wednesday":
                    return "星期三";

                case "thursday":
                    return "星期四";

                case "friday":
                    return "星期五";

                case "saturday":
                    return "星期六";

                case "sunday":
                    return "星期天";
            }
            return "";
        }
        protected string LoadContent() {
            return ("<div class=\"BodyRight\"><div class=\"RightTop\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td width=\"100%\" height=\"44\" class=\"welcome\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\"><tr><td style=\"padding-left:20px;\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"RightTop\"><tr><td><h1 style=\"float:left;\">" + Session["Admin"].ToString() + "</h1><span id=\"date\" style=\"float:left;margin-top:1px;font-size:14px;\"></span><span style=\"float:left;font-size:14px;padding-right:50px;\">&nbsp;" + this.nowTime + "</span></td></tr></table></td></tr></table></td></tr></table></div></div>");
        }
    }
}