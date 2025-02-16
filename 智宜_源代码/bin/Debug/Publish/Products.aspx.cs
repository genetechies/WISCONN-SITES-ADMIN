using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ZeroStudio.Model;

namespace ZeroStudio.Web {
    public partial class Products_en : System.Web.UI.Page {
        BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass(true);
        private static string[] parentclass = new string[] { };
        Dictionary<string, Repeater> parentList = new Dictionary<string, Repeater>();

        protected List<ProductClass> proClassList = new List<ProductClass>();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                proClassList = bclass.GetModelList("");

                //DataView dv = bclass.GetList("PC_ParentID=0").Tables[0].DefaultView;
                //repParent.DataSource = dv;
                //repParent.DataBind();

                //Repeater1.DataSource = dv;
                //Repeater1.DataBind();

                //cateList.DataSource = dv;
                //cateList.DataBind();

                //for (int i = 0; i < cateList.Items.Count; i++) {
                //    Label lblPCId = cateList.Items[i].FindControl("lblPCId") as Label;
                //    Repeater childList = cateList.Items[i].FindControl("childList") as Repeater;
                //    if (childList != null && lblPCId != null) {
                //        DataTable table = ZeroStudio.DBUtility.DbHelperOledb.GetDataTable("select top 4 * from ProductClass where PC_ParentID=" + lblPCId.Text + " order by PC_SortKey");
                //        childList.DataSource = table.DefaultView;// bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                //        childList.DataBind();
                //    }
                //}

                //for (int i = 0; i < repParent.Items.Count; i++)
                //{
                //    Label lblPCId = repParent.Items[i].FindControl("lblPCId") as Label;
                //    if (lblPCId != null)
                //    {
                //        Repeater repChild = repParent.Items[i].FindControl("repChild") as Repeater;
                //        if (repChild != null)
                //        {
                //            DataView dv1 = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                //            if (dv1.Count > 0)
                //            {
                //                repChild.DataSource = dv1;
                //                repChild.DataBind();
                //            }
                //            else
                //            {
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
                //            DataView dv1 = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                //            if (dv1.Count > 0)
                //            {
                //                repChild.DataSource = dv1;
                //                repChild.DataBind();
                //            }
                //            else
                //            {
                //                repChild.Visible = false;
                //            }
                //        }
                //    }
                //}
            }
        }
        protected void cateList_ItemDataBound(object sender, RepeaterItemEventArgs e) {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item) {
                Literal ltlDiv = e.Item.FindControl("ltlDiv") as Literal;
                if (ltlDiv != null && (e.Item.ItemIndex + 1) % 3 == 0) {
                    //ltlDiv.Text = "<div class=\"clear\"></div>";
                }
            }
        }
    }
}