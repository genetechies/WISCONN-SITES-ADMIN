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
    public partial class Products_sublist_en : System.Web.UI.Page {
        BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass(true);
        BLL.Product bll = new ZeroStudio.BLL.Product(true);
        protected string keywords = "連接器，連接器製造商，連接器廠商，連接器供應商，USB連接器，RJ45連接器，FPC連接器，SATA連接器";
        protected string description = "智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。";
        protected string title = "- Wisconn connector";

        protected Model.ProductClass showModel = new Model.ProductClass();
        protected Model.ProductClass childModel = new Model.ProductClass();
        protected Model.ProductClass parentModel = new Model.ProductClass();
        protected string nav = "";
        protected string name = "";

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                //Repeater1.DataSource = dv1;
                //Repeater1.DataBind();
                if (!string.IsNullOrEmpty(Request.QueryString["PC_Id"])) {
                    int PC_Id = Convert.ToInt32(Request.QueryString["PC_Id"]);
                    //ltlClassName.Text = GetParentName(PC_Id);
                    title = GetParentName(PC_Id) + title;
                   
                    Model.ProductClass model = bclass.GetModel(PC_Id);
                    showModel = model;
                    parentModel = bclass.GetModel(model.PC_ParentID);
                    if (model != null) {
                        description = model.Description;
                        keywords = model.Keywords;
                        //for (int i = 0; i < repParent.Items.Count; i++) {
                        //    Label lblPCId = repParent.Items[i].FindControl("lblPCId") as Label;
                        //    if (lblPCId != null ) {
                        //        Repeater repChild = repParent.Items[i].FindControl("repChild") as Repeater;
                        //        if (repChild != null) {

                        //            var parentid = Convert.ToInt32(lblPCId.Text.Trim());

                        //            if (lblPCId.Text.Trim() == model.PC_ParentID.ToString())
                        //            {
                        //                repChild.DataSource = list.Where(w=>w.PC_ParentID== parentid) ;
                        //                repChild.DataBind();
                        //            }
                        //            else
                        //            {
                        //                Model.ProductClass childmodel = bclass.GetModel(model.PC_ParentID);
                        //                childModel = childmodel;
                        //                parentModel = bclass.GetModel(childmodel.PC_ParentID);
                                        

                        //                repChild.DataSource = list.Where(w => w.PC_ParentID == parentid);
                        //                repChild.DataBind();
                        //            }
                        //        }
                        //    }
                        //}
                        //if (flag) {
                        //    for (int i = 0; i < repParent.Items.Count; i++) {
                        //        Label lblPCId = repParent.Items[i].FindControl("lblPCId") as Label;
                        //        Model.ProductClass childmodel = bclass.GetModel(model.PC_ParentID);
                        //        childModel = childmodel;
                        //        if (childmodel != null && lblPCId != null ) {
                        //            parentModel = bclass.GetModel(childmodel.PC_ParentID);

                        //            Repeater repChild = repParent.Items[i].FindControl("repChild") as Repeater;
                        //            if (repChild != null) {
                        //                repChild.DataSource = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                        //                repChild.DataBind();
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
                        //            var parentid = Convert.ToInt32(lblPCId.Text.Trim());

                        //            if (lblPCId.Text.Trim() == model.PC_ParentID.ToString())
                        //            {
                        //                repChild.DataSource = list.Where(w => w.PC_ParentID == parentid);
                        //                repChild.DataBind();
                        //            }
                        //            else
                        //            {
                        //                Model.ProductClass childmodel = bclass.GetModel(model.PC_ParentID);
                        //                childModel = childmodel;
                        //                parentModel = bclass.GetModel(childmodel.PC_ParentID);

                        //                repChild.DataSource = list.Where(w => w.PC_ParentID == parentid);
                        //                repChild.DataBind();
                        //            }
                        //        }
                        //    }
                        //}

                        if (parentModel == null)
                        {
                            parentModel = new Model.ProductClass();
                        }
                        //if (flag)
                        //{
                        //    for (int i = 0; i < Repeater1.Items.Count; i++)
                        //    {
                        //        Label lblPCId = Repeater1.Items[i].FindControl("Label1") as Label;
                        //        Model.ProductClass childmodel = bclass.GetModel(model.PC_ParentID);
                        //        childModel = childmodel;
                        //        if (childmodel != null && lblPCId != null)
                        //        {
                        //            parentModel = bclass.GetModel(childmodel.PC_ParentID);

                        //            Repeater repChild = Repeater1.Items[i].FindControl("Repeater2") as Repeater;
                        //            if (repChild != null)
                        //            {
                        //                repChild.DataSource = bclass.GetList("PC_ParentID=" + lblPCId.Text).Tables[0].DefaultView;
                        //                repChild.DataBind();
                        //            }
                        //        }
                        //    }
                        //}
                    }
                    int count = bclass.GetList("PC_ParentID_Zh=" + PC_Id).Tables[0].DefaultView.Count;
                    if (count <= 0)
                    {
                        AspNetPager1.RecordCount = bll.Count("P_State=1 and P_ClassID_Zh=" + PC_Id);
                    }
                    else
                    {
                        AspNetPager1.RecordCount = count;
                    }

                    Bind();

                } else if (!string.IsNullOrEmpty(Request.QueryString["k"])) {
                    AspNetPager1.RecordCount = bll.CountByClass("product.P_State=1 and (product.P_Model like '%" + Server.UrlDecode(Request.QueryString["k"]) + "%' or ProductClass.PC_ClassName_En like '%" + Server.UrlDecode(Request.QueryString["k"]) + "%')");
                    Bind();
                } else {
                    AspNetPager1.RecordCount = bll.Count("P_State=1");
                    Bind();
                }

            }

            GetParentName1(Request.QueryString["PC_Id"]);
        }
        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            if (!string.IsNullOrEmpty(Request.QueryString["PC_Id"])) {
                int PC_Id = Convert.ToInt32(Request.QueryString["PC_Id"]);
                int count = bclass.GetList("PC_ParentID_Zh=" + PC_Id).Tables[0].DefaultView.Count;
                if (count <= 0) {
                    pds.DataSource = bll.GetList("[Product].P_State=1 and [Product].P_ClassID_Zh=" + Request.QueryString["PC_Id"], "[Product].P_ParentID,[Product].P_Id").Tables[0].DefaultView;
                    childList.DataSource = pds;
                    childList.DataBind();
                    cateList.Visible = false;
                    //for (int i = 0; i < childList.Items.Count; i++) {
                    //    if ((i + 1) % 3 == 0 || i == childList.Items.Count - 1) {
                    //        Literal ltlDiv = childList.Items[i].FindControl("ltlDiv") as Literal;
                    //        if (ltlDiv != null) {
                    //            ltlDiv.Text = "<div class=\"clear\"></div>";
                    //        }
                    //    }
                    //}
                } else {
                    pds.DataSource = bclass.GetList("PC_ParentID_Zh=" + PC_Id).Tables[0].DefaultView;

                    cateList.DataSource = pds;
                    cateList.DataBind();
                    childList.Visible = false;
                    //for (int i = 0; i < cateList.Items.Count; i++) {
                    //    if ((i + 1) % 3 == 0 || i == cateList.Items.Count - 1) {
                    //        Literal ltlDiv = cateList.Items[i].FindControl("ltlDiv") as Literal;
                    //        if (ltlDiv != null) {
                    //            ltlDiv.Text = "<div class=\"clear\"></div>";
                    //        }
                    //    }
                    //}
                }
            } else if (!string.IsNullOrEmpty(Request.QueryString["k"])) {
                var dt = bll.GetList("[Product].P_State=1 and ([Product].P_Model like '%" + Server.UrlDecode(Request.QueryString["k"]) + "%' or [ProductClass].PC_ClassName_En like '%" + Server.UrlDecode(Request.QueryString["k"]) + "%')", "[Product].P_ParentID,[Product].P_Id").Tables[0];
                pds.DataSource = dt.DefaultView;
                childList.DataSource = pds;
                childList.DataBind();
                cateList.Visible = false;

                if (dt.Rows.Count == 1)
                {
                    title = GetParentName(Convert.ToInt32(dt.Rows[0]["P_ClassID"])) + title;
                    GetParentName1(dt.Rows[0]["P_ClassID"].ToString());
                }
                else
                {
                    nav = "<li>搜寻“" + Request.QueryString["k"] + "”</li>";
                    name = "搜寻“" + Request.QueryString["k"] + "”";
                }
                //for (int i = 0; i < childList.Items.Count; i++) {
                //    if ((i + 1) % 3 == 0 || i == childList.Items.Count - 1) {
                //        Literal ltlDiv = childList.Items[i].FindControl("ltlDiv") as Literal;
                //        if (ltlDiv != null) {
                //            ltlDiv.Text = "<div class=\"clear\"></div>";
                //        }
                //    }
                //}
            } else {
                pds.DataSource = bll.GetList("[Product].P_State=1", "[Product].P_ParentID,[Product].P_Id").Tables[0].DefaultView;
                childList.DataSource = pds;
                childList.DataBind();
                cateList.Visible = false;
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
        protected void AspNetPager1_PageChanged(object sender, EventArgs e) {

            Bind();
        }
        private string GetParentName(int pc_id) {
            string result = string.Empty;
            ZeroStudio.Model.ProductClass model = bclass.GetModel(pc_id);
            if (model != null) {
                while (model != null) {
                    if (string.IsNullOrEmpty(result)) {
                        result = model.PC_ClassName;
                    name=result;
                    } else {
                    name=result;
                        result = model.PC_ClassName + "&nbsp;>&nbsp;" + result;
                    }
                    model = bclass.GetModel(model.PC_ParentID);

                  
                }
                 if (result.Contains(";"))
                {
                    name = result.Substring(result.LastIndexOf(';')+1, result.Length - result.LastIndexOf(';')-1);
                }
            }
            return result;
        }

        protected void GetParentName1(string pc_id)
        {
            if (!string.IsNullOrEmpty(pc_id))
            {
                ZeroStudio.Model.ProductClass model = bclass.GetModel(Convert.ToInt32(pc_id));
                if (model != null)
                {
                    while (model != null)
                    {
                        if (string.IsNullOrEmpty(nav))
                        {
                            nav = "<li><a href=\"/Products-sublist.aspx?PC_Id=" + model.PC_Id + "\">" + model.PC_ClassName + "</a><i class=\"ico-angle-right\"></i></li>";
                        }
                        else
                        {
                            nav = "<li><a href=\"/Products-list.aspx?PC_Id=" + model.PC_Id + "\">" + model.PC_ClassName + "</a><i class=\"ico-angle-right\"></i></li>" + nav;
                        }
                        model = bclass.GetModel(model.PC_ParentID);
                    }
                }
            }
        }
    }
}
