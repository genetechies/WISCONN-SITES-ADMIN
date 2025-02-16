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
using System.Collections.Generic;
using ZeroStudio.Model;
using System.Linq;

namespace ZeroStudio.Web {
    public partial class Portfolio_detail_en : System.Web.UI.Page {
        private BLL.NewsClass bclass = new ZeroStudio.BLL.NewsClass();
        private BLL.News bll = new ZeroStudio.BLL.News();
        ZeroStudio.BLL.ProductClass pbclass = new ZeroStudio.BLL.ProductClass();
        ZeroStudio.BLL.Product pbll = new ZeroStudio.BLL.Product();

        protected List<ProductClass> proClassList = new List<ProductClass>();
        protected string ntitle;
        protected string hitnum;
        protected string datetime;
        protected string author;
        protected string content;
        protected string keywords = "連接器，連接器製造商，連接器廠商，連接器供應商，USB連接器，RJ45連接器，FPC連接器，SATA連接器";
        protected string description = "智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。";
        protected string title = "";

        protected string productName = "CONNECTOR PRODUCT";
        protected string pcId = "";
protected Model.NewsClass classInfo;
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                DataView dv= bclass.GetAll().Tables[0].DefaultView;

                newsClassList.DataSource = dv;
                newsClassList.DataBind();

                Repeater1.DataSource = dv;
                Repeater1.DataBind();
                proClassList = pbclass.GetModelList("");
                if (!string.IsNullOrEmpty(Request.QueryString["N_Id"])) {
                    int N_Id=Convert.ToInt32(Request.QueryString["N_Id"]);
                    Model.News model = bll.GetModel(N_Id);
                    if (model != null) {
                        keywords = model.N_Keyword;
                        description = model.N_Description;
                        ntitle = model.N_title;

                        hitnum = model.N_HitNum.ToString();
                        datetime = model.N_DateTime.ToString("yyyy-MM-dd");
                        author = model.N_Author;
                        content = model.N_Content;
                        int classid = model.N_ClassID;
                        bll.UpdateHitNum(model.N_Id, 1);
                         classInfo = bclass.GetModel(classid);
                        if (classInfo != null)
                        {
                            title = classInfo.ClassName + "-";
                        }

                        if (!string.IsNullOrEmpty(model.N_Product))
                        {
                                pcId = model.N_Product;
                        }
                    }
                }
            }
        }
    }
}
