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

namespace ZeroStudio.Web.Admin.ProductClass {
    public partial class QueryCategory : System.Web.UI.Page {
        ZeroStudio.BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();

        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void btnQuery_Click(object sender, EventArgs e) {
            categoryGrid.DataSource = bclass.GetList("PC_ClassName like '%" + txtCategoryName.Text + "%' or PC_ClassName_En like '%" + txtCategoryName.Text + "%'").Tables[0].DefaultView;
            categoryGrid.DataBind();
        }
        public string GetImage(object imageurl, object pc_id) {
            if (imageurl != null && imageurl.ToString() != "") {
                return ("<span class=\"op_pic\"><a href=\"javascript:void(0)\" title=\"<img src='/" + imageurl.ToString() + "'>\" >" + GetClassName((int)pc_id) + "</a></span>");
            }
            return ("<span><a href=\"javascript:void(0)\" >" + GetClassName((int)pc_id) + "</a></span>");
        }
        public string GetClassName(int pc_id) {
            ZeroStudio.Model.ProductClass model = bclass.GetModel(pc_id);
            string result = string.Empty;
            if (model != null) {
                while (model != null) {
                    if (string.IsNullOrEmpty(result)) {
                        result = model.PC_ClassName;
                    } else {
                        result = model.PC_ClassName + "&nbsp;>&nbsp;" + result;
                    }
                    model = bclass.GetModel(model.PC_ParentID);
                }
            }
            return result;
        }
    }
}