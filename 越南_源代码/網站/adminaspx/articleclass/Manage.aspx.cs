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
                if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

               

                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();
                Bind();

                BLL.NewsClass bll = new BLL.NewsClass();
                lblSortKey.Text = (bll.GetMaxSortKey("") + 1).ToString();
                //lblSortKey.Text = (bll.GetMaxSortKey("ParentID=0 ") + 1).ToString();
            }
        }
        private void Bind()
        {
            BLL.NewsClass bll = new BLL.NewsClass();
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
            BLL.NewsClass bll = new BLL.NewsClass();

            string strWhere = "";
            if (tb_classname.Text != "")
            {
                strWhere = string.Format(" ClassName like '%{0}%' ", tb_classname.Text.Trim());
            }

            if (list.SelectedItem != null)
            {

                //------------------創建數據源--------------------------
                //創建表頭
                dt.Columns.Add("classid", Type.GetType("System.Int32"));//編號
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
                    if (list.Items[0].Selected || list.Items[i].Selected)
                    {
                        try
                        {
                            dt2 = bll.GetList(strWhere, new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["classid"] = dt2.Rows[j]["classid"].ToString();
                                dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                                dr["Sort"] = dt2.Rows[j]["OrderID"].ToString();
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
                dt.Columns.Add("classid", Type.GetType("System.Int32"));//編號
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
                    if (cbxWeb.Items[i].Value != "0") //no all website
                    {
                        try
                        {
                            dt2 = bll.GetList(strWhere, new BLL.SubWeb().GetModel(int.Parse(list.Items[i].Value))).Tables[0];
                            for (int j = 0; j < dt2.Rows.Count; j++)
                            {
                                dr = dt.NewRow();
                                dr["classid"] = dt2.Rows[j]["classid"].ToString();
                                dr["ClassName"] = dt2.Rows[j]["ClassName"].ToString();
                                dr["Sort"] = dt2.Rows[j]["OrderID"].ToString();
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
                }
                return dt.DefaultView;
            }
            //return dt.DefaultView;

        }


        private void FormatData(DataView dv)
        {
            BLL.NewsClass b = new BLL.NewsClass();
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
        protected void btnModfiySortKey_Click(object sender, EventArgs e)
        {
            BLL.NewsClass b = new BLL.NewsClass();
            LinkButton btn = sender as LinkButton;
            int rowindex = Convert.ToInt32(btn.CommandArgument);

            DropDownList ddlSortKey = rpt_list.Items[rowindex].FindControl("ddlSortKey") as DropDownList;
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
        protected void Sub_Click(object sender, EventArgs e)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (string.IsNullOrEmpty(lblNCID.Text))
            {
                Model.NewsClass model = new Model.NewsClass();
                model.ClassName = tb_classname.Text;
                model.OrderID = Convert.ToInt32(lblSortKey.Text);
                model.ParentID = 1;
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                BLL.NewsClass bll = new BLL.NewsClass();
                for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                {
                    if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                    {
                        if (i > 0)
                        {
                            if (!bll.Exists(model.ClassName, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))))
                            {
                                bll.AddSmall(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                            }
                        }
                    }
                    else
                    {
                        if (this.cbxWeb.Items[i].Selected)
                        {
                            if (!bll.Exists(model.ClassName, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value))))
                            {
                                bll.AddSmall(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                            }
                            this.cbxWeb.Items[i].Selected = false;
                        }
                    }
                }
                this.cbxWeb.Items[0].Selected = false;
                Bind();
                Reset();
            }
            else
            {
                BLL.NewsClass bll = new BLL.NewsClass();
                Model.NewsClass model = new Model.NewsClass();
                model.classid = Convert.ToInt32(lblNCID.Text);
                model.ClassName = tb_classname.Text;
                model.OrderID = Convert.ToInt32(lblSortKey.Text);
                model.Keywords = tbkeywords.Text;
                model.Description = tbDescrition.Text;
                //if (bll.UpdateSmall(model))
                //{
                //    Bind();
                //    Reset();
                //}
                //else
                //{
                //    MessageBox.Show(this, "修改失敗");
                //}
                for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                {
                    if (this.cbxWeb.Items[0].Value == "0" && this.cbxWeb.Items[0].Selected)//全站
                    {
                        if (i > 0)
                        {
                            bll.UpdateSmall(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                        }
                    }
                    else
                    {
                        if (this.cbxWeb.Items[i].Selected)
                        {
                            bll.UpdateSmall(model, new BLL.SubWeb().GetModel(int.Parse(this.cbxWeb.Items[i].Value)));
                            this.cbxWeb.Items[i].Selected = false;
                        }
                    }
                }
                this.cbxWeb.Items[0].Selected = false;
                Bind();
                Reset();

            }
        }
        private void Reset()
        {
            BLL.NewsClass bll = new BLL.NewsClass();
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            LinkButton btn = sender as LinkButton;
            int classid = Convert.ToInt32(btn.CommandArgument);
            BLL.NewsClass bll = new BLL.NewsClass();
            Model.NewsClass model = bll.GetModel(classid,new BLL.SubWeb().GetModel(int.Parse(btn.CommandName)));
            lblNCID.Text = classid.ToString();
            tb_classname.Text = model.ClassName;
            lblSortKey.Text = model.OrderID.ToString();
            tbkeywords.Text = model.Keywords;
            tbDescrition.Text = model.Description;
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
            if (bll.Delete(model.classid, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandArgument))))
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
                //Label lblPID = e.Item.FindControl("lblNCId") as Label;//如果是绑定的DataReader则找不到，不知何故。
                //int classid = Convert.ToInt32(lblPID.Text.Trim());

                //if (classid == 6 || classid == 7 || classid == 8 || classid == 9)
                //{
                //    LinkButton LinkButtondel = e.Item.FindControl("LinkButton1") as LinkButton;//如果是绑定的DataReader则找不到，不知何故。  
                //    LinkButtondel.Visible = false;

                //}
            } 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Bind();
        }
}
}
