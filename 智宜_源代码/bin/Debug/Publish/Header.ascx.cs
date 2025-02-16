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
    public partial class Header_en : System.Web.UI.UserControl {
        private string _pageid;
        private string _banner;

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(PageID))
                {

                    System.Web.UI.HtmlControls.HtmlControl li = FindControl(PageID) as System.Web.UI.HtmlControls.HtmlControl;
                    if (li != null)
                    {
                        li.Attributes.Add("class", " current_page_item");
                    }
                }
                //if (!string.IsNullOrEmpty(Banner))
                //{
                //    ltlBanner.Text = "<div id=\"" + Banner + "\"></div>";
                //}
            }
        }
        public string PageID {
            get {
                return _pageid;
            }
            set {
                _pageid = value;
            }
        }
        public string Banner {
            get {
                return _banner;
            }
            set {
                _banner = value;
            }
        }
    }
}
