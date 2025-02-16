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

public partial class Admin_Friendly_Edit : System.Web.UI.Page
{
    public Friendly_bll bll = new Friendly_bll();
    public Friendly_model model;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Update))
            {
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (!string.IsNullOrEmpty(Request.QueryString["N_id"].ToString()))
            {
                int fid = Convert.ToInt32(Request.QueryString["N_id"].ToString());
                model = bll.GetModel(fid);
                if (model != null)
                {
                    this.txtTitle.Text = model.F_Name;
                    this.txtUrl.Text = model.F_Url;
                    if (model.F_Location == 1)
                    {
                        LRadio1.Checked = true;
                    }
                    else if (model.F_Location == 2)
                    {
                        LRadio2.Checked = true;
                    }
                    else if (model.F_Location == 3)
                    {
                        LRadio3.Checked = true;
                    }
                    else if (model.F_Location == 4)
                    {
                        LRadio4.Checked = true;
                    }
                    else
                    {
                        RadioButton rb = FindControl("LRadio" + model.F_Location.ToString()) as RadioButton;
                        if (rb != null) rb.Checked = true;
                    }
                }
            }
        }
    }

    protected void Sub_Click(object sender, EventArgs e)
    {
        Helper.CommonFunction.IsAdmin();
        if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Update))
        {
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        if (!string.IsNullOrEmpty(Request.QueryString["N_id"].ToString()))
        {
            int fid = Convert.ToInt32(Request.QueryString["N_id"].ToString());
            model = bll.GetModel(fid);
            if (model != null)
            {
                int f_location = 0;
                if (LRadio1.Checked)
                {
                    f_location = 1;
                }
                else if (LRadio2.Checked)
                {
                    f_location = 2;
                }
                else if (LRadio3.Checked)
                {
                    f_location = 3;
                }
                else if (LRadio4.Checked)
                {
                    f_location = 4;
                }
                else if (LRadio5.Checked) f_location = 5;
                else if (LRadio6.Checked) f_location = 6;
                else if (LRadio7.Checked) f_location = 7;


                model.F_Id = fid;
                model.F_Name = txtTitle.Text;
                model.F_Url = txtUrl.Text;
                model.F_Location = f_location;
                model.F_Author = Session["Admin"].ToString();
                model.F_Option = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));
                AspxToHtml tohtml = new AspxToHtml();
                try
                {
                    bll.Update(model);
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
                    else if (f_location == 5)
                    {
                        tohtml.WriteFile("downother.html");
                    }
                    else if (f_location == 6)
                    {
                        tohtml.WriteFile("downindex.html");
                        tohtml.WriteFile("downother.html");
                    }
                    else if (f_location == 7)
                    {
                        tohtml.WriteFile("downother.html");
                        tohtml.WriteFile("downlink.html");
                    }
                    else
                    {
                    }
                    Response.Redirect("Manage.aspx");
                }
                catch (Exception ex)
                {
                    string str = ex.Message;
                    throw;
                }
            }
        }
    }
}
