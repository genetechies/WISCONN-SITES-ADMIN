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

public partial class adminaspx_transzone_TeamList : System.Web.UI.Page
{
    string Where = "1=1";
    BLL.TransTeam bll = new BLL.TransTeam();
    protected void Page_Load(object sender, EventArgs e)
    {
        Helper.CommonFunction.IsAdmin();

        if (!IsPostBack)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            this.cbxWeb.DataSource = new CbxSubwebSingle().CbxTable();
            this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
            this.cbxWeb.DataValueField = "SWID";//绑定的值
            this.cbxWeb.DataBind();
            for (int i = 0; i < cbxWeb.Items.Count; i++)
            {
                cbxWeb.Items[0].Selected = true;
            }
            DDLBind();
            BLL.TransTeam bll = new BLL.TransTeam();
            AspNetPager1.RecordCount = CreateTable().Rows.Count;
            Bind();
            //lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();


            cbxWeb.Enabled = false;
        }
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
        dt.Columns.Add("tid", Type.GetType("System.Int32"));
        dt.Columns.Add("tname", Type.GetType("System.String"));
        dt.Columns.Add("imgpath", Type.GetType("System.String"));
        dt.Columns.Add("NC_ClassName", Type.GetType("System.String"));
        dt.Columns.Add("sort", Type.GetType("System.String"));
        dt.Columns.Add("Database", Type.GetType("System.String"));
        dt.Columns.Add("SwId", Type.GetType("System.String"));
        dt.Columns.Add("D_ID_SwId", Type.GetType("System.String"));

        //創建行
        DataRow dr = null;
        for (int j = 0; j < cbxWeb.Items.Count; j++)
        {
            //if (cbxWeb.SelectedItem != null)
            //{
            //string strwhere = " 1=1 ";
                    try
                    {
                        int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
                        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                        try
                        {
                            if (ddlCategory.SelectedValue != "")
                            {
                                //strwhere = strwhere + "and typeid= '" + ddlCategory.SelectedValue + "'";
                                //if (!string.IsNullOrEmpty(Where))
                                //{
                                //    Where = Where + " and typeid in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                //}
                                //else
                                //{
                                //    Where = " and typeid in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
                                //}
                            }
                           
                        }
                        catch (Exception)
                        {

                        }
                        DataSet ds = bll.GetListByClass(Where, "tid desc", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["tid"] = Convert.ToInt32(ds.Tables[0].Rows[i]["tid"].ToString());
                            dr["tname"] = ds.Tables[0].Rows[i]["tname"].ToString();
                            dr["imgpath"] = ds.Tables[0].Rows[i]["imgpath"].ToString();
                            dr["NC_ClassName"] = ds.Tables[0].Rows[i]["NC_ClassName"].ToString();
                            dr["sort"] = ds.Tables[0].Rows[i]["sort"].ToString();
                            dr["Database"] = cbxWeb.Items[j].Text;
                            dr["SwId"] = cbxWeb.Items[j].Value;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["tid"].ToString() + "|" + cbxWeb.Items[j].Value;
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {

                    }
                

            //}
            //else
            //{
            //    try
            //    {
            //        int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
            //        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
            //        try
            //        {
            //            if (ddlCategory.SelectedValue != "-1")
            //            {
            //                if (!string.IsNullOrEmpty(Where))
            //                {
            //                    Where = Where + " and typeid in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
            //                }
            //                else
            //                {
            //                    Where = " and typeid in(" + Convert.ToInt32(new BLL.NewsClass().GetList("ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0].Rows[0]["ClassID"]) + ")";
            //                }
            //            }
            //        }
            //        catch (Exception)
            //        {

            //        }
            //        DataSet ds = bll.GetListByClass(Where, "tid desc",web);
            //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //        {
            //            dr = dt.NewRow();
            //            dr["tid"] = Convert.ToInt32(ds.Tables[0].Rows[i]["tid"].ToString());
            //            dr["tname"] = ds.Tables[0].Rows[i]["tname"].ToString();
            //            dr["imgpath"] = ds.Tables[0].Rows[i]["imgpath"].ToString();
            //            dr["NC_ClassName"] = ds.Tables[0].Rows[i]["NC_ClassName"].ToString();
            //            dr["sort"] = ds.Tables[0].Rows[i]["sort"].ToString();
            //            dr["Database"] = cbxWeb.Items[j].Text;
            //            dr["SwId"] = cbxWeb.Items[j].Value;
            //            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["tid"].ToString() + "|" + cbxWeb.Items[j].Value;
            //            dt.Rows.Add(dr);
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}
        }

        return dt;
    }


    public void DDLBind()
    {
        //DataView dv = bll.GetListTeamType("").Tables[0].DefaultView;
        //for (int i = 0; i < dv.Count; i++)
        //{
        //    ddlCategory.Items.Add(new ListItem(dv[i]["NC_ClassName"].ToString(), dv[i]["NC_ID"].ToString()));
        //}
        ddlCategory.Items.Clear();

        for (int i = 0; i < this.cbxWeb.Items.Count; i++)
        {

            DataView dv = bll.GetListTeamType("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
            for (int j = 0; j < dv.Count; j++)
            {
                if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["NC_ClassName"].ToString())))
                {
                    ListItem item = new ListItem();
                    item.Text = dv[j]["NC_ClassName"].ToString();
                    item.Value = dv[j]["NC_Id"].ToString();
                    this.ddlCategory.Items.Add(item);
                }
            }
        }


        ddlCategory.Items.Insert(0, new ListItem("", ""));

    }
        


    protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager1.PageSize;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        BLL.TransTeam bll = new BLL.TransTeam();
        DataView dv = CreateTable().DefaultView;
        pds.DataSource = dv;
        rpt_list.DataSource = pds;
        rpt_list.DataBind();

        //FormatData(dv);


    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
        Bind();
    }


    //private void FormatData(DataView dv)
    //{
    //    BLL.TransTeam b = new BLL.TransTeam();
    //    for (int i = 0; i < rpt_list.Items.Count; i++)
    //    {
    //        DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
    //        int maxSortKey = b.GetMaxSortKey("");
    //        for (int j = 1; j <= maxSortKey; j++)
    //        {
    //            ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
    //        }
    //        ddlSortKey.SelectedValue = dv[i]["sort"].ToString();
    //    }
    //    if (dv != null)
    //    {
    //        dv.Dispose();
    //    }
    //}

    //protected void Sub_Click(object sender, EventArgs e)
    //{
    //    if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update))
    //    {
    //        //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
    //        //return;
    //        MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
    //    }

    //    if (string.IsNullOrEmpty(lblNCID.Text))
    //    {
    //        Model.guopic model = new Model.guopic();
    //        model.title = tb_classname.Text;
    //        model.Sort = Convert.ToInt32(lblSortKey.Text);
    //        model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
    //        model.pic = txtPhotoUrl.Text.Trim();
    //        BLL.guopic bll = new BLL.guopic();
    //        //if (bll.Exists(model.title))
    //        //    MessageBox.Show(this, "相同Logo名稱已經存在");
    //        //else
    //        //{
    //        if (!bll.Add(model))
    //        {
    //            MessageBox.Show(this, "添加失敗");
    //        }
    //        else
    //        {
    //            Bind();
    //            Reset();
    //        }
    //        //}
    //    }
    //    else
    //    {
    //        BLL.guopic bll = new BLL.guopic();
    //        Model.guopic model = new Model.guopic();
    //        model.id = Convert.ToInt32(lblNCID.Text);
    //        model.title = tb_classname.Text;
    //        model.Sort = Convert.ToInt32(lblSortKey.Text);
    //        model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
    //        model.pic = "'" + txtPhotoUrl.Text.Trim() + "'";
    //        if (bll.Update(model))
    //        {
    //            Bind();
    //            Reset();
    //        }
    //        else
    //        {
    //            MessageBox.Show(this, "修改失敗");
    //        }
    //    }
    //}





    //protected void btnModfiySortKey_Click(object sender, EventArgs e)
    //{
    //    BLL.TransTeam b = new BLL.TransTeam();
    //    LinkButton btn = sender as LinkButton;
    //    int rowindex = Convert.ToInt32(btn.CommandArgument);

    //    DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
    //    Label lblNCId = rpt_list.Items[rowindex].FindControl("tid") as Label;
    //    Model.TransTeam info = b.GetModel(Convert.ToInt32(lblNCId.Text));
    //    DataView ds = b.GetList("sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

    //    if (info != null && ds.Count == 1)
    //    {
    //        string sql = "update TransTeam set sort=" + ddlSortKey.SelectedValue + " where tid=" + info.tid.ToString();
    //        string sql1 = "update TransTeam set sort=" + info.sort + " where tid=" + ds[0]["tid"].ToString();
    //        ArrayList list = new ArrayList();
    //        list.Add(sql);
    //        list.Add(sql1);
    //        DbHelperOledb.ExecuteSqlTran(list);
    //        Bind();
    //        ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
    //    }
    //}

    //private void Reset()
    //{
    //    BLL.guopic bll = new BLL.guopic();
    //    lblNCID.Text = "";
    //    tb_classname.Text = "";
    //    lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
    //    Button1.Text = "新增";
    //}
    //protected void btnReset_Click(object sender, EventArgs e)
    //{
    //    Reset();
    //}
    
    protected void Del_Click(object sender, CommandEventArgs e)
    {
        if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Delete))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        BLL.TransTeam bll = new BLL.TransTeam();
        Model.TransTeam model = new Model.TransTeam();

        string demoValue = e.CommandName;
        string[] str = demoValue.Split(',');
        int t_id = Convert.ToInt32(str[0].ToString());
        int SwId = Convert.ToInt32(str[1].ToString());
        Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);

        if (bll.Delete(t_id,web))
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

    protected void productGrid_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        BLL.TransTeam bll = new BLL.TransTeam();
        if (e.CommandName == "modfiy")
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            LinkButton link = e.CommandSource as LinkButton;
            int index = Convert.ToInt32(e.CommandArgument);
            Label lblPID = rpt_list.Items[index].FindControl("tid") as Label;
            TextBox sortkey = rpt_list.Items[index].FindControl("txtSort") as TextBox;
            string[] str = sortkey.Text.Split('|');

            if (lblPID != null && str[0] != null)
            {
                int p_id = Convert.ToInt32(lblPID.Text.Trim());
                int SwId = Convert.ToInt32(str[1]);
                Model.SubWeb sw = new BLL.SubWeb().GetModel(SwId);
                Model.TransTeam p = bll.GetModel(p_id,sw);
                int sort = 0;
                try
                {
                    sort = Convert.ToInt32(str[0]);
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
                    bll.UpdaetSortKey(p_id, sort);
                }
                Bind();
            }
        }
    }
    //protected void UpFile_Click(object sender, EventArgs e)
    //{
    //    if (FileUpload1.HasFile)
    //    {
    //        string Name = FileUpload1.FileName;
    //        //文档上传到的固定目录 如果需要修改必须必须3个都修改
    //        string SaveSoft = Server.MapPath("~/UploadFiles/");
    //        string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
    //        string newName = "";
    //        if (Name != "")
    //        {
    //            newName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + "." + Fe;

    //        }
    //        SaveSoft += newName;
    //        if (!Directory.Exists(Server.MapPath("~/UploadFiles/")))
    //        {
    //            Directory.CreateDirectory(Server.MapPath("~/UploadFiles/"));
    //        }
    //        FileUpload1.SaveAs(SaveSoft);
    //        txtPhotoUrl.Text = "UploadFiles/" + newName;
    //        //上传缩略图
    //        AutoThumb.MakeThumbnail(SaveSoft, 160, 140);
    //    }
    //    else
    //    {
    //        ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的圖片');", true);
    //        return;
    //    }
    //}
    protected void Button2_Click(object sender, EventArgs e)   //查询
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Select))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }
        if (!string.IsNullOrEmpty(searchText1.Text) && searchText1.Text.Trim() != "查詢翻譯團隊")
        {
            Where = " ( tname like '%" + searchText1.Text + "%' or descript like '%" + searchText1.Text + "%')";
        }
        else
        {
            Where = " 1=1 ";
        }
        if (ddlCategory.SelectedValue != "")
        {
            if (!string.IsNullOrEmpty(Where))
            {
                Where = Where + " and typeid in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            }
            else
            {
                Where = " and typeid in(" + Convert.ToInt32(ddlCategory.SelectedValue) + ")";
            }
        }
        AspNetPager1.RecordCount = CreateTable().Rows.Count;
        Bind();
    }

    protected void cbxWeb_SelectedIndexChanged(object sender, EventArgs e)
    {
        DDLBind();
    }
}
