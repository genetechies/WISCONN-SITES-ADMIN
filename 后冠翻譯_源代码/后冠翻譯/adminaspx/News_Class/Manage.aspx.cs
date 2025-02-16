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
            
            if (!IsPostBack) {
                if (!Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                Bind();
                BLL.guoclass bll = new BLL.guoclass();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            }
        }
        private void Bind() {
            BLL.guoclass bll = new BLL.guoclass();
            DataView dv = bll.GetAll().Tables[0].DefaultView;
            rpt_list.DataSource = dv;
            rpt_list.DataBind();
            FormatData(dv);
        }
        private void FormatData(DataView dv) {
            BLL.guoclass b = new BLL.guoclass();
            for (int i = 0; i <rpt_list.Items.Count;i++) {
                DropDownList ddlSortKey =rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
                int maxSortKey = b.GetMaxSortKey("");
                for (int j = 0; j <= maxSortKey; j++) {
                    ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }
                ddlSortKey.SelectedValue = dv[i]["NC_Sort"].ToString();
            }
            if (dv != null) {
                dv.Dispose();
            }
        }
        protected void btnModfiySortKey_Click(object sender, EventArgs e) {
            BLL.guoclass b = new BLL.guoclass();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey =rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.guoclass info = b.GetModel(Convert.ToInt32(lblNCId.Text));
            DataView ds =b.GetList("nc_Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            if (info != null && ds.Count == 1) {
                string sql = "update guoclass set nc_Sort=" + ddlSortKey.SelectedValue + " where nc_Id=" + info.Id.ToString();
                string sql1 = "update guoclass set nc_Sort=" + info.Sort + " where nc_Id=" + ds[0]["nc_Id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                list.Add(sql1);
                DbHelperOledb.ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }
        protected void Sub_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text)) {
                Model.guoclass model = new Model.guoclass();
                model.ClassName = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                BLL.guoclass bll = new BLL.guoclass();
                if (bll.Exists(model.ClassName))
                    MessageBox.Show(this, "項目已經存在");
                else {
                    if (bll.Add(model)<1) {
                        MessageBox.Show(this, "添加失敗");
                    } else {
                        Bind();
                        Reset();
                    }
                }
            } else {
                BLL.guoclass bll = new BLL.guoclass();
                Model.guoclass model = new Model.guoclass();
                model.Id = Convert.ToInt32(lblNCID.Text);
                model.ClassName =tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                if (bll.Update(model)) {
                    Bind();
                    Reset();
                } else {
                    MessageBox.Show(this, "修改失敗");
                }
            }
        }
        private void Reset() {
            BLL.guoclass bll = new BLL.guoclass();
            lblNCID.Text = "";
            tb_classname.Text = "";
            tbkeywords.Text = "";
            tbDescrition.Text = "";
            lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            Button1.Text = "新增";
        }
        protected void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        protected void btnModfiy_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int nc_id = Convert.ToInt32(btn.CommandArgument);
            BLL.guoclass bll = new BLL.guoclass();
            Model.guoclass model = bll.GetModel(nc_id);
            lblNCID.Text = nc_id.ToString();
            tb_classname.Text = model.ClassName;
            lblSortKey.Text = model.Sort.ToString();
            tbkeywords.Text = model.Keywords;
            tbDescrition.Text = model.Description;
            Button1.Text = "修改";
            
        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            BLL.guoclass bll = new BLL.guoclass();
            Model.guoclass model = new Model.guoclass();
            model.Id = Convert.ToInt32(e.CommandName);
            if (bll.Delete(model.Id))
                Bind();
            else
                MessageBox.Show(this, "刪除失敗");
        }
        protected void rpt_list_ItemDataBound(object sender, RepeaterItemEventArgs e) {
            if (e.Item.ItemType==ListItemType.AlternatingItem||e.Item.ItemType==ListItemType.Item) {
                LinkButton btn = e.Item.FindControl("btnModfiySortKey") as LinkButton;
                btn.CommandArgument = e.Item.ItemIndex.ToString();
            }
        }
}
}
