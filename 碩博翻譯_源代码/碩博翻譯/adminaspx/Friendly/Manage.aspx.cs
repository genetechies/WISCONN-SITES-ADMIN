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
    public Friendly_bll bll = new Friendly_bll();
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
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

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
        pds.DataSource = bll.GetList(Where).Tables[0].DefaultView;
        rpt_news.DataSource = pds;
        rpt_news.DataBind();
	if (bll.GetList(Where).Tables[0] != null && bll.GetList(Where).Tables[0].Rows.Count > 0)
        {
        	WriteContentToDiv("downindex.html");
        	WriteContentToDiv("downlink.html");
        	WriteContentToDiv("downother.html");
	}
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Where = " 1=1 ";
        if (!string.IsNullOrEmpty(txtTitle.Text.Trim().ToString()))
            Where += " and F_Name like '%" + txtTitle.Text.Trim().ToString() + "%'";
        if (!string.IsNullOrEmpty(txtInput.Text.Trim().ToString()))
            Where += " and F_Author like '%" + txtInput.Text.Trim().ToString() + "%'";
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
            if (cbSelect != null && lblNId != null)
            {
                if (cbSelect.Checked)
                {
                    bll.Delete(lblNId.Text.Trim().ToString());
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
        bll.Delete(fid);
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
                int f_location = Convert.ToInt32(lblLCTION.Text.Trim());
                Friendly_model model = bll.GetModel(f_id);
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
            case "5": result = "其它頁";break;
            case "6": result = "其它頁及首頁";break;
            case "7": result = "其它頁及友好連結";break;
            default:
                result = "";
                break;
        }
        return result;
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
