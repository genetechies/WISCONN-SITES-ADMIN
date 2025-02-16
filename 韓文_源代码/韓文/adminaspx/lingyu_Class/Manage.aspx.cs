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
                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();
                for (int i = 0; i < cbxWeb.Items.Count; i++)
                {
                    cbxWeb.Items[0].Selected = true;
                }
                Bind();
                BLL.linyuclass bll = new BLL.linyuclass();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();

                cbxWeb.Enabled = false;
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
            //DataView dv = bll.GetAll().Tables[0].DefaultView;
            DataView dv = GetSelectList(this.cbxWeb);
            rpt_list.DataSource = dv;
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
            BLL.linyuclass bll = new BLL.linyuclass();
            if (list.SelectedItem != null)
            {

                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("id", Type.GetType("System.Int32"));//編號
                dt.Columns.Add("ClassName", Type.GetType("System.String"));//洲類別名稱
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID
                dt.Columns.Add("Keywords", Type.GetType("System.String"));//網站
                dt.Columns.Add("Description", Type.GetType("System.String"));//網站ID


                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (list.Items[i].Selected)
                    {
                        try
                        {
                            dt2 = bll.GetAll(new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["id"] = dt2.Rows[j]["id"].ToString();
                                dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                                dr["Sort"] = dt2.Rows[j]["Sort"].ToString();
                                dr["WebSite"] = list.Items[i].Text;
                                dr["Swid"] = list.Items[i].Value;
                                dr["Keywords"] = dt2.Rows[j]["Keywords"].ToString();
                                dr["Description"] = dt2.Rows[j]["Description"].ToString();
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
                dt.Columns.Add("ClassName", Type.GetType("System.String"));//洲類別名稱
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID
                dt.Columns.Add("Keywords", Type.GetType("System.String"));//網站
                dt.Columns.Add("Description", Type.GetType("System.String"));//網站ID

                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    try
                    {
                        dt2 = bll.GetAll(new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            dr = dt.NewRow();
                            dr["id"] = dt2.Rows[j]["id"].ToString();
                            dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                            dr["Sort"] = dt2.Rows[j]["Sort"].ToString();
                            dr["WebSite"] = list.Items[i].Text;
                            dr["Swid"] = list.Items[i].Value;
                            dr["Keywords"] = dt2.Rows[j]["Keywords"].ToString();
                            dr["Description"] = dt2.Rows[j]["Description"].ToString();
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
        private void FormatData(DataView dv)
        {
            BLL.linyuclass b = new BLL.linyuclass();
            for (int i = 0; i < rpt_list.Items.Count; i++)
            {
                DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
                int maxSortKey = b.GetMaxSortKey("", new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["Swid"])));
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
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                //model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.guoclassid = 0;
                BLL.linyuclass bll = new BLL.linyuclass();
                if (bll.Exists(model.ClassName))
                    MessageBox.Show(this, "洲類別名稱已經存在");
                else
                {
                    for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                    {
                        try
                        {
                            if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)
                            {
                                if (i > 0)
                                {
                                    if (bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))) < 1)
                                    {
                                        MessageBox.Show(this, "添加失敗");
                                    }
                                    else
                                    {
                                       // this.cbxWeb.Items[i].Selected = false;
                                        Bind();
                                        Reset();
                                    }
                                }
                            }
                            else
                            {
                                if (this.cbxWeb.Items[i].Selected)
                                {
                                    if (bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))) < 1)
                                    {
                                        MessageBox.Show(this, "添加失敗");
                                    }
                                    else
                                    {
                                       // this.cbxWeb.Items[i].Selected = false;
                                        Bind();
                                        Reset();
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
            else
            {
                BLL.linyuclass bll = new BLL.linyuclass();
                Model.linyuclass model = new Model.linyuclass();
                model.id = Convert.ToInt32(lblNCID.Text.Split(',')[0]);
                model.ClassName = tb_classname.Text;
                model.Sort = Convert.ToInt32(lblSortKey.Text);
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                //model.guoclassid = Convert.ToInt32(ddl_guoclass.SelectedValue);
                model.guoclassid = 0;
                if (bll.Update(model, new BLL.SubWeb().GetModel(Convert.ToInt32(lblNCID.Text.Split(',')[1]))))
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
            int rowindex = Convert.ToInt32(btn.CommandArgument.Split(',')[0]);

            DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
            Label lblNCId = rpt_list.Items[rowindex].FindControl("lblNCId") as Label;
            Model.linyuclass info = b.GetModel(Convert.ToInt32(lblNCId.Text.Split(',')[0]), new BLL.SubWeb().GetModel(Convert.ToInt32(lblNCId.Text.Split(',')[1])));
            //DataView ds =b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            //if (info != null && ds.Count == 1) {
            if (info != null)
            {
                string sql = "update linyuclass set Sort=" + ddlSortKey.SelectedValue + " where id=" + info.id.ToString();
                //string sql1 = "update linyuclass set Sort=" + info.Sort + " where id=" + ds[0]["id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                //list.Add(sql1);
                new DbHelperOledbP(new BLL.SubWeb().GetModel(Convert.ToInt32(lblNCId.Text.Split(',')[1]))).ExecuteSqlTran(list);
                Bind();
                ClientScript.RegisterStartupScript(GetType(), "updatesuccess", "alert('修改成功！');", true);
            }
        }

        private void Reset()
        {
            BLL.linyuclass bll = new BLL.linyuclass();
            lblNCID.Text = "";
            tb_classname.Text = "";
            tbkeywords.Text = "";
            tbDescrition.Text = "";
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
            Model.linyuclass model = bll.GetModel(nc_id, new BLL.SubWeb().GetModel(int.Parse(btn.CommandName)));
            lblNCID.Text = nc_id.ToString() + "," + btn.CommandName;
            tb_classname.Text = model.ClassName;
            lblSortKey.Text = model.Sort.ToString();
            tbkeywords.Text = model.Keywords;
            tbDescrition.Text = model.Description;
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

            if (bll.Delete(model.id, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))))
            {
                BLL.linyuxinxi bllx = new BLL.linyuxinxi();
                DataTable dt = bllx.GetList(" linyuclassid=" + model.id, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        bllx.Delete(Convert.ToInt32(dt.Rows[i]["id"].ToString()), new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument)));
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
