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
                if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                Bind();
                BLL.NewsClass bll = new BLL.NewsClass();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
                //lblSortKey.Text = (bll.GetMaxSortKey("ParentID=0 ") + 1).ToString();
            }
        }
        private void Bind() {
            BLL.NewsClass bll = new BLL.NewsClass();
            DataView dv = bll.GetList("").Tables[0].DefaultView;
            rpt_list.DataSource = dv;
            rpt_list.DataBind();
            FormatData(dv);
        }
        private void FormatData(DataView dv) {
            BLL.NewsClass b = new BLL.NewsClass();
            for (int i = 0; i <rpt_list.Items.Count;i++) {
                DropDownList ddlSortKey =rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
                int maxSortKey = b.GetMaxSortKey("");
                for (int j = 0; j <= maxSortKey; j++) {
                    ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }
                ddlSortKey.SelectedValue = dv[i]["OrderID"].ToString();
            }
            if (dv != null) {
                dv.Dispose();
            }
        }
        protected void btnModfiySortKey_Click(object sender, EventArgs e) {
            BLL.NewsClass b = new BLL.NewsClass();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey =rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            int classid = Convert.ToInt32(lblNCId.Text);
            //Model.NewsClass info = b.GetModel(Convert.ToInt32(lblNCId.Text));
           // DataView ds =b.GetList("OrderID=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            //if (info != null && ds.Count == 1) {
                //string sql = "update NewsClass set OrderID=" + ddlSortKey.SelectedValue + " where classid=" + info.classid.ToString();
            string sql = "update NewsClass set OrderID=" + ddlSortKey.SelectedValue + " where classid=" + classid.ToString();
                //string sql1 = "update NewsClass set OrderID=" + info.OrderID + " where classid=" + ds[0]["classid"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                //list.Add(sql1);
                DbHelperOledb.ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            //}


                
        }
        protected void Sub_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text)) {
                Model.NewsClass model = new Model.NewsClass();
                model.ClassName = tb_classname.Text;
                model.OrderID = Convert.ToInt32(lblSortKey.Text);
                model.ParentID = 1;
                model.Keyword = tbkeywords.Text;
                model.Desciption = tbDescrition.Text;
                model.ArtListTitle = txtTitle.Text;
                model.ArtListDescription = txtDescription.Text;
                BLL.NewsClass bll = new BLL.NewsClass();
                if (bll.Exists(model.ClassName))
                    MessageBox.Show(this, "網頁分類已經存在");
                else {
                    if (!bll.AddSmall(model))
                    {
                        MessageBox.Show(this, "添加失敗");
                    }
                    else
                    {
                        Bind();
                        Reset();
                    }
                }
            } else {
                BLL.NewsClass bll = new BLL.NewsClass();
                Model.NewsClass model = new Model.NewsClass();
                model.classid = Convert.ToInt32(lblNCID.Text);
                model.ClassName =tb_classname.Text;
                model.Keyword = tbkeywords.Text;
                model.Desciption = tbDescrition.Text;
                model.ArtListTitle = txtTitle.Text;
                model.ArtListDescription = txtDescription.Text;
                model.OrderID = Convert.ToInt32(lblSortKey.Text);
                if (bll.UpdateSmall(model))
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
        private void Reset() {
            BLL.NewsClass bll = new BLL.NewsClass();
            lblNCID.Text = "";
            tb_classname.Text = "";
            tbkeywords.Text = "";
            tbDescrition.Text = "";
            lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            txtTitle.Text = txtDescription.Text = "";
            Button1.Text = "新增";
        }
        protected void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        protected void btnModfiy_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int classid = Convert.ToInt32(btn.CommandArgument);
            BLL.NewsClass bll = new BLL.NewsClass();
            Model.NewsClass model = bll.GetModel(classid);
            lblNCID.Text = classid.ToString();
            tb_classname.Text = model.ClassName;
            lblSortKey.Text = model.OrderID.ToString();
            tbkeywords.Text = model.Keyword;
            tbDescrition.Text = model.Desciption;
            txtTitle.Text = model.ArtListTitle;
            txtDescription.Text = model.ArtListDescription;
            Button1.Text = "修改";
            
        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            BLL.NewsClass bll = new BLL.NewsClass();
            Model.NewsClass model = new Model.NewsClass();
            model.classid = Convert.ToInt32(e.CommandName);
            if (bll.Delete(model.classid))
                Bind();
            else
                MessageBox.Show(this, "刪除失敗");
        }
        protected void rpt_list_ItemDataBound(object sender, RepeaterItemEventArgs e) {
            if (e.Item.ItemType==ListItemType.AlternatingItem||e.Item.ItemType==ListItemType.Item) {
                LinkButton btn = e.Item.FindControl("btnModfiySortKey") as LinkButton;
                btn.CommandArgument = e.Item.ItemIndex.ToString();



                //Label lblPID = e.Item.FindControl("lblNCId") as Label;//如果是绑定的DataReader则找不到，不知何故。
                //int classid = Convert.ToInt32(lblPID.Text.Trim());

                //if (classid == 6 || classid == 7 || classid == 8 || classid == 9)
                //{
                //    LinkButton LinkButtondel = e.Item.FindControl("LinkButton1") as LinkButton;//如果是绑定的DataReader则找不到，不知何故。  
                //    LinkButtondel.Visible = false;

                //}
            }


        }

        protected void btnUpdateDB_Click(object sender, EventArgs e)
        {
            DbHelperOledb.ExecuteSql("ALTER TABLE NewsClass ADD COLUMN NC_ArtList_Title TEXT(255);");
            DbHelperOledb.ExecuteSql("ALTER TABLE NewsClass ADD COLUMN NC_ArtList_Description Memo;");
        }




    }
}
