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
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            BLL.TransTeam bll = new BLL.TransTeam();          
            ListItem lt = new ListItem("男","0");
            ListItem lt1 = new ListItem("女", "1");
            ddl_avater.Items.Add(lt);
            ddl_avater.Items.Add(lt1);

            BindClass();
            if (!string.IsNullOrEmpty(Request.QueryString["P_id"]))
            {
                Model.TransTeam model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]));
                tid.Text = model.tid.ToString();
                tname.Text = model.tname;
                ddl_avater.SelectedValue = model.avater.ToString();
                ddl_type.SelectedValue = model.typeid.ToString();
                this.imgpath.Text = model.imgpath;
                this.xueli.Text = model.xueli;
                this.home.Text = model.home;
                this.descript.Text = model.descript;
               
            }
        }
    }

    private void BindClass()
    {
        BLL.TransTeam bll = new BLL.TransTeam();
        DataView dv = bll.GetListTeamType("").Tables[0].DefaultView;
        for (int i = 0; i < dv.Count; i++)
        {
            ddl_type.Items.Add(new ListItem(dv[i]["NC_ClassName"].ToString(), dv[i]["NC_ID"].ToString()));
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

        Model.TransTeam model = new Model.TransTeam();
        BLL.TransTeam bll = new BLL.TransTeam();
        model.tname = tname.Text;       
        model.avater = Convert.ToInt32(ddl_avater.SelectedValue);
        model.typeid = Convert.ToInt32(ddl_type.SelectedValue);
        model.imgpath = imgpath.Text.Trim();
        model.xueli = xueli.Text;
        model.descript = descript.Text;
        model.home = home.Text;
        if (string.IsNullOrEmpty(tid.Text))
        {           
            
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
                Response.Redirect("TeamList.aspx");
            }
            //}
        }
        else
        {
            model.tid = Convert.ToInt32(tid.Text);           
            if (bll.Update(model))
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

}
