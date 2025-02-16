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

namespace Web.Admin.Product
{
    public partial class Manage : System.Web.UI.Page
    {

        BLL.TransZone bll = new BLL.TransZone();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                ViewState["admin"]="";
                Where = "D_Recycle=0";   //0不在回收站 
                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();
                Bind();
                BindClass();
                AspNetPager1.RecordCount = GetSelectList(this.cbxWeb).Count;

            }
        }

        private void BindClass()
        {
            //BLL.TransZone bll = new BLL.TransZone();
            //DataView dv = bll.GetList("").Tables[0].DefaultView;
            //for (int i = 0; i < dv.Count; i++)
            //{
            //    ddlCategory.Items.Add(new ListItem(dv[i]["NC_ClassName"].ToString(), dv[i]["NC_ID"].ToString()));
            //}
            BLL.TransZone bll = new BLL.TransZone();
            ddlCategory.Items.Clear();
            if (this.cbxWeb.SelectedItem != null)
            {
                if (!this.cbxWeb.Items[0].Selected)
                {
                    for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                    {
                        if (this.cbxWeb.Items[i].Selected)
                        {
                            DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
                            for (int j = 0; j < dv.Count; j++)
                            {
                                if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["NC_ClassName"].ToString())))
                                {
                                    ListItem item = new ListItem();
                                    item.Text = dv[j]["NC_ClassName"].ToString();
                                    this.ddlCategory.Items.Add(item);
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < this.cbxWeb.Items.Count; i++)
                    {

                        DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
                        for (int j = 0; j < dv.Count; j++)
                        {
                            if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["NC_ClassName"].ToString())))
                            {
                                ListItem item = new ListItem();
                                item.Text = dv[j]["NC_ClassName"].ToString();
                                this.ddlCategory.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }
        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            //bll.GetListByClassNew(Where, "D_ID desc").Tables[0].DefaultView;
            pds.DataSource = GetSelectList(this.cbxWeb);
            productGrid.DataSource = pds;
            productGrid.DataBind();


        }
        /// <summary>
        /// 獲取不同網站的數據
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataView GetSelectList(CheckBoxList list)
        {
            DataTable dt = new DataTable();
            if (list.SelectedItem != null)
            {

                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("D_ID", Type.GetType("System.Int32"));//ID
                dt.Columns.Add("D_Title", Type.GetType("System.String"));//標題
                dt.Columns.Add("ClassName", Type.GetType("System.String"));//欄位分類
                dt.Columns.Add("D_Editor", Type.GetType("System.String"));//管理員
                dt.Columns.Add("D_Time", Type.GetType("System.String"));//建立時間
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID
                dt.Columns.Add("OrderID", Type.GetType("System.Int32"));//排序號


                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].Selected)
                    {
                        try
                        {
                            int SwID = Convert.ToInt32(list.Items[i].Value);
                            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                            try
                            {
                                if (ddlCategory.SelectedValue != "-1")
                                {
                                    if (!string.IsNullOrEmpty(Where))
                                    {
                                        Where = Where + " and D_ClassID in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                    }
                                    else
                                    {
                                        Where = " D_Recycle=0 and D_ClassID in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                    }
                                }
                            }
                            catch (Exception)
                            {

                            }
                            dt2 = bll.GetListByClassNew(Where, "D_ID desc", web).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["D_ID"] = dt2.Rows[j]["D_ID"].ToString();
                                dr["D_Title"] = dt2.Rows[j]["D_Title"].ToString();
                                dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                                dr["D_Editor"] = dt2.Rows[j]["D_Editor"].ToString();
                                dr["D_Time"] = DateTime.Parse(dt2.Rows[j]["D_Time"].ToString()).ToString("yyyy-MM-dd");
                                dr["WebSite"] = list.Items[i].Text;
                                dr["Swid"] = list.Items[i].Value;
                                dr["OrderID"] = dt2.Rows[j]["OrderID"].ToString();
                                dt.Rows.Add(dr);
                            }
                        }
                        catch (Exception) { }
                    }
                }
                return dt.DefaultView;
            }
            else
            {
                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("D_ID", Type.GetType("System.Int32"));//ID
                dt.Columns.Add("D_Title", Type.GetType("System.String"));//標題
                dt.Columns.Add("ClassName", Type.GetType("System.String"));//欄位分類
                dt.Columns.Add("D_Editor", Type.GetType("System.String"));//管理員
                dt.Columns.Add("D_Time", Type.GetType("System.String"));//建立時間
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID
                dt.Columns.Add("OrderID", Type.GetType("System.Int32"));//排序號

                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 1; i < list.Items.Count; i++)
                {
                    try
                    {
                        int SwID = Convert.ToInt32(list.Items[i].Value);
                        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                        try
                        {
                            if (ddlCategory.SelectedValue != "-1")
                            {
                                if (!string.IsNullOrEmpty(Where))
                                {
                                    Where = Where + " and D_ClassID in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                }
                                else
                                {
                                    Where = " D_Recycle=0 and D_ClassID in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                        dt2 = bll.GetListByClassNew(Where, "D_ID desc",web).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            dr = dt.NewRow();
                            dr["D_ID"] = dt2.Rows[j]["D_ID"].ToString();
                            dr["D_Title"] = dt2.Rows[j]["D_Title"].ToString();
                            dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                            dr["D_Editor"] = dt2.Rows[j]["D_Editor"].ToString();
                            dr["D_Time"] = DateTime.Parse(dt2.Rows[j]["D_Time"].ToString()).ToString("yyyy-MM-dd");
                            dr["WebSite"] = list.Items[i].Text;
                            dr["Swid"] = list.Items[i].Value;
                            dr["OrderID"] = dt2.Rows[j]["OrderID"].ToString();
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                return dt.DefaultView;
            }
            //return dt.DefaultView;

        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }

        protected void Del_Click(Object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                // return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            LinkButton btn = sender as LinkButton;
            int p_id = Convert.ToInt32(btn.CommandArgument.Split(',')[0]);
            bll.UpdateStateNew(p_id, 1, new BLL.SubWeb().GetModel(Convert.ToInt32(btn.CommandArgument.Split(',')[1])));
            Bind();
        }

        protected void productGrid_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "modfiy")
            {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Update))
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
                    Model.newsdata p = bll.GetModelNew(p_id);
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
                    if (p.OrderID != sort)
                    {
                        bll.UpdateSortKeyNew(p_id, sort);
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            if (!string.IsNullOrEmpty(searchText1.Text) && searchText1.Text.Trim() != "查詢網頁訊息")
            {
                Where = "D_Recycle=0 and ( D_Title like '%" + searchText1.Text + "%' or D_Content like '%" + searchText1.Text + "%')";
            }
            else
            {
                Where = "D_Recycle=0";
            }
            //if (ddlCategory.SelectedValue != "-1")
            //{
            //    if (!string.IsNullOrEmpty(Where))
            //    {
            //        Where = Where + " and D_ClassID in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            //    }
            //    else
            //    {
            //        Where = " D_Recycle=0 and D_ClassID in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            //    }
            //}
            AspNetPager1.RecordCount = GetSelectList(this.cbxWeb).Count;
            Bind();
        }

        protected void btnDelAll_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < productGrid.Items.Count; i++)
            {
                Label lblPID = productGrid.Items[i].FindControl("lblPID") as Label;
                CheckBox cbSelect = productGrid.Items[i].FindControl("cbSelect") as CheckBox;
                int swid = int.Parse((productGrid.Items[i].FindControl("Del") as LinkButton).CommandArgument.Split(',')[1]);
                if (lblPID != null && cbSelect != null)
                {
                    if (cbSelect.Checked)
                    {
                        int p_id = Convert.ToInt32(lblPID.Text.Trim());
                        bll.UpdateStateNew(p_id, 1,new BLL.SubWeb().GetModel(swid));
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
        protected void cbxWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindClass();
        }
}
}