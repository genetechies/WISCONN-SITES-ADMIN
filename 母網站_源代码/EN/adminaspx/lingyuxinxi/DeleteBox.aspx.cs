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

namespace Web.Admin.Product {
    public partial class DeleteBox : System.Web.UI.Page {
        BLL.linyuxinxi b = new BLL.linyuxinxi();

        protected void Page_Load(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                AspNetPager1.RecordCount = b.Count("hst=1");
                Bind();
            }
        }

        protected void Bind() {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            //pds.DataSource = b.GetList("hst=1").Tables[0].DefaultView;
            DataTable dw = CreateTable();
            pds.DataSource = dw.DefaultView;
            ViewState["dw"] = dw;
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
            dt.Columns.Add("id", Type.GetType("System.Int32"));
            dt.Columns.Add("title", Type.GetType("System.String"));
            dt.Columns.Add("linyuclassname", Type.GetType("System.String"));
            dt.Columns.Add("addtime", Type.GetType("System.String"));
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
                        DataSet ds = b.GetList("hst=1", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString());
                            dr["title"] = ds.Tables[0].Rows[i]["title"].ToString();
                            dr["linyuclassname"] = ds.Tables[0].Rows[i]["linyuclassname"].ToString();
                            dr["addtime"] = ds.Tables[0].Rows[i]["addtime"].ToString();
                            dr["Database"] = web.SWName;
                            dr["SwId"] = web.SWID;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["id"].ToString() + "|" + web.SWID;
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
                string UserName = Session["Admin"].ToString();
                DataSet ds1 = new BLL.Right().GetList("UserName='" + UserName + "' and Rights=0");
                for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                {
                    Model.SubWeb web1 = new BLL.SubWeb().GetModel(Convert.ToInt32(ds1.Tables[0].Rows[j]["PageName"].ToString()));

                    try
                    {
                        Model.SubWeb web = new BLL.SubWeb().GetModel(web1.SWID);
                        DataSet ds = b.GetList("hst=1", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString());
                            dr["title"] = ds.Tables[0].Rows[i]["title"].ToString();
                            dr["linyuclassname"] = ds.Tables[0].Rows[i]["linyuclassname"].ToString();
                            dr["addtime"] = ds.Tables[0].Rows[i]["addtime"].ToString();
                            dr["Database"] = web1.SWName;
                            dr["SwId"] = web1.SWID;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["id"].ToString() + "|" + web.SWID;
                            dt.Rows.Add(dr);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }


            return dt;
        }
       
        protected void btnUnDel_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            b.UpdateState(Convert.ToInt32(e.CommandArgument.ToString()), 0, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandName.ToString())));
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            int p_id = Convert.ToInt32(e.CommandArgument.ToString());
            b.Delete(p_id, new BLL.SubWeb().GetModel(Convert.ToInt32(e.CommandName.ToString())));
            
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv =(ViewState["dw"] as DataTable).DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int N_Id = (int)dv[i]["id"];
                b.UpdateState(N_Id, 0, new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["SwId"])));
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblPID") as Label;
                int swid = Convert.ToInt32((rpt_news.Items[i].FindControl("Del") as LinkButton).CommandName);
                if (cbSelect != null && lblNId != null) {
                    if (cbSelect.Checked) {
                        b.UpdateState(Convert.ToInt32(lblNId.Text.Trim()), 0,new BLL.SubWeb().GetModel(swid));
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = (ViewState["dw"] as DataTable).DefaultView;
            for (int i = 0; i < dv.Count; i++) {
                int P_Id = (int)dv[i]["id"];
                b.Delete(P_Id, new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["SwId"])));
                
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e) {
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++) {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblPId = rpt_news.Items[i].FindControl("lblPID") as Label;
                int swid = Convert.ToInt32((rpt_news.Items[i].FindControl("Del") as LinkButton).CommandName);
                if (cbSelect != null && lblPId != null) {
                    if (cbSelect.Checked) {
                        b.Delete(Convert.ToInt32(lblPId.Text.Trim()), new BLL.SubWeb().GetModel(swid));
                        
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