using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DBUtility;
using Helper;
using System.IO;
 
public partial class adminaspx_transzone_TeamEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Select))
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

            BLL.TransTeam bll = new BLL.TransTeam();          
            ListItem lt = new ListItem("男","0");
            ListItem lt1 = new ListItem("女", "1");
            ddl_avater.Items.Add(lt);
            ddl_avater.Items.Add(lt1);

            BindClass();
            if (!string.IsNullOrEmpty(Request.QueryString["P_id"]))
            {
                int SwID = Convert.ToInt32(Request.QueryString["SwId"]);
                Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                Model.TransTeam model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]),web);
                tid.Text = model.tid.ToString();
                tname.Text = model.tname;
                ddl_avater.SelectedValue = model.avater.ToString();
                ddlCategory.SelectedValue = model.typeid.ToString();
                this.imgpath.Text = model.imgpath;
                this.xueli.Text = model.xueli;
                this.home.Text = model.home;
                this.descript.Text = model.descript;
                //cbxWeb.Enabled = false;

                

                Button1.Text = "保存";
                
            }

            cbxWeb.Enabled = false;
        }
    }

    private void BindClass()
    {
        ddlCategory.Items.Clear();
        BLL.TransTeam bll = new BLL.TransTeam();
        DataView dv = bll.GetListTeamType("").Tables[0].DefaultView;
        for (int i = 0; i < dv.Count; i++)
        {
            ddlCategory.Items.Add(new ListItem(dv[i]["NC_ClassName"].ToString(), dv[i]["NC_ID"].ToString()));
        }

        //BLL.TransTeam bll = new BLL.TransTeam();
        //ArrayList list = new ArrayList();
        //ddlCategory.Items.Clear();
        //int selectCount = 0;

        //for (int i = 0; i < this.cbxWeb.Items.Count; i++)
        //{

        //    DataView dv = bll.GetListTeamType("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
        //    for (int j = 0; j < dv.Count; j++)
        //    {
        //        if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["NC_ClassName"].ToString())))
        //        {
        //            ListItem item = new ListItem();
        //            item.Text = dv[j]["NC_ClassName"].ToString();
        //            this.ddlCategory.Items.Add(item);
        //        }
        //        else
        //        {
        //            if (!list.Contains(new ListItem(dv[j]["NC_ClassName"].ToString(), "")))
        //            {
        //                for (int k = 0; k < 2; k++)
        //                {
        //                    ListItem item = new ListItem();
        //                    item.Text = dv[j]["NC_ClassName"].ToString();
        //                    list.Add(item);
        //                }
        //            }
        //            else
        //            {
        //                ListItem item = new ListItem();
        //                item.Text = dv[j]["NC_ClassName"].ToString();
        //                item.Value = "";
        //                list.Add(item);
        //            }
        //        }
        //    }
        //    selectCount++;





        //}
        ////计算重复
        //if (selectCount == 0)
        //{
        //    int listCount = 1;
        //    this.ddlCategory.Items.Clear();
        //    for (int i = 0; i < list.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < list.Count; j++)
        //        {
        //            if (list[i].ToString() == list[j].ToString())
        //            {
        //                listCount++;
        //            }
        //        }
        //        if (listCount == cbxWeb.Items.Count - 1)
        //        {
        //            this.ddlCategory.Items.Add(list[i] as ListItem);
        //        }
        //        listCount = 1;
        //    }
        //}
        //else if (selectCount > 1)
        //{
        //    int listCount = 1;
        //    this.ddlCategory.Items.Clear();
        //    for (int i = 0; i < list.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < list.Count; j++)
        //        {
        //            if (list[i].ToString() == list[j].ToString())
        //            {
        //                listCount++;
        //            }
        //        }
        //        if (listCount == selectCount)
        //        {
        //            this.ddlCategory.Items.Add(list[i] as ListItem);
        //        }
        //        listCount = 1;
        //    }
        //}

        //ddlCategory.Items.Insert(0, new ListItem("", ""));
    }

    protected void Sub_Click(object sender, EventArgs e)
    {
        if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update))
        {
            //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
            //return;
            MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
        }

        Model.TransTeam model = new Model.TransTeam();
        BLL.TransTeam bll = new BLL.TransTeam();
        model.tname = tname.Text;       
        model.avater = Convert.ToInt32(ddl_avater.SelectedValue);
        //model.typeid = Convert.ToInt32(ddlCategory.SelectedValue);
        model.imgpath = imgpath.Text.Trim();
        model.xueli = xueli.Text;
        model.descript = descript.Text;
        model.home = home.Text;
        model.typeid = Convert.ToInt32(ddlCategory.SelectedValue);
        if (string.IsNullOrEmpty(tid.Text))
        {
            bll.Add(model, new CbxSubwebSingle().GetWebModel());
            
            //if (bll.Exists(model.title))
            //    MessageBox.Show(this, "相同Logo名稱已經存在");
            //else
            //{
            //if (cbxWeb.Items[0].Selected && Session["Admin"].ToString().ToLower() == "admin")//全站
            //{
            //    for (int i = 0; i < cbxWeb.Items.Count; i++)
            //    {
            //        int SwID = Convert.ToInt32(cbxWeb.Items[i].Value);
            //        Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
            //        DataTable dt = new BLL.TransTeam().GetListTeamType("NC_ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0];
            //        if (dt.Rows.Count > 0)
            //        {
            //            model.typeid = Convert.ToInt32(dt.Rows[0]["NC_Id"]);
            //            bll.Add(model, web);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < cbxWeb.Items.Count; i++)
            //    {
            //        if (cbxWeb.Items[i].Selected)
            //        {
            //            int SwID = Convert.ToInt32(cbxWeb.Items[i].Value);
            //            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
            //            DataTable dt = new BLL.TransTeam().GetListTeamType("NC_ClassName='" + ddlCategory.SelectedItem.Text + "'", web).Tables[0];
            //            if (dt.Rows.Count > 0)
            //            {
            //                model.typeid = Convert.ToInt32(dt.Rows[0]["NC_Id"]);
            //                bll.Add(model, web);
            //            }
                           
            //        }
            //    }
            //}
            Response.Redirect("TeamList.aspx");

            
            //}
        }
        else
        {
            model.tid = Convert.ToInt32(tid.Text);

            //int SwID = Convert.ToInt32(Request.QueryString["SwId"]);
            //Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);

            if (bll.Update(model, new CbxSubwebSingle().GetWebModel()))
            {
                Response.Redirect("TeamList.aspx");
            }
            else
            {
                MessageBox.Show(this, "修改失敗");
            }
        }
    }

    private void Reset()
    {
        BLL.TransTeam bll = new BLL.TransTeam();
        tid.Text = "";
        tname.Text = "";
       
        Button1.Text = "新增";
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        Reset();
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
            this.imgpath.Text = "UploadFiles/" + newName;
            //上传缩略图
            AutoThumb.MakeThumbnail(SaveSoft, 160, 140);
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "error", "alert('請選擇要上傳的圖片');", true);
            return;
        }
    }

    protected void cbxWeb_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindClass();
    }
}
