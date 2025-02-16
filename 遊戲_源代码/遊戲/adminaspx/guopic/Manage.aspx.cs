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

            if (!IsPostBack)
            {
                if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();

                for (int i = 0; i < cbxWeb.Items.Count; i++)
                {
                    cbxWeb.Items[0].Selected = true;
                }

                DDLBind();

                BLL.guopic bll = new BLL.guopic();
                AspNetPager1.RecordCount = bll.Count(" 1=1 ");
                Bind();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();

                cbxWeb.Enabled = false;
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
            //DataView dv = bll.GetListByClass("1=1", "id desc").Tables[0].DefaultView;
            DataView dv = GetSelectList(this.cbxWeb);
            pds.DataSource = dv;
            rpt_list.DataSource = pds;
            rpt_list.DataBind();

            FormatData(dv);
        }
        /// <summary>
        /// 獲取不同網站的數據
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataView GetSelectList(CheckBoxList list)
        {
            DataTable dt = new DataTable();
            BLL.guopic bll = new BLL.guopic();
            if (list.SelectedItem != null)
            {

                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("id", Type.GetType("System.Int32"));//編號
                dt.Columns.Add("title", Type.GetType("System.String"));//标题
                dt.Columns.Add("pic", Type.GetType("System.String"));//图片
                dt.Columns.Add("guojianame", Type.GetType("System.String"));//服務項目類別
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID


                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].Selected)
                    {
                        try
                        {
                            dt2 = bll.GetListByClass("1=1", "id desc", new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["id"] = dt2.Rows[j]["id"].ToString();
                                dr["title"] = dt2.Rows[j]["title"].ToString();
                                dr["pic"] = dt2.Rows[j]["pic"].ToString();
                                dr["guojianame"] = dt2.Rows[j]["guojianame"].ToString();
                                dr["Sort"] = dt2.Rows[j]["Sort"].ToString();
                                dr["WebSite"] = list.Items[i].Text;
                                dr["Swid"] = list.Items[i].Value;
                                dt.Rows.Add(dr);
                            }
                        }
                        catch (Exception) { }
                    }
                }
                return dt.DefaultView;
            }
            else
            {
                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("id", Type.GetType("System.Int32"));//編號
                dt.Columns.Add("title", Type.GetType("System.String"));//标题
                dt.Columns.Add("pic", Type.GetType("System.String"));//图片
                dt.Columns.Add("guojianame", Type.GetType("System.String"));//服務項目類別
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID

                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    try
                    {
                        dt2 = bll.GetListByClass("1=1", "id desc", new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            dr = dt.NewRow();
                            dr["id"] = dt2.Rows[j]["id"].ToString();
                            dr["title"] = dt2.Rows[j]["title"].ToString();
                            dr["pic"] = dt2.Rows[j]["pic"].ToString();
                            dr["guojianame"] = dt2.Rows[j]["guojianame"].ToString();
                            dr["Sort"] = dt2.Rows[j]["Sort"].ToString();
                            dr["WebSite"] = list.Items[i].Text;
                            dr["Swid"] = list.Items[i].Value;
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                return dt.DefaultView;
            }
            //return dt.DefaultView;

        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }


        private void FormatData(DataView dv)
        {
            BLL.guopic b = new BLL.guopic();
            //for (int i = 0; i < rpt_list.Items.Count; i++)
            //{
            //    DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
            //    int maxSortKey = b.GetMaxSortKey("");
            //    for (int j = 1; j <= maxSortKey; j++)
            //    {
            //        ddlSortKey.Items.Add(new ListItem(j.ToString(), j.ToString()));
            //    }
            //    ddlSortKey.SelectedValue = dv[i]["Sort"].ToString();
            //}
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

                bll.Add(model, new CbxSubweb().GetWebModel());

                //if (bll.Exists(model.title))
                //    MessageBox.Show(this, "相同Logo名稱已經存在");
                //else
                //{
                //if (!bll.Add(model))
                //{
                //    MessageBox.Show(this, "添加失敗");
                //}
                //else
                //{
                //    Bind();
                //    Reset();
                //}
                //}
                //for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                //{
                //    if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                //    {
                //        if (i > 0)
                //        {
                //            bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                //        }
                //    }
                //    else
                //    {
                //        if (this.cbxWeb.Items[i].Selected)
                //        {
                //            bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                //            this.cbxWeb.Items[i].Selected = false;
                //        }
                //    }
                //}
                //this.cbxWeb.Items[0].Selected = true;
                Bind();
                Reset();
            }
            else
            {
                BLL.guopic bll = new BLL.guopic();
                Model.guopic model = new Model.guopic();
                model.id = Convert.ToInt32(lblNCID.Text);
                model.title = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.pic = txtPhotoUrl.Text.Trim();

                bll.Update(model, new CbxSubweb().GetWebModel());


                //if (bll.Update(model))
                //{
                //    Bind();
                //    Reset();
                //}
                //else
                //{
                //    MessageBox.Show(this, "修改失敗");
                //}
                //for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                //{
                //    if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                //    {
                //        if (i > 0)
                //        {
                //            bll.Update(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                //        }
                //    }
                //    else
                //    {
                //        if (this.cbxWeb.Items[i].Selected)
                //        {
                //            bll.Update(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                //            this.cbxWeb.Items[i].Selected = false;
                //        }
                //    }
                //}
                //this.cbxWeb.Items[0].Selected = true;
                Bind();
                Reset();
            }
        }





        protected void btnModfiySortKey_Click(object sender, EventArgs e)
        {
            BLL.guopic b = new BLL.guopic();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.guopic info = b.GetModel(Convert.ToInt32(lblNCId.Text));
            DataView ds = b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            if (info != null && ds.Count == 1)
            {
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

        private void Reset()
        {
            BLL.guopic bll = new BLL.guopic();
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int nc_id = Convert.ToInt32(btn.CommandArgument);
            BLL.guopic bll = new BLL.guopic();
            Model.guopic model = bll.GetModel(nc_id, new BLL.SubWeb().GetModel(Convert.ToInt32(btn.CommandName)));
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
            if (bll.Delete(model.id, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))))
                Bind();
            else
                MessageBox.Show(this, "刪除失敗");
        }
        protected void rpt_list_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                //LinkButton btn = e.Item.FindControl("btnModfiySortKey") as LinkButton;
                //btn.CommandArgument = e.Item.ItemIndex.ToString();
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
