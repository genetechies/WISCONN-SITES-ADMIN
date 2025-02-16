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
using Helper;

namespace Web.Admin.Manager
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommonFunction.IsAdmin();
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            if (tb_NewPwd.Text.Trim() == tb_ChkPwd.Text.Trim())
            {
                Model.Manager model = new Model.Manager();
                model.AdminName = Session["admin"].ToString();
                model.Password = CommonFunction.GetMD5string(tb_OldPwd.Text);
                BLL.Manager bll = new BLL.Manager();
                if (bll.Exists(model.AdminName, model.Password))
                {
                    model.Password = CommonFunction.GetMD5string(tb_NewPwd.Text);
                    if (bll.Update(model))
                        Response.Write("<script>alert('修改成功！ ');window.location.href='Manage.aspx';</script>");
                    else
                        MessageBox.Show(this,"修改失败");
                }
                else
                {
                    MessageBox.Show(this,"旧密码输入错误");
                }
            }
            else
            {
                MessageBox.Show(this,"密码和确认密码不一致");
            }
        }
    }
}
