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
using ZeroStudio.DBUtility;

namespace ZeroStudio.Web {
    public partial class Index_en : System.Web.UI.Page {
        BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Model.ProductClass pclass = null;
                pclass = bclass.GetModel("SATA 連接器");
                if (pclass != null) {
                    Bind(repList1, pclass.PC_Id);
                    HyperLink1.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;
                } else {
                    HyperLink1.NavigateUrl = "javascript:void(0);";
                }
                pclass = bclass.GetModel("RJ 連接器");
                if (pclass != null) {
                    Bind(repList2, pclass.PC_Id);
                    HyperLink2.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;
                } else {
                    HyperLink2.NavigateUrl = "javascript:void(0);";
                }
                pclass = bclass.GetModel("FPC 連接器");
                if (pclass != null) {
                    Bind(repList3, pclass.PC_Id);
                    HyperLink3.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;

                } else {
                    HyperLink3.NavigateUrl = "javascript:void(0);";
                }
                pclass = bclass.GetModel("USB2.0 連接器");
                if (pclass != null) {
                    Bind(repList4, pclass.PC_Id);
                    HyperLink4.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;

                } else {
                    HyperLink4.NavigateUrl = "javascript:void(0);";
                }
                pclass = bclass.GetModel("SFP 連接器");
                if (pclass != null) {
                    Bind(repList5, pclass.PC_Id);
                    HyperLink5.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;

                } else {
                    HyperLink5.NavigateUrl = "javascript:void(0);";
                }
                pclass = bclass.GetModel("HDMI 連接器");
                if (pclass != null) {
                    Bind(repList6, pclass.PC_Id);
                    HyperLink6.NavigateUrl = "Connector-Products-list.aspx?PC_Id=" + pclass.PC_Id;
                } else {
                    HyperLink6.NavigateUrl = "javascript:void(0);";
                }
            }
        }

        public void Bind(Repeater repeater, int parentID) {
            DataTable table = DbHelperOledb.GetDataTable("select top 5 * from ProductClass where PC_ParentID=" + parentID + " order by PC_SortKey");

            repeater.DataSource = table.DefaultView;
            repeater.DataBind();
        }
    }
}