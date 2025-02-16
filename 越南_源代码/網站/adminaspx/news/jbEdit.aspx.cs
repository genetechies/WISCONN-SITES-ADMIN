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
using DBUtility;

namespace Web.Admin.News {
    public partial class Edit : System.Web.UI.Page {
        BLL.PageClass bll = new BLL.PageClass();

        protected void Page_Load(object sender, EventArgs e) {
            Model.PageClass model = new Model.PageClass();
            model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]));
            if (!IsPostBack) {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "jbnews", RightStatus.Update)) {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }
                BindDrpClass();
                

                txtTitle.Text = model.ClassName;
                MyDL.SelectedValue = model.ParentID.ToString();
                txtAuthor.Text = model.username;
                txtKeyword.Text = model.D_Keyword;
                txtDescription.Text = model.D_Description;
                FCKeditor1.Value = model.D_Content;

            }
        }

        #region 下拉列表框绑定函数定义标记

        //绑定顶级分类
        private void BindDrpClass()
        {
            DataTable dt = GetClassList("classid=1 or classid=2 ").Tables[0];
            MyDL.Items.Clear();
            //MyDL.Items.Add(new ListItem("", "0"));
            DataRow[] drs = dt.Select("ParentID= " + 0, "OrderID asc");

            foreach (DataRow dr in drs)
            {
                string classid = dr["classid"].ToString();
                string classname = dr["ClassName"].ToString();
                //顶级分类显示形式
                classname = "├" + classname;

                MyDL.Items.Add(new ListItem(classname, classid));
                int sonparentid = int.Parse(classid);
                string blank = "├─";
                //递归子分类方法
                //BindNode(sonparentid, dt, blank);
            }
            MyDL.DataBind();
        }
        //绑定子分类
        private void BindNode(int parentid, DataTable dt, string blank)
        {
            DataRow[] drs = dt.Select("ParentID= " + parentid, "OrderID asc");
            foreach (DataRow dr in drs)
            {
                string classid = dr["classid"].ToString();
                string classname = dr["ClassName"].ToString();

                classname = blank + classname;
                MyDL.Items.Add(new ListItem(classname, classid));

                int sonparentid = int.Parse(classid);
                string blank2 = blank + "──";

                BindNode(sonparentid, dt, blank2);
            }
        }
        public DataSet GetClassList(string strWhere)
        {
            string strsql = "select * from PageClass";
            if (strWhere.Trim() != "")
            {
                strsql = strsql + " where " + strWhere;
            }

            return DbHelperOledb.Query(strsql);
        }

        #endregion;
        protected void Sub_Click(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "jbnews", RightStatus.Update)) {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Model.PageClass model = new Model.PageClass();
            model.classid = Convert.ToInt32(Request.QueryString["P_id"]);
            model.ClassName = txtTitle.Text;
            model.ParentID = Convert.ToInt32(MyDL.SelectedValue);
            model.username = txtAuthor.Text.Trim();
            model.D_Keyword = txtKeyword.Text;
            model.D_Description = txtDescription.Text;
            model.D_Content = FCKeditor1.Value;

            bll.Update(model);
            Response.Redirect("jbManage.aspx");
        }
        
}
}