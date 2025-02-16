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

namespace Web.Admin.Product
{
    public partial class ImportOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Helper.CommonFunction.IsAdmin();

                if (!Utils.IsRight(Session["Admin"].ToString(), "exceldr", RightStatus.Select))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
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
            string url = "custom.csv";
            base.Response.Redirect(url);
        }




        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    bool b = Upload(FileUpload1);  // 上传excel文件   
        //    if (!b)
        //    {
        //        return;
        //    }
        //    string name = FileUpload1.FileName;
        //    string filepath = Server.MapPath(@"~/UploadFiles/") + name;


        //    string sql = "select * from " + name;//查询语句

        //    DataTable dt = new DataTable();

        //    string mystring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filepath + ";" + @"Extended Properties=""text;HDR=Yes;FMT=Delimited""";

        //    OleDbConnection cnnxls = new OleDbConnection(mystring);
        //    try
        //    {

        //        cnnxls.Open();//打开数据库连接

        //        OleDbDataAdapter myda = new OleDbDataAdapter(sql, cnnxls);
        //        myda.Fill(dt);

        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            if (dt.Rows[0][0].ToString().Trim() == "編號" && dt.Rows[0][1].ToString().Trim() == "企業名稱" && dt.Rows[0][2].ToString().Trim() == "所屬洲類別" && dt.Rows[0][3].ToString().Trim() == "所屬洲類別")
        //            {
        //            }
        //            else
        //            {
        //                MyTool.alert("匯入格式有誤");
        //            }

        //            if (i > 0)
        //            {
        //                Model.guoclass moguo = new Model.guoclass();
        //                BLL.guoclass bllguo=new BLL.guoclass();

        //                int gouid = 0;

        //                if (bllguo.Exists(dt.Rows[i][3].ToString()))   //存在国家
        //                {
        //                }
        //                else
        //                {
        //                    moguo.ClassName = dt.Rows[i][3].ToString();
        //                    moguo.Sort=1;

        //                    gouid=bllguo.Add(moguo);

        //                }

        //                Model.linyuclass moly = new Model.linyuclass();
        //                BLL.linyuclass bllly = new BLL.linyuclass();
        //                int lyid = 0;

        //                if (bllly.Exists(dt.Rows[i][2].ToString()))   //存在领域
        //                {
        //                }
        //                else
        //                {
        //                    moly.ClassName = dt.Rows[i][2].ToString();
        //                    moly.Sort = 1;
        //                    moly.guoclassid = gouid;

        //                    lyid=bllly.Add(moly);


        //                }


        //                Model.linyuxinxi molyxx = new Model.linyuxinxi();
        //                BLL.linyuxinxi blllyxx = new BLL.linyuxinxi();

        //                if (blllyxx.Exists(dt.Rows[i][1].ToString()))   //存在领域
        //                {
        //                }
        //                else
        //                {
        //                    molyxx.title = dt.Rows[i][1].ToString();
        //                    molyxx.Sort = 1;
        //                    molyxx.linyuclassid = lyid;
        //                    molyxx.C_show=1;

        //                    blllyxx.Add(molyxx);


        //                }

        //            }

        //        }

        //        MyTool.alert("匯入成功","manage.aspx");


        //        cnnxls.Close();

        //        //System.IO.File.Delete(strpath);//删除上传的文件
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        //    }
        //    finally
        //    {
        //        cnnxls.Close();
        //    }



        //}

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
                        //for (int i = 0; i < y.Length; i++)
                        //{
                        //    //dr[i] = y[i].Trim();
                        //}

                        //Model.guoclass moguo = new Model.guoclass();
                        //BLL.guoclass bllguo = new BLL.guoclass();

                        int gouid = 0;

                        //if (bllguo.Exists(y[3].Trim()))   //存在国家
                        //{
                        //    gouid = bllguo.GetModel_where(" NC_ClassName='" + y[3].Trim()+"' ").Id;
                        //}
                        //else
                        //{
                        //    moguo.ClassName = y[3].Trim();
                        //    moguo.Sort = 1;

                        //    gouid = bllguo.Add(moguo);

                        //}

                        Model.linyuclass moly = new Model.linyuclass();
                        BLL.linyuclass bllly = new BLL.linyuclass();
                        int lyid = 0;

                        if (bllly.Exists(y[2].Trim()))   //存在领域
                        {
                            lyid = bllly.GetModel_where(" ClassName='" + y[2].Trim() + "' ").id;
                        }
                        else
                        {
                            moly.ClassName = y[2].Trim();
                            moly.Sort = 1;
                            moly.guoclassid = gouid;

                            bllly.Add(moly);

                            lyid = bllly.GetModel_where(" ClassName='" + y[2].Trim() + "' ").id;


                        }


                        Model.linyuxinxi molyxx = new Model.linyuxinxi();
                        BLL.linyuxinxi blllyxx = new BLL.linyuxinxi();

                        molyxx.title = y[1].Trim();
                        molyxx.Sort = 1;
                        molyxx.linyuclassid = lyid;
                        molyxx.C_show = 1;

                        DataTable dt = blllyxx.GetList(" id=" + y[0].Trim()).Tables[0];
                        if (dt != null && dt.Rows.Count > 0)   //存在领域
                        {
                            molyxx.id = Convert.ToInt32(y[0].Trim());
                            blllyxx.Update(molyxx);
                        }
                        else
                        {
                            blllyxx.Add(molyxx);
                        }


                        drok = true;











                    }


                    //第一行不为标题行

                    //else
                    //{

                    //    if (lsi == 0)
                    //    {
                    //        for (int i = 0; i < y.Length; i++)
                    //        {
                    //            dt.Columns.Add(i.ToString());
                    //        }
                    //        lsi++;
                    //    }

                    //    DataRow dr = dt.NewRow();

                    //    for (int i = 0; i < y.Length; i++)
                    //    {
                    //        dr[i] = y[i].Trim();
                    //    }
                    //    dt.Rows.Add(dr);
                    //}


                    lsi++;
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

        private bool Upload(FileUpload myFileUpload)
        {
            bool flag = false;
            //是否允许上载   
            bool fileAllow = false;
            //设定允许上载的扩展文件名类型 
            string[] allowExtensions = { ".csv" };


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

        //public DataSet ExcelDataSource(string filepath, string sheetname)
        //{
        //    string strConn;
        //    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
        //    //strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0;";
        //    OleDbConnection conn = new OleDbConnection(strConn);
        //    OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sheetname + "]", strConn);
        //    DataSet ds = new DataSet();
        //    oada.Fill(ds);
        //    conn.Close();
        //    return ds;
        //}

        //public ArrayList ExcelSheetName(string filepath)
        //{
        //    ArrayList al = new ArrayList();
        //    string strConn;
        //    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
        //    //strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0;";
        //    OleDbConnection conn = new OleDbConnection(strConn);
        //    conn.Open();
        //    DataTable sheetNames = conn.GetOleDbSchemaTable
        //    (System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
        //    conn.Close();
        //    foreach (DataRow dr in sheetNames.Rows)
        //    {
        //        al.Add(dr[2]);
        //    }
        //    return al;
        //}
    }
}