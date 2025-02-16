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

namespace ZeroStudio.Web.Admin.News {
    public partial class DeleteBox : System.Web.UI.Page {
        BLL.News b = new BLL.News();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                AspNetPager1.RecordCount = b.Count("N_State=0");
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = b.GetList_ClassName("N_State=0").Tables[0].DefaultView;
            rpt_news.DataSource = pds;
            rpt_news.DataBind();
        }
        
        
        protected void btnUnDel_Click(object sender, CommandEventArgs e) {
            b.UpdateState(Convert.ToInt32(e.CommandArgument.ToString()), 1);
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e) {
            b.Delete(Convert.ToInt32(e.CommandArgument.ToString()));
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e) {
            DataView dv = b.GetList("N_State=0", "").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int N_Id = (int)dv[i]["N_Id"];
                b.UpdateState(N_Id, 1);
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e) {
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.UpdateState(Convert.ToInt32(lblNId.Text.Trim()), 1);
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e) {
            DataView dv = b.GetList("N_State=0", "").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int N_Id = (int)dv[i]["N_Id"];
                b.Delete(N_Id);
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e) {
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.Delete(Convert.ToInt32(lblNId.Text.Trim()));
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