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

public partial class Admin_Partners_ImportPartners : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Helper.CommonFunction.IsAdmin();

            if (!Utils.IsRight(Session["Admin"].ToString(), "partnersupdown", RightStatus.Insert))
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
        }
    }

    private void DownloadExcel()
    {
        string url = "partners.xls";
        base.Response.Redirect(url);
    }

    /*
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool b = Upload(FileUpload1);  // 上传excel文件   
        if (!b)
        {
            return;
        }
        string name = FileUpload1.FileName;
        string filepath = Server.MapPath("~/UploadFiles/") + name;

        StreamReader fileReader = new StreamReader(filepath, Encoding.Default);
        try
        {
            //是否为第一行（如果HeadYes为TRUE，则第一行为标题行）
            int lsi = 0;
            //列之间的分隔符
            char cv = ',';
            bool drok = false;
            while (fileReader.EndOfStream == false)
            {
                string line = fileReader.ReadLine();
                if (line != "")
                {
                    string[] y = line.Split(cv);
                    //第一行为标题行

                    //第一行
                    if (lsi == 0)
                    {
                        //for (int i = 0; i < y.Length; i++)
                        //{
                        //    dt.Columns.Add(y[i].Trim().ToString());
                        //}


                    }
                    //从第二列开始为数据列
                    else
                    {
                        Partners_model model = new Partners_model();
                        Partners_bll bllguo = new Partners_bll();
                        AspxToHtml tohtml = new AspxToHtml();

                        model.F_Name = y[1].Trim();
                        model.F_Url = y[2].Trim();
                        int f_location = 0;
                        if (y[3].Trim() == "整站")
                        {
                            f_location = 1;
                        }
                        else if (y[3].Trim() == "友好連結")
                        {
                            f_location = 2;
                        }
                        else if (y[3].Trim() == "首頁")
                        {
                            f_location = 3;
                        }
                        else if (y[3].Trim() == "友好連結及首頁")
                        {
                            f_location = 4;
                        }
                        model.F_Location = f_location;
                        model.F_Author = Session["Admin"].ToString();
                        model.F_Option = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd"));

                        DataTable table = bllguo.GetList(" F_Id=" + y[0].Trim()).Tables[0];
                        if (table != null && table.Rows.Count > 0)
                        {
                            model.F_Id = Convert.ToInt32(y[0].Trim());
                            bllguo.Update(model);
                        }
                        else
                        {
                            bllguo.Add(model);
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
                        else
                        {
                        }
                        drok = true;
                    }
                    lsi++;
                }
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

        finally
        {
            fileReader.Close();
            fileReader.Dispose();
        }
    }
    */
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool b = Upload(FileUpload1);  // 上传excel文件   
        if (!b)
        {
            return;
        }
        string name = FileUpload1.FileName;
        string filepath = Server.MapPath("~/UploadFiles/") + name;

        DataTable dtPartners = GetTableFromExcel();

        try
        {
            bool drok = false;
            if (dtPartners != null && dtPartners.Rows.Count > 0)
            {
                for (int i = 0; i < dtPartners.Rows.Count; i++)
                {
                    Partners_model model = new Partners_model();
                    Partners_bll bllguo = new Partners_bll();
                    AspxToHtml tohtml = new AspxToHtml();

                    model.F_Name = dtPartners.Rows[i]["廠商名稱"].ToString().Trim();
                    model.F_Url = dtPartners.Rows[i]["超連結"].ToString().Trim();
                    int f_location = 0;
                    if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "整站")
                    {
                        f_location = 1;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "友好链接" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "友好連結")
                    {
                        f_location = 2;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "首页" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "首頁")
                    {
                        f_location = 3;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "友好链接及首页" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "友好連結及首頁")
                    {
                        f_location = 4;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它页" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它頁")
                    {
                        f_location = 5;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它页及首页" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它頁及首頁")
                    {
                        f_location = 6;
                    }
                    else if (dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它页及友好链接" || dtPartners.Rows[i]["擺放位置"].ToString().Trim() == "其它頁及友好連結")
                    {
                        f_location = 7;
                    }
                    model.F_Location = f_location;
                    model.F_Author = Session["Admin"].ToString();
                    model.F_Option = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    DataTable table = bllguo.GetList(" F_Id=" + dtPartners.Rows[i]["編號"].ToString().Trim()).Tables[0];
                    if (table != null && table.Rows.Count > 0)
                    {
                        model.F_Id = Convert.ToInt32(dtPartners.Rows[i]["編號"].ToString().Trim());
                        bllguo.Update(model);
                    }
                    else
                    {
                        bllguo.Add(model);
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
