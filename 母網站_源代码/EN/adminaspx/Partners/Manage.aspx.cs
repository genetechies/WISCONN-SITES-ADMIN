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
using System.Xml.Linq;
using Helper;
using System.Text;
using System.IO;

public partial class Admin_Friendly_Manage : System.Web.UI.Page
{
    public Partners_bll bll = new Partners_bll();
    StreamReader sr;
    public string str = "";
    public string result = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();    
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Select))
            {
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
            cbxWeb.Enabled = false;
            AspNetPager1.RecordCount = bll.Count();
            Where = "";
            Bind();

        }

    }

    protected void Bind()
    {
        PagedDataSource pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = AspNetPager1.PageSize;
        pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
        pds.DataSource = CreateTable().DefaultView;
        rpt_news.DataSource = pds;
        rpt_news.DataBind();
        if (CreateTable() != null && CreateTable().Rows.Count > 0)
        {
        	WriteContentToDiv("downindex.html");
	        WriteContentToDiv("downlink.html");
        	WriteContentToDiv("downother.html");
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
        dt.Columns.Add("F_Id", Type.GetType("System.Int32"));
        dt.Columns.Add("F_Location", Type.GetType("System.String"));
        dt.Columns.Add("F_Name", Type.GetType("System.String"));
        dt.Columns.Add("F_Url", Type.GetType("System.String"));
        dt.Columns.Add("F_Author", Type.GetType("System.String"));
        dt.Columns.Add("F_SortKey", Type.GetType("System.Int32"));
        dt.Columns.Add("F_OptionTime", Type.GetType("System.String"));
        dt.Columns.Add("database", Type.GetType("System.String"));
        dt.Columns.Add("SwId", Type.GetType("System.String"));
        //創建行
        DataRow dr = null;
        for (int j = 0; j < cbxWeb.Items.Count; j++)
        {
            if (cbxWeb.SelectedItem != null)
            {
                if (cbxWeb.Items[j].Selected)
                {
                    try
                    {
                        int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
                        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                        DataSet ds = bll.GetList(Where, web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["F_Id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["F_Id"].ToString());
                            dr["F_Location"] = ds.Tables[0].Rows[i]["F_Location"].ToString();
                            dr["F_Name"] = ds.Tables[0].Rows[i]["F_Name"].ToString();
                            dr["F_Url"] = ds.Tables[0].Rows[i]["F_Url"].ToString();
                            dr["F_Author"] = ds.Tables[0].Rows[i]["F_Author"].ToString();
                            dr["F_SortKey"] = ds.Tables[0].Rows[i]["F_SortKey"].ToString();
                            dr["F_OptionTime"] = ds.Tables[0].Rows[i]["F_OptionTime"].ToString();
                            dr["Database"] = cbxWeb.Items[j].Text;
                            dr["SwId"] = cbxWeb.Items[j].Value;
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
                    DataSet ds = bll.GetList(Where, web);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dr = dt.NewRow();
                        dr["F_Id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["F_Id"].ToString());
                        dr["F_Location"] = ds.Tables[0].Rows[i]["F_Location"].ToString();
                        dr["F_Name"] = ds.Tables[0].Rows[i]["F_Name"].ToString();
                        dr["F_Url"] = ds.Tables[0].Rows[i]["F_Url"].ToString();
                        dr["F_Author"] = ds.Tables[0].Rows[i]["F_Author"].ToString();
                        dr["F_SortKey"] = ds.Tables[0].Rows[i]["F_SortKey"].ToString();
                        dr["F_OptionTime"] = ds.Tables[0].Rows[i]["F_OptionTime"].ToString();
                        dr["Database"] = cbxWeb.Items[j].Text;
                        dr["SwId"] = cbxWeb.Items[j].Value;
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



    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Where = " 1=1 ";
        if (!string.IsNullOrEmpty(txtTitle.Text.Trim().ToString()))
            Where += " and F_Name like '%" + txtTitle.Text.Trim().ToString() + "%'";
        //if (!string.IsNullOrEmpty(txtInput.Text.Trim().ToString()))
        //    Where += " and F_Author like '%" + txtInput.Text.Trim().ToString() + "%'";
        //if (!string.IsNullOrEmpty(txtModfiy.Text.Trim().ToString()))
        //    Where += " F_Author like '%" + txtModfiy.Text.Trim().ToString() + "%'";
        Bind();
    }

    protected void btnDelAll_Click(object sender, CommandEventArgs e)
    {
        Helper.CommonFunction.IsAdmin();

        if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Delete))
        {
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }
        for (int i = 0; i < rpt_news.Items.Count; i++)
        {
            CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
            Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
            Label lblLCTION = rpt_news.Items[i].FindControl("lblLCTION") as Label;
            if (cbSelect != null && lblNId != null)
            {
                if (cbSelect.Checked)
                {
                    string[] str = lblLCTION.Text.Trim().Split('|');
                    int SwId = Convert.ToInt32(str[1]);
                    Model.SubWeb sw = new BLL.SubWeb().GetModel(SwId);

                    bll.Delete(lblNId.Text.Trim().ToString(), sw);
                }
            }

        }
        AspxToHtml tohtml = new AspxToHtml();
        tohtml.WriteFile("downindex.html");
        tohtml.WriteFile("downother.html");
        tohtml.WriteFile("downlink.html");
        Bind();
    }
    protected void Del_Click(object sender, CommandEventArgs e)
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Delete))
        {
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }
        string fid = e.CommandArgument.ToString();
        string[] str = e.CommandArgument.ToString().Split('|');
        string f_id = str[0];
        int SwId = Convert.ToInt32(str[1]);
        Model.SubWeb sw = new BLL.SubWeb().GetModel(SwId);

        bll.Delete(f_id, sw);
        AspxToHtml tohtml = new AspxToHtml();
        tohtml.WriteFile("downindex.html");
        tohtml.WriteFile("downother.html");
        tohtml.WriteFile("downlink.html");
        Bind();
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
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

    public string GetLocationName(string location)
    {
        switch (location)
        {
            case "1":
                result = "整站";
                break;
            case "2":
                result = "友好連結";
                break;
            case "3":
                result = "首頁";
                 break;
            case "4":
                result = "首頁、友好連結";
                break;
            case "5": result = "其它頁"; break;
            case "6": result = "其它頁及首頁"; break;
            case "7": result = "其它頁及友好連結"; break;
            default:
                result = "";
                break;
        }
        return result;
    }

    protected void rpt_news_ItemCommand(object source, RepeaterCommandEventArgs e)
    {   
        if (e.CommandName == "modfiy")
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Update))
            {
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            LinkButton link = e.CommandSource as LinkButton;
            int index = Convert.ToInt32(e.CommandArgument);
            Label lblNID = rpt_news.Items[index].FindControl("lblNID") as Label;
            Label lblLCTION = rpt_news.Items[index].FindControl("lblLCTION") as Label;
            TextBox sortkey = rpt_news.Items[index].FindControl("txtParentID") as TextBox;
            AspxToHtml tohtml = new AspxToHtml();
            if (lblNID != null && sortkey != null)
            {
                int f_id = Convert.ToInt32(lblNID.Text.Trim());
                string[] str = lblLCTION.Text.Trim().Split('|');
                int f_location = Convert.ToInt32(str[0]);
                int SwId = Convert.ToInt32(str[1]);
                Model.SubWeb sw = new BLL.SubWeb().GetModel(SwId);
                Partners_model model = bll.GetModel(f_id,sw);
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
                if (model.F_SortKey != sort)
                {
                    bll.UpdateSortKey(f_id, sort);
                }
                if (f_location == 1)
                {
                    tohtml.WriteFile("downindex.html");
                    tohtml.WriteFile("downother.html");
                    tohtml.WriteFile("downlink.html");
                }
                else if (f_location == 2)
                {
                    tohtml.WriteFile("downlink.html");
                }
                else if (f_location == 3)
                {
                    tohtml.WriteFile("downindex.html");
                }
                else if (f_location == 4)
                {
                    tohtml.WriteFile("downindex.html");
                    tohtml.WriteFile("downlink.html");
                }
                else
                {
                }
                Bind();
            }
        }
    }

    protected void rpt_news_ItemDataBound(object sender, RepeaterItemEventArgs e)
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

    public void WriteContentToDiv(string htmlName)
    {
        Encoding code = Encoding.GetEncoding("utf-8");
        //读取html文件
        string temp = "";
        if (htmlName == "downindex.html")
            temp = HttpContext.Current.Server.MapPath("../../newspages/downindex.html");
        else if (htmlName == "downother.html")
            temp = HttpContext.Current.Server.MapPath("../../newspages/downother.html");
        else if (htmlName == "downlink.html")
            temp = HttpContext.Current.Server.MapPath("../../newspages/downlink.html");

        try
        {
            sr = new StreamReader(temp, code);
            str = sr.ReadToEnd();
            sr.Close();
        }
        catch (Exception)
        {
            sr.Close();
            throw;
        }
        if (htmlName == "downindex.html")
            IndexDiv.InnerHtml = str;
        else if (htmlName == "downlink.html")
            LinkDiv.InnerHtml = str;
        else if (htmlName == "downother.html")
            OtherDiv.InnerHtml = str;
    }
}
