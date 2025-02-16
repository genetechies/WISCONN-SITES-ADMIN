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
    public partial class DeleteBox : System.Web.UI.Page {
        BLL.linyuxinxi b = new BLL.linyuxinxi();

        protected void Page_Load(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                AspNetPager1.RecordCount = b.Count("hst=1");
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = b.GetList("hst=1").Tables[0].DefaultView;
            rpt_news.DataSource = pds;
            rpt_news.DataBind();
        }


        protected void btnUnDel_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            b.UpdateState(Convert.ToInt32(e.CommandArgument.ToString()), 0);
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            int p_id = Convert.ToInt32(e.CommandArgument.ToString());
            b.Delete(p_id);
            
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = b.GetList("hst=1").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int N_Id = (int)dv[i]["id"];
                b.UpdateState(N_Id, 0);
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblPID") as Label;
                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.UpdateState(Convert.ToInt32(lblNId.Text.Trim()), 0);
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = b.GetList("hst=1").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int P_Id = (int)dv[i]["id"];
                b.Delete(P_Id);
                
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblPId = rpt_news.Items[i].FindControl("lblPID") as Label;
                if (cbSelect != null && lblPId != null) {
                    if (cbSelect.Checked) {
                        b.Delete(Convert.ToInt32(lblPId.Text.Trim()));
                        
                    }
                }
            }
            Bind();
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e) {
            Bind();
        }
    }
}