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
        BLL.linyuxinxi bll = new BLL.linyuxinxi();
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();

            if (!IsPostBack)
            {
                if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                DDLBind();
                AspNetPager1.RecordCount = bll.CountByClass(" hst=0 ");
                Bind();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            }
        }

        public void DDLBind()
        {
            BLL.linyuclass bll = new BLL.linyuclass();
            ddl_linyuclass.DataSource = bll.GetAll();
            ddl_linyuclass.DataTextField = "ClassName";
            ddl_linyuclass.DataValueField = "id";
            ddl_linyuclass.DataBind();
        }

        private void Bind()
        {
            BLL.linyuxinxi bll = new BLL.linyuxinxi();
            DataView dv = bll.GetList(" hst=0 ").Tables[0].DefaultView;
            //rpt_list.DataSource = dv;
            //rpt_list.DataBind();


            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = dv;
            rpt_list.DataSource = pds;
            rpt_list.DataBind();

            FormatData(dv);
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }


        private void FormatData(DataView dv)
        {
            BLL.linyuxinxi b = new BLL.linyuxinxi();
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text))
            {
                Model.linyuxinxi model = new Model.linyuxinxi();
                model.title = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.linyuclassid = Convert.ToInt32(ddl_linyuclass.SelectedValue);
                /*
                if (chb_C_show.Checked)
                {
                    model.C_show = 1;
                }
                else
                {
                    model.C_show = 0;
                }
                 */
                BLL.linyuxinxi bll = new BLL.linyuxinxi();
                if (bll.Exists(model.title))
                    MessageBox.Show(this, "名稱已經存在");
                else
                {
                    if (!bll.Add(model))
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
                BLL.linyuxinxi bll = new BLL.linyuxinxi();
                Model.linyuxinxi model = new Model.linyuxinxi();
                model.id = Convert.ToInt32(lblNCID.Text);
                model.title = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.linyuclassid = Convert.ToInt32(ddl_linyuclass.SelectedValue);
               /* if (chb_C_show.Checked)
                {
                    model.C_show = 1;
                }
                else
                {
                    model.C_show = 0;
                }*/
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

        protected void btnDelAll_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_list.Items.Count; i++)
            {
                Label lblPID = rpt_list.Items[i].FindControl("lblPID") as Label;
                CheckBox cbSelect = rpt_list.Items[i].FindControl("cbSelect") as CheckBox;
                if (lblPID != null && cbSelect != null)
                {
                    if (cbSelect.Checked)
                    {
                        BLL.linyuxinxi bll = new BLL.linyuxinxi();
                        int p_id = Convert.ToInt32(lblPID.Text.Trim());
                        //bll.Delete(p_id);
                        bll.UpdateState(p_id, 1);
                    }
                }
            }
            Bind();
        }






        protected void btnModfiySortKey_Click(object sender, EventArgs e)
        {
            BLL.linyuxinxi b = new BLL.linyuxinxi();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.linyuxinxi info = b.GetModel(Convert.ToInt32(lblNCId.Text));
            DataView ds = b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            if (info != null && ds.Count == 1)
            {
                string sql = "update linyuxinxi set Sort=" + ddlSortKey.SelectedValue + " where id=" + info.id.ToString();
                string sql1 = "update linyuxinxi set Sort=" + info.Sort + " where id=" + ds[0]["id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                list.Add(sql1);
                DbHelperOledb.ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }

        private void Reset()
        {
            BLL.linyuxinxi bll = new BLL.linyuxinxi();
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int nc_id = Convert.ToInt32(btn.CommandArgument);
            BLL.linyuxinxi bll = new BLL.linyuxinxi();
            Model.linyuxinxi model = bll.GetModel(nc_id);
            lblNCID.Text = nc_id.ToString();
            tb_classname.Text = model.title;
            lblSortKey.Text = model.Sort.ToString();

            ddl_linyuclass.SelectedValue = model.linyuclassid.ToString();

            //if (model.C_show == 1)
            //{
            //    chb_C_show.Checked = true;
            //}
            //else
            //{
            //    chb_C_show.Checked = false;
            //}
            Button1.Text = "修改";

        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            BLL.linyuxinxi bll = new BLL.linyuxinxi();
            Model.linyuxinxi model = new Model.linyuxinxi();
            model.id = Convert.ToInt32(e.CommandName);
            //if (bll.Delete(model.id))
            if (bll.UpdateState(model.id, 1))
                Bind();
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

        protected void chb_C_show_CheckedChanged(object sender, EventArgs e)
        {
            //if (chb_C_show.Checked)
            //{
            //    int num = 0;
            //    num = new BLL.linyuxinxi().Count(" linyuclassid=" + ddl_linyuclass.SelectedValue + " and C_show=1 ");

            //    if (num > 5)
            //    {
            //        chb_C_show.Checked = false;
            //        MyTool.alertback("已勾選5個");
            //    }
            //}
        }
    }
}
