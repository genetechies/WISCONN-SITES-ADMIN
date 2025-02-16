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
using System.IO;
using System.Data.OleDb;
using System.Text;
using Helper;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;


public partial class Admin_Friendly_Importfriendly : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();

            if (!Utils.IsRight(Session["Admin"].ToString(), "friendlyupdown", RightStatus.Insert))
            {
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            if (Request["action"] != null)
            {
                if (Request["action"] == "downloadexcel")
                {
                    this.DownloadExcel();
                }
            }
            this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
            this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
            this.cbxWeb.DataValueField = "SWID";//绑定的值
            this.cbxWeb.DataBind();


            for (int i = 0; i < cbxWeb.Items.Count; i++)
            {
                cbxWeb.Items[0].Selected = true;
            }

            cbxWeb.Enabled = false;
        }
    }

    private void DownloadExcel()
    {
        string url = "friendly.xls";
        base.Response.Redirect(url);
    }

    public DataTable CreateTable(string where)
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


        DataSet ds = new Friendly_bll().GetList(" F_Id=" + where, new CbxSubweb().GetWebModel());
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = dt.NewRow();
            dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
            dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
            dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
            dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
            dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
            dr["OrderID"] = ds.Tables[0].Rows[i]["OrderID"].ToString();
            dr["Database"] = "";
            dr["SwId"] = "0";
            dr["D_ID_SwId"] = ds.Tables[0].Rows[i]["D_ID"].ToString() + "|" + "0";
            dt.Rows.Add(dr);
        }


        /*
        if (Session["Admin"].ToString().ToLower() == "admin")
        {
            DataSet demo = new BLL.SubWeb().GetAllList();
            for (int j = 0; j < demo.Tables[0].Rows.Count; j++)
            {
                try
                {
                    int SwID = Convert.ToInt32(demo.Tables[0].Rows[j]["SWID"].ToString());
                    Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);

                    DataSet ds = new Friendly_bll().GetList(" F_Id=" + where, web);
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
            string UserName = Session["Admin"].ToString();
            DataSet ds1 = new BLL.Right().GetList("UserName='" + UserName + "' and Rights=0");
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
            {
                Model.SubWeb web1 = new BLL.SubWeb().GetModel(Convert.ToInt32(ds1.Tables[0].Rows[j]["PageName"].ToString()));

                try
                {
                    Model.SubWeb web = new BLL.SubWeb().GetModel(web1.SWID);
                    DataSet ds = new Friendly_bll().GetList(" F_Id=" + where, web);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        dr = dt.NewRow();
                        dr["D_ID"] = Convert.ToInt32(ds.Tables[0].Rows[i]["D_ID"].ToString());
                        dr["D_Title"] = ds.Tables[0].Rows[i]["D_Title"].ToString();
                        dr["ClassName"] = ds.Tables[0].Rows[i]["ClassName"].ToString();
                        dr["D_Editor"] = ds.Tables[0].Rows[i]["D_Editor"].ToString();
                        dr["D_Time"] = ds.Tables[0].Rows[i]["D_Time"].ToString();
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
         * */


        return dt;
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        bool b = Upload(FileUpload1);  // 上传excel文件   
        if (!b)
        {
            return;
        }
        string name = FileUpload1.FileName;
        string filepath = Server.MapPath("~/UploadFiles/") + name;
        DataTable dtFriendly = GetTableFromExcel();
        try
        {
            bool drok = false;
            if (dtFriendly != null && dtFriendly.Rows.Count > 0)
            {
                for (int i = 0; i < dtFriendly.Rows.Count; i++)
                {
                    Friendly_model model = new Friendly_model();
                    Friendly_bll bllguo = new Friendly_bll();
                    AspxToHtml tohtml = new AspxToHtml();

                    model.F_Name = dtFriendly.Rows[i]["廠商名稱"].ToString().Trim();
                    model.F_Url = dtFriendly.Rows[i]["超連結"].ToString().Trim();
                    int f_location = 0;
                    if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "整站")
                    {
                        f_location = 1;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "友好链接" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "友好連結")
                    {
                        f_location = 2;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "首页" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "首頁")
                    {
                        f_location = 3;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "友好链接及首页" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "友好連結及首頁")
                    {
                        f_location = 4;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它页" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它頁")
                    {
                        f_location = 5;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它页及首页" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它頁及首頁")
                    {
                        f_location = 6;
                    }
                    else if (dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它页及友好链接" || dtFriendly.Rows[i]["擺放位置"].ToString().Trim() == "其它頁及友好連結")
                    {
                        f_location = 7;
                    }
                    model.F_Location = f_location;
                    model.F_Author = Session["Admin"].ToString();
                    model.F_Option = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    //DataTable table = CreateTable( dtFriendly.Rows[i]["編號"].ToString().Trim());
                    DataSet dset = DBUtility.DbHelperSQL.Query(string.Format("select * from Friendly where F_Id='{0}' ", dtFriendly.Rows[i]["編號"].ToString().Trim()));

                    if (dset != null && dset.Tables.Count > 0 && dset.Tables[0].Rows.Count > 0)
                    {
                        model.F_Id = Convert.ToInt32(dtFriendly.Rows[i]["編號"].ToString().Trim());
                        //int a;
                        //if (Session["Admin"].ToString().ToLower() == "admin")
                        //{
                        //    a = 1;
                        //}
                        //else
                        //{
                        //    a = 0;
                        //}
                        //for (int k = 0; k < cbxWeb.Items.Count; k++)
                        //{
                        //    int SwId = Convert.ToInt32(cbxWeb.Items[k].Value);
                        //    Model.SubWeb sw = new BLL.SubWeb().GetModel(SwId);
                        //    bllguo.Update(model, sw);
                        //}
                        bllguo.Update(model, new CbxSubweb().GetWebModel());

                    }
                    else
                    {

                        //for (int j = 0; j < cbxWeb.Items.Count; j++)
                        //{

                        //    int SwID = Convert.ToInt32(cbxWeb.Items[j].Value);
                        //    Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
                        //    bllguo.Add(model, web);

                        //}

                        bllguo.Add(model, new CbxSubweb().GetWebModel());
                    }
                    if (f_location == 1)
                    {
                        tohtml.WriteFile("downindex.html");
                        tohtml.WriteFile("downother.html");
                        tohtml.WriteFile("downlink.html");
                    }
                    else if (f_location == 2)
                    {
                        tohtml.WriteFile("downlink.html");
                    }
                    else if (f_location == 3)
                    {
                        tohtml.WriteFile("downindex.html");
                    }
                    else if (f_location == 4)
                    {
                        tohtml.WriteFile("downindex.html");
                        tohtml.WriteFile("downlink.html");
                    }
                    else if (f_location == 5)
                    {
                        tohtml.WriteFile("downother.html");
                    }
                    else if (f_location == 6)
                    {
                        tohtml.WriteFile("downindex.html");
                        tohtml.WriteFile("downother.html");
                    }
                    else if (f_location == 7)
                    {
                        tohtml.WriteFile("downother.html");
                        tohtml.WriteFile("downlink.html");
                    }
                    else
                    {
                    }
                }
                drok = true;
            }
            if (drok)
            {
                MyTool.alert("匯入成功", "manage.aspx");
            }
            else
            {
                MyTool.alert("匯入有誤");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private bool Upload(FileUpload myFileUpload)
    {
        bool flag = false;
        //是否允许上载   
        bool fileAllow = false;
        //设定允许上载的扩展文件名类型 
        string[] allowExtensions = { ".xls" };


        //取得网站根目录路径   
        string path = HttpContext.Current.Request.MapPath("~/UploadFiles/");
        //检查是否有文件案   
        if (myFileUpload.HasFile)
        {
            //取得上传文件之扩展文件名，并转换成小写字母   
            string fileExtension = System.IO.Path.GetExtension(myFileUpload.FileName).ToLower();
            Session["fileExtension"] = fileExtension.ToString();
            //检查扩展文件名是否符合限定类型   
            for (int i = 0; i < allowExtensions.Length; i++)
            {
                if (Session["fileExtension"].ToString() == allowExtensions[i])
                {
                    fileAllow = true;
                }
            }

            if (fileAllow)
            {
                try
                {
                    //存储文件到文件夹  
                    //string filenameup = DateTime.Now.ToString("yyyy-MM-dd") + Session["fileExtension"].ToString();
                    myFileUpload.SaveAs(path + myFileUpload.FileName);
                    //myFileUpload.SaveAs(filenameup);
                    //lblMes.Text = "文件导入成功";
                    flag = true;
                }
                catch (Exception ex)
                {
                    //lblMes.Text += ex.Message;
                    Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
                    flag = false;

                }
            }
            else
            {
                //lblMes.Text = "不允许上载：" + myFileUpload.PostedFile.FileName + "，只能上传xls的文件，请检查！";
                string temp = myFileUpload.PostedFile.FileName.Replace("\\", "\\\\");

                Response.Write("<script language=javascript>alert('不允許匯入：" + temp + "，只能匯入csv格式的文件，請檢查！');</script>");
                flag = false;
            }
        }
        else
        {
            //lblMes.Text = "请选择要导入的excel文件!";
            Response.Write("<script language=javascript>alert('請選著要匯入的csv文件!');</script>");
            flag = false;
        }
        return flag;
    }

    public DataTable GetTableFromExcel()
    {
        DataTable table = new DataTable();
        if (this.FileUpload1.HasFile)
        {

            HSSFWorkbook workbook = new HSSFWorkbook(this.FileUpload1.FileContent);
            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);

            HSSFRow headerRow = (HSSFRow)sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            for (int i = headerRow.FirstCellNum; i < cellCount; i++)
            {
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                table.Columns.Add(column);
            }

            int rowCount = sheet.LastRowNum;

            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                HSSFRow row = (HSSFRow)sheet.GetRow(i);
                DataRow dataRow = table.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    if (row.GetCell(j) != null)
                        dataRow[j] = row.GetCell(j).ToString();
                }

                table.Rows.Add(dataRow);
            }

            workbook = null;
            sheet = null;

        }
        return table;
    }

}
