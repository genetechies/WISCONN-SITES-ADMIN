using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DBUtility;
using Helper;
using System.IO;

public partial class adminaspx_transzone_TeamType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Helper.CommonFunction.IsAdmin();

        if (!IsPostBack)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "teamtype", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            this.cbxWeb.DataSource = new CbxSubwebSingle().CbxTable();
            this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
            this.cbxWeb.DataValueField = "SWID";//绑定的值
            this.cbxWeb.DataBind();
            cbxWeb.Items[0].Selected = true;
            Bind();
            BLL.TransTeam bll = new BLL.TransTeam();
            lblSortKey.Text = (bll.GetMaxSortKeyTeamType("") + 1).ToString();

            cbxWeb.Enabled = false;
        }
    }
    private void Bind()
    {
        BLL.TransTeam bll = new BLL.TransTeam();
        //DataView dv = bll.GetAllTeamType().Tables[0].DefaultView;
        DataView dv = GetSelectList(this.cbxWeb);
        rpt_list.DataSource = dv;
        rpt_list.DataBind();
        FormatData(dv);
    }
    /// <summary>
    /// 獲取不同網站的數據
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public DataView GetSelectList(CheckBoxList list)
    {
        DataTable dt = new DataTable();
        BLL.TransTeam bll = new BLL.TransTeam();
        if (list.SelectedItem != null)
        {

            //------------------創建數據源--------------------------
            //創建表頭
            dt.Columns.Add("NC_Id", Type.GetType("System.Int32"));//編號
            dt.Columns.Add("NC_ClassName", Type.GetType("System.String"));//洲類別名稱
            dt.Columns.Add("NC_Sort", Type.GetType("System.String"));//排序
            dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
            
            dt.Columns.Add("Keywords", Type.GetType("System.String"));
            dt.Columns.Add("Description", Type.GetType("System.String"));

            dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID


            //創建行
            DataRow dr = null;
            DataTable dt2 = new DataTable();
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected)
                {
                    try
                    {
                        dt2 = bll.GetAllTeamType(new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            dr = dt.NewRow();
                            dr["NC_Id"] = dt2.Rows[j]["NC_Id"].ToString();
                            dr["NC_ClassName"] = dt2.Rows[j]["NC_ClassName"].ToString();
                            dr["NC_Sort"] = dt2.Rows[j]["NC_Sort"].ToString();
                            dr["Keywords"] =  dt2.Rows[j]["Keywords"].ToString();
                            dr["Description"] =  dt2.Rows[j]["Description"].ToString();
                            dr["WebSite"] = list.Items[i].Text;
                            dr["Swid"] = list.Items[i].Value;
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
            dt.Columns.Add("NC_Id", Type.GetType("System.Int32"));//編號
            dt.Columns.Add("NC_ClassName", Type.GetType("System.String"));//洲類別名稱
            dt.Columns.Add("NC_Sort", Type.GetType("System.String"));//排序
            dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
            dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID

            //創建行
            DataRow dr = null;
            DataTable dt2 = new DataTable();
            for (int i = 0; i < list.Items.Count; i++)
            {
                try
                {
                    dt2 = bll.GetAllTeamType(new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        dr = dt.NewRow();
                        dr["NC_Id"] = dt2.Rows[j]["NC_Id"].ToString();
                        dr["NC_ClassName"] = dt2.Rows[j]["NC_ClassName"].ToString();
                        dr["NC_Sort"] = dt2.Rows[j]["NC_Sort"].ToString();
                        dr["Keywords"] =  dt2.Rows[j]["Keywords"].ToString();
                        dr["Description"] =  dt2.Rows[j]["Description"].ToString();
                        dr["WebSite"] = list.Items[i].Text;
                        dr["Swid"] = list.Items[i].Value;
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
    private void FormatData(DataView dv)
    {
        BLL.TransTeam b = new BLL.TransTeam();
        //for (int i = 0; i < rpt_list.Items.Count; i++)
        //{
        //    DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
        //    int maxSortKey = b.GetMaxSortKeyTeamType("");
        //    for (int j = 0; j <= maxSortKey; j++)
        //    {
        //        ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
        //    }
        //    ddlSortKey.SelectedValue = dv[i]["NC_Sort"].ToString();
        //}
        if (dv != null)
        {
            dv.Dispose();
        }
    }
    protected void btnModfiySortKey_Click(object sender, EventArgs e)
    {
        BLL.TransTeam b = new BLL.TransTeam();
        LinkButton btn = sender as LinkButton;
        int rowindex = Convert.ToInt32(btn.CommandArgument);

        DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
        Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
        Model.guoclass info = b.GetModelTeamType(Convert.ToInt32(lblNCId.Text));
        DataView ds = b.GetList("nc_Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

        if (info != null && ds.Count == 1)
        {
            string sql = "update TransteamType set nc_Sort=" + ddlSortKey.SelectedValue + " where nc_Id=" + info.Id.ToString();
            string sql1 = "update TransteamType set nc_Sort=" + info.Sort + " where nc_Id=" + ds[0]["nc_Id"].ToString();
            ArrayList list = new ArrayList();
            list.Add(sql);
            list.Add(sql1);
            DbHelperOledb.ExecuteSqlTran(list);
            Bind();
            ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
        }
    }
    protected void Sub_Click(object sender, EventArgs e)
    {
        if (!Utils.IsRight(Session["Admin"].ToString(), "teamtype", RightStatus.Update))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        if (string.IsNullOrEmpty(lblNCID.Text))
        {
            Model.guoclass model = new Model.guoclass();
            model.ClassName = tb_classname.Text;
            model.Sort = Convert.ToInt32(lblSortKey.Text);
            model.Keywords = tbkeywords.Text;
            model.Description = tbDescrition.Text;
            BLL.TransTeam bll = new BLL.TransTeam();
            if (bll.ExistsTeamType(model.ClassName))
                MessageBox.Show(this, "項目已經存在");
            else
            {
                //if (bll.AddTeamType(model) < 1)
                //{
                //    MessageBox.Show(this, "添加失敗");
                //}
                //else
                //{
                //    Bind();
                //    Reset();
                //}
                for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                {
                    if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                    {
                        if (i > 0)
                        {
                            bll.AddTeamType(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                        }
                    }
                    else
                    {
                        if (this.cbxWeb.Items[i].Selected)
                        {
                            bll.AddTeamType(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                            //this.cbxWeb.Items[i].Selected = false;
                        }
                    }
                }
                //this.cbxWeb.Items[0].Selected = true;
                Bind();
                Reset();
            }
        }
        else
        {
            BLL.TransTeam bll = new BLL.TransTeam();
            Model.guoclass model = new Model.guoclass();
            model.Id = Convert.ToInt32(lblNCID.Text);
            model.ClassName = tb_classname.Text;
            model.Sort = Convert.ToInt32(lblSortKey.Text);
            model.Keywords = tbkeywords.Text;
            model.Description = tbDescrition.Text;
            //if (bll.UpdateTeamType(model))
            //{
            //    Bind();
            //    Reset();
            //}
            //else
            //{
            //    MessageBox.Show(this, "修改失敗");
            //}
            for (int i = 0; i < this.cbxWeb.Items.Count; i++)
            {
                if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                {
                    if (i > 0)
                    {
                        bll.UpdateTeamType(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                        
                    }
                }
                else
                {
                    if (this.cbxWeb.Items[i].Selected)
                    {
                        bll.UpdateTeamType(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                        //this.cbxWeb.Items[i].Selected = false;
                    }
                }
            }
            //this.cbxWeb.Items[0].Selected = false;
            Bind();
            Reset();
        }
    }
    private void Reset()
    {
        BLL.TransTeam bll = new BLL.TransTeam();
        lblNCID.Text = "";
        tb_classname.Text = "";
        tbkeywords.Text = "";
        tbDescrition.Text = "";
        lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
        Button1.Text = "新增";
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
    }
    protected void btnModfiy_Click(object sender, EventArgs e)
    {
        if (!Utils.IsRight(Session["Admin"].ToString(), "teamtype", RightStatus.Update))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        LinkButton btn = sender as LinkButton;
        int nc_id = Convert.ToInt32(btn.CommandArgument);
        BLL.TransTeam bll = new BLL.TransTeam();
        Model.guoclass model = bll.GetModelTeamType(nc_id, new BLL.SubWeb().GetModel(Convert.ToInt32(btn.CommandName)));
        lblNCID.Text = nc_id.ToString();
        tb_classname.Text = model.ClassName;
        lblSortKey.Text = model.Sort.ToString();
        tbkeywords.Text = model.Keywords;
        tbDescrition.Text = model.Description;
        Button1.Text = "修改";

    }
    protected void Del_Click(object sender, CommandEventArgs e)
    {
        if (!Utils.IsRight(Session["Admin"].ToString(), "teamtype", RightStatus.Delete))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        BLL.TransTeam bll = new BLL.TransTeam();
        Model.guoclass model = new Model.guoclass();
        model.Id = Convert.ToInt32(e.CommandName);
        if (bll.DeleteTeamType(model.Id,new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))))
            Bind();
        else
            MessageBox.Show(this, "刪除失敗");
    }
    protected void rpt_list_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            //LinkButton btn = e.Item.FindControl("btnModfiySortKey") as LinkButton;
            //btn.CommandArgument = e.Item.ItemIndex.ToString();
        }
    }
}
