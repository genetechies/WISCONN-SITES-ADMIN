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
using System.IO;

namespace Web.Admin.News_Class
{
    public partial class Manage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            
            if (!IsPostBack) {
                if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                DDLBind();
                
                BLL.guopic bll = new BLL.guopic();
                AspNetPager1.RecordCount = bll.Count(" 1=1 ");
                Bind();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            }
        }

        public void DDLBind()
        {
            BLL.guoclass bll = new BLL.guoclass();
            ddl_guoclass.DataSource = bll.GetAll();
            ddl_guoclass.DataTextField = "NC_ClassName";
            ddl_guoclass.DataValueField = "NC_Id";
            ddl_guoclass.DataBind();
        }

        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            BLL.guopic bll = new BLL.guopic();
            DataView dv = bll.GetListByClass("1=1", "id desc").Tables[0].DefaultView;
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
            BLL.guopic b = new BLL.guopic();
            for (int i = 0; i < rpt_list.Items.Count; i++)
            {
                DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
                int maxSortKey = b.GetMaxSortKey("");
                for (int j = 1; j <= maxSortKey; j++)
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text))
            {
                Model.guopic model = new Model.guopic();
                model.title = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.pic = txtPhotoUrl.Text.Trim();
                BLL.guopic bll = new BLL.guopic();
                //if (bll.Exists(model.title))
                //    MessageBox.Show(this, "相同Logo名稱已經存在");
                //else
                //{
                    if (!bll.Add(model))
                    {
                        MessageBox.Show(this, "添加失敗");
                    }
                    else
                    {
                        Bind();
                        Reset();
                    }
                //}
            }
            else
            {
                BLL.guopic bll = new BLL.guopic();
                Model.guopic model = new Model.guopic();
                model.id = Convert.ToInt32(lblNCID.Text);
                model.title = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.pic = "'" + txtPhotoUrl.Text.Trim() + "'";
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




        
        protected void btnModfiySortKey_Click(object sender, EventArgs e) {
            BLL.guopic b = new BLL.guopic();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey =rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.guopic info = b.GetModel(Convert.ToInt32(lblNCId.Text));
            DataView ds =b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            if (info != null && ds.Count == 1) {
                string sql = "update guopic set Sort=" + ddlSortKey.SelectedValue + " where id=" + info.id.ToString();
                string sql1 = "update guopic set Sort=" + info.Sort + " where id=" + ds[0]["id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                list.Add(sql1);
                DbHelperOledb.ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }
        
        private void Reset() {
            BLL.guopic bll = new BLL.guopic();
            lblNCID.Text = "";
            tb_classname.Text = "";
            lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
            Button1.Text = "新增";
        }
        protected void btnReset_Click(object sender, EventArgs e) {
            Reset();
        }
        protected void btnModfiy_Click(object sender, EventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int nc_id = Convert.ToInt32(btn.CommandArgument);
            BLL.guopic bll = new BLL.guopic();
            Model.guopic model = bll.GetModel(nc_id);
            lblNCID.Text = nc_id.ToString();
            tb_classname.Text = model.title;
            lblSortKey.Text = model.Sort.ToString();
            ddl_guoclass.SelectedValue = model.guoclassid.ToString();
            txtPhotoUrl.Text = model.pic;
            Button1.Text = "修改";
            
        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            BLL.guopic bll = new BLL.guopic();
            Model.guopic model = new Model.guopic();
            model.id = Convert.ToInt32(e.CommandName);
            if (bll.Delete(model.id))
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

        protected void UpFile_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string Name = FileUpload1.FileName;
                //文档上传到的固定目录 如果需要修改必须必须3个都修改
                string SaveSoft = Server.MapPath("~/UploadFiles/");
                string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
                string newName = "";
                if (Name != "")
                {
                    newName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + "." + Fe;

                }
                SaveSoft += newName;
                if (!Directory.Exists(Server.MapPath("~/UploadFiles/")))
                {
                    Directory.CreateDirectory(Server.MapPath("~/UploadFiles/"));
                }
                FileUpload1.SaveAs(SaveSoft);
                txtPhotoUrl.Text = "UploadFiles/" + newName;
                //上传缩略图
                AutoThumb.MakeThumbnail(SaveSoft, 160, 140);
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的圖片');", true);
                return;
            }
        }


}
}
