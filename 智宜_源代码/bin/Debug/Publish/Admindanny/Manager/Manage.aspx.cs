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
using ZeroStudio.Helper;

namespace ZeroStudio.Web.Admin.Manager
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonFunction.IsAdmin();
            BLL.Manager bll=new BLL.Manager();
            rpt_List.DataSource = bll.GetAll();
            rpt_List.DataBind();
        }

        protected void Del_Click(object sender, CommandEventArgs e)
        {
            BLL.Manager bll = new BLL.Manager();
            if (bll.CountIsOne())
                Response.Write("<script>alert('只有一個管理員，不能刪除！ ');window.location.href='Manage.aspx';</script>");
            else
            {
                int m_id = Convert.ToInt32(e.CommandName);
                if (bll.Delete(m_id))
                    Response.Write("<script>window.location.href='Manage.aspx';</script>");
                else
                    MessageBox.Show(this, "刪除失敗");
            }
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            if (tb_password.Text != tb_password2.Text)
                Response.Write("<script>alert('兩次密碼不一致!');</script>");
            else
            {
                Model.Manager model = new Model.Manager();
                BLL.Manager bll = new BLL.Manager();
                model.AdminName = tb_adminname.Text;
                model.Password = CommonFunction.GetMD5string(tb_password.Text);//5-1-a-s-p-x
                if (bll.Exists(tb_adminname.Text.ToString()) == false)
                {
                    bll.Add(model);
                    Response.Write("<script>window.location.href='Manage.aspx';</script>");
                }
                else
                    Response.Write("<script>alert('管理員名已存在，添加失敗!');</script>");
            }
        }
    }
}
