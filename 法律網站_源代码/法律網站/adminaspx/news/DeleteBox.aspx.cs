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

namespace Web.Admin.News {
    public partial class DeleteBox : System.Web.UI.Page {
        BLL.newsdata b = new BLL.newsdata();
        
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                AspNetPager1.RecordCount = b.Count("D_Recycle=1");
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = CreateTable().DefaultView;
            rpt_news.DataSource = pds; 
            rpt_news.DataBind();
        }

        public DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            int a;
            if (Session["Admin"].ToString().ToLower() == "admin")
            {
                a = 1;
            }
            else
            {
                a = 0;
            }
            //------------------創建數據源--------------------------
            //創建表頭
            dt.Columns.Add("D_ID", Type.GetType("System.Int32"));
            dt.Columns.Add("D_Title", Type.GetType("System.String"));
            dt.Columns.Add("ClassName", Type.GetType("System.String"));
            dt.Columns.Add("D_Editor", Type.GetType("System.String"));
            dt.Columns.Add("D_Time", Type.GetType("System.String"));
            dt.Columns.Add("OrderID", Type.GetType("System.Int32"));
            dt.Columns.Add("Database", Type.GetType("System.String"));
            dt.Columns.Add("SwId", Type.GetType("System.String"));
            dt.Columns.Add("D_ID_SwId", Type.GetType("System.String"));
            //創建行
            DataRow dr = null;
            if (Session["Admin"].ToString().ToLower() == "admin")
            {
                DataSet demo = new BLL.SubWeb().GetAllList();
                for (int j = 0; j < demo.Tables[0].Rows.Count; j++)
                {
                    try
                    {
                        int SwID = Convert.ToInt32(demo.Tables[0].Rows[j]["SWID"].ToString());
                        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);

                        DataSet ds = b.GetListByClass("D_Recycle=1", "D_ID desc", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                            dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                            dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                            dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                            dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
                            dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
                            dr["Database"] = web.SWName;
                            dr["SwId"] = web.SWID;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + web.SWID;
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
            }
            else
            {
                //string UserName = Session["Admin"].ToString();
                //DataSet ds1 = new BLL.Right().GetList("UserName='" + UserName + "' and Rights=0");
                //for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                //{
                //    Model.SubWeb web1 = new BLL.SubWeb().GetModel(Convert.ToInt32(ds1.Tables[0].Rows[j]["PageName"].ToString()));

                //    try
                //    {
                //Model.SubWeb web = new BLL.SubWeb().GetModel(web1.SWID);
                Model.SubWeb web = new CbxSubweb().GetWebModel();
                DataSet ds = b.GetListByClass("D_Recycle=1", "D_ID desc", web);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                    dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                    dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                    dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                    dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
                    dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
                    dr["Database"] = web.SWName;
                    dr["SwId"] = web.SWID;
                    dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + web.SWID;
                    dt.Rows.Add(dr);
                }
                //}
                //catch (Exception)
                //{

                //}
                //}
            }
            

            return dt;
        }
        
        
        protected void btnUnDel_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string demoValue = e.CommandArgument.ToString();
            string[] str =demoValue.Split('|');
            int p_id = Convert.ToInt32(str[0].ToString());
            int SwId = Convert.ToInt32(str[1].ToString());
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);

            b.UpdateState(p_id, 0,web);
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string demoValue = e.CommandArgument.ToString();
            string[] str = demoValue.Split('|');
            int p_id = Convert.ToInt32(str[0].ToString());
            int SwId = Convert.ToInt32(str[1].ToString());
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);

            b.Delete(p_id,web);
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = CreateTable().DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                int N_Id = (int)dv[i]["D_ID"];
                int SwId = Convert.ToInt32(dv[i]["SwId"].ToString());
                Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);

                b.UpdateState(N_Id, 0,web);
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;

                Label SwId = rpt_news.Items[i].FindControl("lbSwId") as Label;

                Model.SubWeb web = new BLL.SubWeb().GetModel(Convert.ToInt32(SwId.Text));

                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.UpdateState(Convert.ToInt32(lblNId.Text.Trim()), 0, web);
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = CreateTable().DefaultView; 
            for (int i = 0; i < dv.Count; i++)
            {
                
                int N_Id = (int)dv[i]["D_ID"];
                int SwId = Convert.ToInt32( dv[i]["SwId"].ToString());
                Model.SubWeb web = new BLL.SubWeb().GetModel(SwId);
                b.Delete(N_Id,web);
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
                Label SwId = rpt_news.Items[i].FindControl("lbSwId") as Label;

                Model.SubWeb web = new BLL.SubWeb().GetModel(Convert.ToInt32(SwId.Text));

                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {

                        b.Delete(Convert.ToInt32(lblNId.Text.Trim()), web);
                    }
                }
            }
            Bind();
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e) {
            Bind();
        }
    }
}