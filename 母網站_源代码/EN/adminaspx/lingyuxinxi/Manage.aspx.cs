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
                this.cbxWeb.DataSource = new CbxSubwebSingle().CbxTable();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();

                for (int i = 0; i < cbxWeb.Items.Count; i++)
                {
                    cbxWeb.Items[0].Selected = true;
                }

                DDLBind();
                AspNetPager1.RecordCount = bll.CountByClass(" hst=0 ");
                Bind();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
                cbxWeb.Enabled = false;
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
            //DataView dv = bll.GetList(" hst=0 ").Tables[0].DefaultView;
            DataView dv = GetSelectList(this.cbxWeb);
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
        /// <summary>
        /// 獲取不同網站的數據
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public DataView GetSelectList(CheckBoxList list)
        {
            DataTable dt = new DataTable();
            BLL.linyuxinxi bll = new BLL.linyuxinxi();
            if (list.SelectedItem != null)
            {

                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("id", Type.GetType("System.Int32"));//編號
                dt.Columns.Add("title", Type.GetType("System.String"));//企業名稱
                dt.Columns.Add("linyuclassname", Type.GetType("System.String"));//所屬類別
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
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
                            dt2 = bll.GetList(" isnull(hst,'')<>1 ", new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["id"] = dt2.Rows[j]["id"].ToString();
                                dr["title"] = dt2.Rows[j]["title"].ToString();
                                dr["linyuclassname"] = dt2.Rows[j]["linyuclassname"].ToString();
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
                dt.Columns.Add("title", Type.GetType("System.String"));//企業名稱
                dt.Columns.Add("linyuclassname", Type.GetType("System.String"));//所屬類別
                dt.Columns.Add("Sort", Type.GetType("System.String"));//排序
                dt.Columns.Add("WebSite", Type.GetType("System.String"));//網站
                dt.Columns.Add("Swid", Type.GetType("System.Int32"));//網站ID

                //創建行
                DataRow dr = null;
                DataTable dt2 = new DataTable();
                for (int i = 0; i < list.Items.Count; i++)
                {
                    try
                    {
                        dt2 = bll.GetList(" isnull(hst,'')<>1 ",new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            dr = dt.NewRow();
                            dr["id"] = dt2.Rows[j]["id"].ToString();
                            dr["title"] = dt2.Rows[j]["title"].ToString();
                            dr["linyuclassname"] = dt2.Rows[j]["linyuclassname"].ToString();
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
            BLL.linyuxinxi b = new BLL.linyuxinxi();
            //for (int i = 0; i < rpt_list.Items.Count; i++)
            //{
            //    DropDownList ddlSortKey = rpt_list.Items[i].FindControl("ddlSortKey") as DropDownList;
            //    int maxSortKey = b.GetMaxSortKey("", new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["Swid"])));
            //    for (int j = 0; j <= maxSortKey; j++)
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
                    for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                    {
                        try
                        {
                            if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)
                            {
                                if (i > 0)
                                {
                                    if (!bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))))
                                    {
                                        MessageBox.Show(this, "添加失敗");
                                    }
                                    else
                                    {
                                        //this.cbxWeb.Items[i].Selected = false;
                                        Bind();
                                        Reset();
                                    }
                                }
                            }
                            else
                            {
                                if (this.cbxWeb.Items[i].Selected)
                                {
                                    if (!bll.Add(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))))
                                    {
                                        MessageBox.Show(this, "添加失敗");
                                    }
                                    else
                                    {
                                        //this.cbxWeb.Items[i].Selected = false;
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
                BLL.linyuxinxi bll = new BLL.linyuxinxi();
                Model.linyuxinxi model = new Model.linyuxinxi();
                model.id = Convert.ToInt32(lblNCID.Text.Split(',')[0]);
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
                if (bll.Update(model, new BLL.SubWeb().GetModel(int.Parse(lblNCID.Text.Split(',')[1]))))
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
                LinkButton del = rpt_list.Items[i].FindControl("LinkButton1") as LinkButton;
                if (lblPID != null && cbSelect != null)
                {
                    if (cbSelect.Checked)
                    {
                        BLL.linyuxinxi bll = new BLL.linyuxinxi();
                        int p_id = Convert.ToInt32(lblPID.Text.Trim());
                        //bll.Delete(p_id);
                        bll.UpdateState(p_id, 1, new BLL.SubWeb().GetModel(Convert.ToInt32(del.CommandArgument)));
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
            Model.linyuxinxi info = b.GetModel(Convert.ToInt32(lblNCId.Text.Split(',')[0]));
            DataView ds = b.GetList("Sort=" + ddlSortKey.SelectedValue).Tables[0].DefaultView;

            if (info != null && ds.Count == 1)
            {
                string sql = "update linyuxinxi set Sort=" + ddlSortKey.SelectedValue + " where id=" + info.id.ToString();
                string sql1 = "update linyuxinxi set Sort=" + info.Sort + " where id=" + ds[0]["id"].ToString();
                ArrayList list = new ArrayList();
                list.Add(sql);
                list.Add(sql1);
                new DbHelperOledbP(new BLL.SubWeb().GetModel(Convert.ToInt32(lblNCId.Text.Split(',')[1]))).ExecuteSqlTran(list);
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
            Model.linyuxinxi model = bll.GetModel(nc_id,new BLL.SubWeb().GetModel(Convert.ToInt32(btn.CommandName)));
            lblNCID.Text = nc_id.ToString() + "," + btn.CommandName;
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
            if (bll.UpdateState(model.id, 1,new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))))
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
