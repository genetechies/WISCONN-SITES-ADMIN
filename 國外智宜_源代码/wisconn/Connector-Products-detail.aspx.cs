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
    public partial class Products_detail_en : System.Web.UI.Page {
        private BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();

        protected string imageurl;
        protected string stock;
        protected string spec;
        protected string evinr;
        protected string identity;
        protected string pdoc;
        protected string keywords = "連接器，連接器製造商，連接器廠商，連接器供應商，USB連接器，RJ45連接器，FPC連接器，SATA連接器";
        protected string description = "智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。";
        protected string title = "";
        protected string name = "";

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                if (!string.IsNullOrEmpty(Request.QueryString["P_Id"])) {
                    int P_Id = Convert.ToInt32(Request.QueryString["P_Id"]);
                    BLL.Product bll = new ZeroStudio.BLL.Product();
                    Model.Product model = bll.GetModel(P_Id);
                    if (model != null) {
                        pdoc = model.P_Doc;
                        title = model.P_Model;
                        keywords = model.Keywords;
                        description = model.Description;
                        name = model.P_Name_En;


                    }
                }
            }
        }
    }
}
