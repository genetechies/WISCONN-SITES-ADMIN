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
    public partial class DeleteBox : System.Web.UI.Page {
        BLL.Product b = new BLL.Product();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ZeroStudio.Helper.CommonFunction.IsAdmin();
                AspNetPager1.RecordCount = b.Count("P_State=0");
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = b.GetListByClass("[Product].[P_State]=0","").Tables[0].DefaultView;
            rpt_news.DataSource = pds;
            rpt_news.DataBind();
        }


        protected void btnUnDel_Click(object sender, CommandEventArgs e) {
            b.UpdateState(Convert.ToInt32(e.CommandArgument.ToString()), 1);
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e) {
            int p_id = Convert.ToInt32(e.CommandArgument.ToString());
            b.Delete(p_id);
            Model.Product model = b.GetModel(p_id);
            if (model != null) {
                if (!string.IsNullOrEmpty(model.P_PhotoUrl)) {
                    try {
                        System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_PhotoUrl);
                    } catch (Exception) { }
                }
                if (!string.IsNullOrEmpty(model.P_Doc)) {
                    try {
                        System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_Doc);
                    } catch (Exception) { }
                }
            }
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e) {
            DataView dv = b.GetList("P_State=0", "").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int N_Id = (int)dv[i]["P_Id"];
                b.UpdateState(N_Id, 1);
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e) {
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblPID") as Label;
                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.UpdateState(Convert.ToInt32(lblNId.Text.Trim()), 1);
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e) {
            DataView dv = b.GetList("P_State=0", "").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int P_Id = (int)dv[i]["P_Id"];
                b.Delete(P_Id);
                Model.Product model = b.GetModel(P_Id);
                if (model != null) {
                    if (!string.IsNullOrEmpty(model.P_PhotoUrl)) {
                        try {
                            System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_PhotoUrl);
                        } catch (Exception) { }
                    }
                    if (!string.IsNullOrEmpty(model.P_Doc)) {
                        try {
                            System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_Doc);
                        } catch (Exception) { }
                    }
                }
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e) {
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblPId = rpt_news.Items[i].FindControl("lblPID") as Label;
                if (cbSelect != null && lblPId != null) {
                    if (cbSelect.Checked) {
                        b.Delete(Convert.ToInt32(lblPId.Text.Trim()));
                        Model.Product model = b.GetModel(Convert.ToInt32(lblPId.Text.Trim()));
                        if (model != null) {
                            if (!string.IsNullOrEmpty(model.P_PhotoUrl)) {
                                try {
                                    System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_PhotoUrl);
                                } catch (Exception) { }
                            }
                            if (!string.IsNullOrEmpty(model.P_Doc)) {
                                try {
                                    System.IO.File.Delete(Server.MapPath("~\\") + "\\" + model.P_Doc);
                                } catch (Exception) { }
                            }
                        }
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