using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Helper;
using System.Data;
using System.Collections;

public partial class adminaspx_news_NewsManage : System.Web.UI.Page
{
    BLL.newsdata bll = new BLL.newsdata();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Select))
            {

                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
            cbxWeb.DataTextField = "SWName";//绑定的字段名  
            cbxWeb.DataValueField = "SWID";//绑定的值
            cbxWeb.DataBind();

            cbxWeb.Items[0].Selected = true;
            cbxWeb.Enabled = false;

            Where = "D_Recycle=0";   //0不在回收站 
            BindClass();
            DataTable dt=CreateTable();
            Bind(dt);
            AspNetPager1.RecordCount = dt.Rows.Count;
        }
    }
    //private void BindClass()
    //{
    //    BLL.NewsClass bll = new BLL.NewsClass();
    //    ddlCategory.Items.Clear();
    //    if (this.cbxWeb.SelectedItem != null)
    //    {
    //        if (!this.cbxWeb.Items[0].Selected)
    //        {
    //            for (int i = 0; i < this.cbxWeb.Items.Count; i++)
    //            {
    //                if (this.cbxWeb.Items[i].Selected)
    //                {
    //                    DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
    //                    for (int j = 0; j < dv.Count; j++)
    //                    {
    //                        if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
    //                        {
    //                            ListItem item = new ListItem();
    //                            item.Text = dv[j]["ClassName"].ToString();
    //                            this.ddlCategory.Items.Add(item);
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        else
    //        {
    //            for (int i = 1; i < this.cbxWeb.Items.Count; i++)
    //            {

    //                DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
    //                for (int j = 0; j < dv.Count; j++)
    //                {
    //                    if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
    //                    {
    //                        ListItem item = new ListItem();
    //                        item.Text = dv[j]["ClassName"].ToString();
    //                        this.ddlCategory.Items.Add(item);
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}

    private void BindClass()
    {
        BLL.NewsClass bll = new BLL.NewsClass();
       DataSet dt= bll.GetList("", new CbxSubweb().GetWebModel());
       if (dt.Tables.Count > 0)
       {
           ddlCategory.DataSource = dt.Tables[0];
           ddlCategory.DataTextField = "ClassName";
           ddlCategory.DataValueField = "ClassID";
           ddlCategory.DataBind();
       }


        /*
        ArrayList list = new ArrayList();
        ddlCategory.Items.Clear();
        int selectCount = 0;
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
                            if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                            {
                                ListItem item = new ListItem();
                                item.Text = dv[j]["ClassName"].ToString();
                                this.ddlCategory.Items.Add(item);
                            }
                            else
                            {
                                if (!list.Contains(new ListItem(dv[j]["ClassName"].ToString(), "")))
                                {
                                    for (int k = 0; k < 2; k++)
                                    {
                                        ListItem item = new ListItem();
                                        item.Text = dv[j]["ClassName"].ToString();
                                        list.Add(item);
                                    }
                                }
                                else
                                {
                                    ListItem item = new ListItem();
                                    item.Text = dv[j]["ClassName"].ToString();
                                    item.Value = "";
                                    list.Add(item);
                                }
                            }
                        }
                        selectCount++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                {

                    DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
                    for (int j = 0; j < dv.Count; j++)
                    {
                        if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                        {
                            ListItem item = new ListItem();
                            item.Text = dv[j]["ClassName"].ToString();
                            this.ddlCategory.Items.Add(item);
                        }
                        else
                        {
                            if (!list.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                            {
                                for (int k = 0; k < 2; k++)
                                {
                                    ListItem item = new ListItem();
                                    item.Text = dv[j]["ClassName"].ToString();
                                    list.Add(item);
                                }
                            }
                            else
                            {
                                ListItem item = new ListItem();
                                item.Text = dv[j]["ClassName"].ToString();
                                list.Add(item);
                            }
                        }
                    }

                }
            }
        }

        //计算重复
        
        if (selectCount == 0)
        {
            int listCount = 1;
            this.ddlCategory.Items.Clear();
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].ToString() == list[j].ToString())
                    {
                        listCount++;
                    }
                }
                if (listCount == cbxWeb.Items.Count - 1)
                {
                    this.ddlCategory.Items.Add(list[i] as ListItem);
                }
                listCount = 1;
            }
        }
        else if (selectCount > 1)
        {
            int listCount = 1;
            this.ddlCategory.Items.Clear();
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].ToString() == list[j].ToString())
                    {
                        listCount++;
                    }
                }
                if (listCount == selectCount)
                {
                    this.ddlCategory.Items.Add(list[i] as ListItem);
                }
                listCount = 1;
            }
        }
         * */

        //add kong
        ddlCategory.Items.Insert(0, new ListItem("", ""));

    }

    protected void Bind(DataTable dt)
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager1.PageSize;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        pds.DataSource = dt.DefaultView;// bll.GetListByClass(Where, "D_ID desc").Tables[0].DefaultView;
        productGrid.DataSource = pds;
        productGrid.DataBind();
    }

    public DataTable CreateTable()
    {
        DataTable dt = new DataTable();
        int a;
        if (Session["Admin"].ToString().ToLower() == "admin")
        {
            a = 1;
        }
        else
        {
            a = 0;
        }
        //------------------創建數據源--------------------------
        //創建表頭
        dt.Columns.Add("D_ID", Type.GetType("System.Int32"));
        dt.Columns.Add("D_Title", Type.GetType("System.String"));
        dt.Columns.Add("ClassName", Type.GetType("System.String"));
        dt.Columns.Add("D_Editor", Type.GetType("System.String"));
        dt.Columns.Add("D_Time", Type.GetType("System.String"));
        dt.Columns.Add("OrderID", Type.GetType("System.Int32"));
        dt.Columns.Add("Database", Type.GetType("System.String"));
        dt.Columns.Add("SwId", Type.GetType("System.String"));
        dt.Columns.Add("D_ID_SwId", Type.GetType("System.String"));
        //創建行
        DataRow dr = null;
        a = 0;
        for (int j = a; j < cbxWeb.Items.Count; j++)
            {
                if (cbxWeb.SelectedItem != null)
                {
                    if (cbxWeb.Items[0].Selected || cbxWeb.Items[j].Selected)
                    {
                        try
                        {
                            int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
                            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                            try
                            {
                                if (ddlCategory.SelectedValue != "")
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
                            DataSet ds = bll.GetListByClass(Where, "D_ID desc", web);
                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                dr = dt.NewRow();
                                dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                                dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                                dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                                dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                                dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
                                dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
                                dr["Database"] = cbxWeb.Items[j].Text;
                                dr["SwId"] = cbxWeb.Items[j].Value;
                                dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + cbxWeb.Items[j].Value;
                                dt.Rows.Add(dr);
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                }
                else
                {
                    try
                    {
                        int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
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
                        DataSet ds = bll.GetListByClass(Where, "D_ID desc", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                            dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                            dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                            dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                            dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
                            dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
                            dr["Database"] = cbxWeb.Items[j].Text;
                            dr["SwId"] = cbxWeb.Items[j].Value;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + cbxWeb.Items[j].Value;
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
        }

        return dt;
    }


    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        Bind(CreateTable());
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
        string demoValue = btn.CommandArgument;
        string[] str =demoValue.Split('|');
        int p_id = Convert.ToInt32(str[0].ToString());
        int SwId = Convert.ToInt32(str[1].ToString());
        Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);

        bll.UpdateState(p_id, 1,web);
        Bind(CreateTable());
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

            int SwID = Convert.ToInt32((productGrid.Items[index].FindControl("txtSwId") as TextBox).Text);
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);

            if (lblPID != null && sortkey != null)
            {
                int p_id = Convert.ToInt32(lblPID.Text.Trim());
                Model.newsdata p = bll.GetModel(p_id,web);
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
                    bll.UpdateSortKey(p_id, sort);
                }
                Bind(CreateTable());
            }
        }
    }

    protected void productGrid_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            //TextBox sortkey = e.Item.FindControl("txtParentID") as TextBox;
            //LinkButton modfiy = e.Item.FindControl("btnModfiySortKey") as LinkButton;
            //if (modfiy != null && sortkey != null)
            //{
            //    modfiy.Attributes.Add("onclick", "return validText('" + sortkey.ClientID + "');");
            //    modfiy.CommandArgument = e.Item.ItemIndex.ToString();
            //}
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
        if (ddlCategory.SelectedValue != "")
        {
            if (!string.IsNullOrEmpty(Where))
            {
                Where = Where + " and D_ClassID in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            }
            else
            {
                Where = " D_Recycle=0 and D_ClassID in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            }
        }
        //if (txtInput.Text !="")
        //{
        //    Where += " AND D_Editor like '%" + txtInput.Text + "%'";
        //}
        //if (!String.IsNullOrEmpty(txtModfiy.Text))
        //{
        //    Where += " AND D_Editor like '%" + txtModfiy.Text + "%'";
        //}
        AspNetPager1.RecordCount = CreateTable().Rows.Count;
        Bind(CreateTable());
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
            int SwID = Convert.ToInt32((productGrid.Items[i].FindControl("txtSwId") as TextBox).Text);
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);

            Label lblPID = productGrid.Items[i].FindControl("lblPID") as Label;
            CheckBox cbSelect = productGrid.Items[i].FindControl("cbSelect") as CheckBox;
            if (lblPID != null && cbSelect != null)
            {
                if (cbSelect.Checked)
                {
                    int p_id = Convert.ToInt32(lblPID.Text.Trim());
                    bll.UpdateState(p_id, 1,web);
                }
            }
        }
        Bind(CreateTable());
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