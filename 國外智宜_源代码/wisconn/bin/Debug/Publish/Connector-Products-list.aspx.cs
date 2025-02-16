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
    public partial class Products_list_en : System.Web.UI.Page {
        BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();
        protected string keywords = "connector manufacturer,FPC connector";
        protected string description = "Wisconn(connector supplier,connector manufacturer)  provides a variety of connector products such as RJ45 connectors, USB connectors, and FPC connectors and ensures the quality of these products offered.";
        protected string title = "";
        protected string name = "";
        
        protected Model.ProductClass model = new Model.ProductClass();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                //DataView dv1 = bclass.GetList("PC_ParentID=0").Tables[0].DefaultView;

                //repParent.DataSource = dv1;
                //repParent.DataBind();

                //Repeater1.DataSource = dv1;
                //Repeater1.DataBind();

                if (!string.IsNullOrEmpty(Request.QueryString["PC_Id"])) {
                    int PC_Id = Convert.ToInt32(Request.QueryString["PC_Id"]);
                    //for (int i = 0; i < repParent.Items.Count; i++) {
                    //    Label lblPCId = repParent.Items[i].FindControl("lblPCId") as Label;
                    //    if (lblPCId != null ) {
                    //        Repeater repChild = repParent.Items[i].FindControl("repChild") as Repeater;
                    //        if (repChild != null) {
                    //            DataView dv = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                    //            if (dv.Count > 0) {
                    //                repChild.DataSource = dv;
                    //                repChild.DataBind();
                    //            } else {
                    //                repChild.Visible = false;
                    //            }
                    //        }
                    //    }
                    //}

                    //for (int i = 0; i < Repeater1.Items.Count; i++)
                    //{
                    //    Label lblPCId = Repeater1.Items[i].FindControl("Label1") as Label;
                    //    if (lblPCId != null)
                    //    {
                    //        Repeater repChild = Repeater1.Items[i].FindControl("Repeater2") as Repeater;
                    //        if (repChild != null)
                    //        {
                    //            DataView dv = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                    //            if (dv.Count > 0)
                    //            {
                    //                repChild.DataSource = dv;
                    //                repChild.DataBind();
                    //            }
                    //            else
                    //            {
                    //                repChild.Visible = false;
                    //            }
                    //        }
                    //    }
                    //}

                    model = bclass.GetModel(PC_Id);
                    if (model != null) {
                        //ltlClassName.Text = model.PC_ClassName;
                        title = model.PC_ClassName + " - Wisconn connector";
                        name = model.PC_ClassNameEn;
                        keywords = model.Keywords;
                        description = model.Description;
                    }

                    childList.DataSource = bclass.GetList("PC_ParentID=" + PC_Id).Tables[0].DefaultView;
                    childList.DataBind();

                    //for (int i = 0; i < childList.Items.Count; i++) {
                    //    if ((i + 1) % 3 == 0 || i == childList.Items.Count - 1) {
                    //        Literal ltlDiv = childList.Items[i].FindControl("ltlDiv") as Literal;
                    //        if (ltlDiv != null) {
                    //            ltlDiv.Text = "<div class=\"clear\"></div>";
                    //        }
                    //    }
                    //}
                }
            }
        }
    }
}
