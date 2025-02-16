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
using System.Text;
using Helper;

namespace Web.Admin.Product {
    public partial class Manage : System.Web.UI.Page {

        BLL.zhaopin bll = new BLL.zhaopin();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {

                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                Where = "1=1";   
                AspNetPager1.RecordCount = bll.CountByClass(Where);
                Bind();


            }
        }




        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = bll.GetListByClass(Where, "id desc").Tables[0].DefaultView;
            productGrid.DataSource = pds;
            productGrid.DataBind();

            
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Del_Click(Object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                // return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            LinkButton btn = sender as LinkButton;
            int p_id = Convert.ToInt32(btn.CommandArgument);
            bll.Delete(p_id);
            Bind();
        }

        protected void productGrid_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "modfiy")
            {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Update))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                LinkButton link = e.CommandSource as LinkButton;
                int index = Convert.ToInt32(e.CommandArgument);
                Label lblPID = productGrid.Items[index].FindControl("lblPID") as Label;
                TextBox sortkey = productGrid.Items[index].FindControl("txtParentID") as TextBox;
                if (lblPID != null && sortkey != null)
                {
                    int p_id = Convert.ToInt32(lblPID.Text.Trim());
                    Model.zhaopin p = bll.GetModel(p_id);
                    int sort = 0;
                    try
                    {
                        sort = Convert.ToInt32(sortkey.Text);
                    }
                    catch (Exception)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "error", "alert('無效的排序號');", true);
                        return;
                    }
                    if (sort < 0)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "error", "alert('排序號必須為大於零的正整數');", true);
                        return;
                    }
                    if (p.sort != sort)
                    {
                        bll.UpdateSortKey(p_id, sort);
                    }
                    Bind();
                }
            }
        }

        protected void productGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                TextBox sortkey = e.Item.FindControl("txtParentID") as TextBox;
                LinkButton modfiy = e.Item.FindControl("btnModfiySortKey") as LinkButton;
                if (modfiy != null && sortkey != null)
                {
                    modfiy.Attributes.Add("onclick", "return validText('" + sortkey.ClientID + "');");
                    modfiy.CommandArgument = e.Item.ItemIndex.ToString();
                }
            }
        }


        protected void Button2_Click(object sender, EventArgs e)   //查询
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "gangwei", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            if (!string.IsNullOrEmpty(searchText1.Text) && searchText1.Text.Trim() != "查詢人才招募訊息")
            {
                Where = "gangwei like '%" + searchText1.Text + "%' or yaoqiu like '%" + searchText1.Text + "%' ";
            }
            else
            {
                Where = "1=1";
            }

            AspNetPager1.RecordCount = bll.CountByClass(Where);
            Bind();
        }

        protected void btnDelAll_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "sign", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < productGrid.Items.Count; i++)
            {
                Label lblPID = productGrid.Items[i].FindControl("lblPID") as Label;
                CheckBox cbSelect = productGrid.Items[i].FindControl("cbSelect") as CheckBox;
                if (lblPID != null && cbSelect != null)
                {
                    if (cbSelect.Checked)
                    {
                        int p_id = Convert.ToInt32(lblPID.Text.Trim());
                        bll.Delete(p_id);
                    }
                }
            }
            Bind();
        }

        public string Where
        {
            get
            {
                if (ViewState["Where"] == null)
                    ViewState["Where"] = "";
                return (string)ViewState["Where"];
            }
            set
            {
                ViewState["Where"] = value;
            }
        }
}
}