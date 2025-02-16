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

namespace ZeroStudio.Web {
    public partial class sitemap_en : System.Web.UI.Page {

        BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                repParent.DataSource = bclass.GetList("PC_ParentID=0").Tables[0].DefaultView;
                repParent.DataBind();

                for (int i = 0; i < repParent.Items.Count; i++) {
                    Repeater repChild = repParent.Items[i].FindControl("repChild") as Repeater;
                    Label lblPCId = repParent.Items[i].FindControl("lblPCId") as Label;
                    if (repChild != null && lblPCId != null) {
                        repChild.DataSource = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                        repChild.DataBind();
                    }
                }
            }
        }
        public string FormatLink(object pc_id) {
            if (pc_id == null || pc_id.ToString() == "")
                return "javascript:void(0)";
            int id = (int)pc_id;

            int count = bclass.GetModelList("PC_ParentID=" + id).Count;
            if (count > 0) {
                return "Products-list.aspx?PC_Id=" + id;
            } else {
                return "Products-sublist.aspx?PC_Id=" + id;
            }
        }
    }
}