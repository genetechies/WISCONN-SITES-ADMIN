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
using DBUtility;
using Helper;

namespace Web.Admin.News_Class
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();

            if (!IsPostBack)
            {
                if (!Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                //DDLBind();
                Bind();
                BLL.linyuclass bll = new BLL.linyuclass();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            }
        }

        //public void DDLBind()
        //{
        //    BLL.guoclass bll = new BLL.guoclass();
        //    ddl_guoclass.DataSource = bll.GetAll();
        //    ddl_guoclass.DataTextField = "NC_ClassName";
        //    ddl_guoclass.DataValueField = "NC_Id";
        //    ddl_guoclass.DataBind();
        //}

        private void Bind()
        {
            BLL.linyuclass bll = new BLL.linyuclass();
            DataView dv = bll.GetAll().Tables[0].DefaultView;
            rpt_list.DataSource = dv;
            rpt_list.DataBind();
            FormatData(dv);
        }


        private void FormatData(DataView dv)
        {
            BLL.linyuclass b = new BLL.linyuclass();
            for (int i = 0; i < rpt_list.Items.Count; i++)
            {
                DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
                int maxSortKey = b.GetMaxSortKey("");
                for (int j = 0; j <= maxSortKey; j++)
                {
                    ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }
                ddlSortKey.SelectedValue = dv[i]["Sort"].ToString();
            }
            if (dv != null)
            {
                dv.Dispose();
            }
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text))
            {
                Model.linyuclass model = new Model.linyuclass();
                model.ClassName = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                //model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.guoclassid = 0;
                BLL.linyuclass bll = new BLL.linyuclass();
                if (bll.Exists(model.ClassName))
                    MessageBox.Show(this, "洲類別名稱已經存在");
                else
                {
                    if (bll.Add(model) < 1)
                    {
                        MessageBox.Show(this, "添加失敗");
                    }
                    else
                    {
                        Bind();
                        Reset();
                    }
                }
            }
            else
            {
                BLL.linyuclass bll = new BLL.linyuclass();
                Model.linyuclass model = new Model.linyuclass();
                model.id = Convert.ToInt32(lblNCID.Text);
                model.ClassName = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                //model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.guoclassid = 0;
                if (bll.Update(model))
                {
                    Bind();
                    Reset();
                }
                else
                {
                    MessageBox.Show(this, "修改失敗");
                }
            }
        }

















        protected void btnModfiySortKey_Click(object sender, EventArgs e)
        {
            BLL.linyuclass b = new BLL.linyuclass();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.linyuclass info = b.GetModel(Convert.ToInt32(lblNCId.Text));
            //DataView ds =b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            //if (info != null && ds.Count == 1) {
            if (info != null)
            {
                string sql = "update linyuclass set Sort=" + ddlSortKey.SelectedValue + " where id=" + info.id.ToString();
                //string sql1 = "update linyuclass set Sort=" + info.Sort + " where id=" + ds[0]["id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                //list.Add(sql1);
                DbHelperOledb.ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }

        private void Reset()
        {
            BLL.linyuclass bll = new BLL.linyuclass();
            lblNCID.Text = "";
            tb_classname.Text = "";
            lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            Button1.Text = "新增";
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        protected void btnModfiy_Click(object sender, EventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int nc_id = Convert.ToInt32(btn.CommandArgument);
            BLL.linyuclass bll = new BLL.linyuclass();
            Model.linyuclass model = bll.GetModel(nc_id);
            lblNCID.Text = nc_id.ToString();
            tb_classname.Text = model.ClassName;
            lblSortKey.Text = model.Sort.ToString();
            //ddl_guoclass.SelectedValue = model.guoclassid.ToString();
            Button1.Text = "修改";

        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            BLL.linyuclass bll = new BLL.linyuclass();
            Model.linyuclass model = new Model.linyuclass();
            model.id = Convert.ToInt32(e.CommandName);

            if (bll.Delete(model.id))
            {
                BLL.linyuxinxi bllx = new BLL.linyuxinxi();
                DataTable dt = bllx.GetList(" linyuclassid=" + model.id).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        bllx.Delete(Convert.ToInt32(dt.Rows[i]["id"].ToString()));
                    }
                }
                Bind();
            }
            else
                MessageBox.Show(this, "刪除失敗");
        }
        protected void rpt_list_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                LinkButton btn = e.Item.FindControl("btnModfiySortKey") as LinkButton;
                btn.CommandArgument = e.Item.ItemIndex.ToString();
            }
        }
    }
}
