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

namespace adminaspx.transzone {
    public partial class DeleteBox : System.Web.UI.Page
    {
        BLL.TransZone b = new BLL.TransZone();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                AspNetPager1.RecordCount = b.CountNew("D_Recycle=1");
                Bind();
            }
        }

        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            //pds.DataSource = b.GetListByClassNew("D_Recycle=1", "D_ID desc").Tables[0].DefaultView;
            DataTable dw = CreateTable();
            pds.DataSource = dw.DefaultView;
            ViewState["dw"]=dw;
            rpt_news.DataSource = pds;
            rpt_news.DataBind();
        }


        protected void btnUnDel_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            b.UpdateStateNew(Convert.ToInt32(e.CommandArgument.ToString().Split(',')[0]), 0, new BLL.SubWeb().GetModel(int.Parse(e.CommandArgument.ToString().Split(',')[1])));
            Bind();
        }
        protected void Del_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            b.DeleteNew(Convert.ToInt32(e.CommandArgument.ToString().Split(',')[0]), new BLL.SubWeb().GetModel(int.Parse(e.CommandArgument.ToString().Split(',')[1])));
            Bind();
        }
        protected void btnUnDelAll_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv =(ViewState["dw"] as DataTable).DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                int N_Id = (int)dv[i]["D_ID"];
                b.UpdateStateNew(N_Id, 0, new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["SwId"])));
            }
            Bind();
        }
        protected void btnUnDelAllSelect_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++)
            {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
                int swid = int.Parse((rpt_news.Items[i].FindControl("Del") as LinkButton).CommandArgument.Split(',')[1]);
                if (cbSelect != null && lblNId != null)
                {
                    if (cbSelect.Checked)
                    {
                        b.UpdateStateNew(Convert.ToInt32(lblNId.Text.Trim()), 0, new BLL.SubWeb().GetModel(swid));
                    }
                }
            }
            Bind();
        }
        protected void btnClear_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            DataView dv = (ViewState["dw"] as DataTable).DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                int N_Id = (int)dv[i]["D_ID"];
                b.DeleteNew(N_Id, new BLL.SubWeb().GetModel(Convert.ToInt32(dv[i]["SwId"])));
            }
            Bind();
        }
        protected void btnDelAll_Click(object sender, CommandEventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            for (int i = 0; i < rpt_news.Items.Count; i++)
            {
                CheckBox cbSelect = rpt_news.Items[i].FindControl("cbSelect") as CheckBox;
                Label lblNId = rpt_news.Items[i].FindControl("lblNID") as Label;
                int swid = int.Parse((rpt_news.Items[i].FindControl("Del") as LinkButton).CommandArgument.Split(',')[1]);
                if (cbSelect != null && lblNId != null)
                {
                    if (cbSelect.Checked)
                    {
                        b.DeleteNew(Convert.ToInt32(lblNId.Text.Trim()),new BLL.SubWeb().GetModel(swid));
                    }
                }
            }
            Bind();
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
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

                        DataSet ds = b.GetListByClassNew("D_Recycle=1", "D_ID desc", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                            dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                            dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                            dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                            dr["D_Time"] = DateTime.Parse(ds.Tables[0].Rows[i]["D_Time"].ToString()).ToString("yyyy-MM-dd");
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
                string UserName = Session["Admin"].ToString();
                DataSet ds1 = new BLL.Right().GetList("UserName='" + UserName + "' and Rights=0");
                for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                {
                    Model.SubWeb web1 = new BLL.SubWeb().GetModel(Convert.ToInt32(ds1.Tables[0].Rows[j]["PageName"].ToString()));

                    try
                    {
                        Model.SubWeb web = new BLL.SubWeb().GetModel(web1.SWID);
                        DataSet ds = b.GetListByClassNew("D_Recycle=1", "D_ID desc", web);
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = dt.NewRow();
                            dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                            dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                            dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                            dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                            dr["D_Time"] = DateTime.Parse(ds.Tables[0].Rows[i]["D_Time"].ToString()).ToString("yyyy-MM-dd");
                            dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
                            dr["Database"] = web1.SWName;
                            dr["SwId"] = web1.SWID;
                            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + web.SWID;
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
    }
}