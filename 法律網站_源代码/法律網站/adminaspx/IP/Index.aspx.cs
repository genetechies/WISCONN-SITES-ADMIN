using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Helper;

public partial class adminaspx_IP_Index : System.Web.UI.Page
{
    BLL.Bll_DisableIP bll = new BLL.Bll_DisableIP();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "guest", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            AspNetPager1.RecordCount = bll.Count();
            Bind();
        }
    }
        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            
            pds.DataSource = bll.GetAllList().Tables[0].DefaultView;
            

            rpt_list.DataSource = pds;
            rpt_list.DataBind();
            //for (int i = 0; i < rpt_list.Items.Count; i++) {
            //    Label lblIsFinish = rpt_list.Items[i].FindControl("lblIsFinish") as Label;
            //    DropDownList ddlFinish = rpt_list.Items[i].FindControl("ddlFinish") as DropDownList;
            //    if (lblIsFinish != null && ddlFinish != null) {
            //        ddlFinish.SelectedValue = lblIsFinish.Text.Trim();
            //    }
            //}
        }


        protected void Del_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "guest", RightStatus.Delete))
            {
                //    ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //    return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string id = e.CommandName;
            bll.Delete(Convert.ToInt32(id));
            Bind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    
}