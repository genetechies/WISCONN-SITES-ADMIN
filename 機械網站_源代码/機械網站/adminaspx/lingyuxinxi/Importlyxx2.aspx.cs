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

namespace Web.Admin.Product {
    public partial class ImportOut : System.Web.UI.Page {

        public DataTable table;
        public string category_id;


        protected void Page_Load(object sender, EventArgs e) {
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
                    else if (Request["action"] == "importconfirm")
                    {
                        this.GetProduct();
                    }
                    else if (Request["action"] == "importinsert")
                    {
                        this.AddProducts();
                    }
                }
            }

        }


        private void DownloadExcel()
        {
            string url = "custom.xls";
            base.Response.Redirect(url);
        }


        public void GetProduct()
        {
            Helper.CommonFunction.IsAdmin();

            if (!Utils.IsRight(Session["Admin"].ToString(), "exceldr", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            string filename = "";
            HttpPostedFile file = base.Request.Files.Get("excelfile");
            if (file.FileName != "")
            {
                //filename = base.Server.MapPath("~") + @"\data\productdata.xls";
                filename = base.Server.MapPath("") + @"customdata.xls";
                file.SaveAs(filename);
            }
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename + ";Extended Properties=Excel 8.0;";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            string selectCommandText = "";
            OleDbDataAdapter adapter = null;
            DataSet dataSet = null;
            selectCommandText = "select * from [Sheet1$]";
            adapter = new OleDbDataAdapter(selectCommandText, connectionString);
            dataSet = new DataSet();
            adapter.Fill(dataSet, "table1");
            connection.Close();
            if (dataSet != null)
            {
                this.table = dataSet.Tables[0];
            }
        }


        public void AddProducts()
        {
            if (!Utils.IsRight(Session["Admin"].ToString(), "exceldr", RightStatus.Select))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            StringBuilder err = new StringBuilder();
            string str = (base.Request["productids"] != null) ? base.Request["productids"].ToString() : "";
            try
            {
                if (str != "")
                {
                    string[] strArray = str.TrimEnd(new char[] { ',' }).TrimStart(new char[] { ',' }).Split(new char[] { ',' });
                    if (strArray.Length > 0)
                    {
                        int addcount = 0;
                        int modfiycount = 0;
                        int errcount = 0;
                        for (int i = 0; i < strArray.Length; i++)
                        {
                            string pcode = (Request["pcode[" + strArray[i] + "]"] != null) ? Request["pcode[" + strArray[i] + "]"].ToString() : "";  //編號
                            string pclassname = (Request["pclassname[" + strArray[i] + "]"] != null) ? Request["pclassname[" + strArray[i] + "]"].ToString() : "";  //企業名稱
                            string pclassid = (Request["pclassid[" + strArray[i] + "]"] != null) ? Request["pclassid[" + strArray[i] + "]"].ToString() : "";   //所屬洲類別


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

                            if (bllly.Exists(pclassid.Trim()))   //存在所屬洲類別
                            {
                                lyid = bllly.GetModel_where(" ClassName='" + pclassid.Trim() + "' ").id;
                            }
                            else
                            {
                                moly.ClassName = pclassid.Trim();
                                moly.Sort = 1;
                                moly.guoclassid = gouid;

                                lyid = bllly.Add(moly);


                            }


                            Model.linyuxinxi molyxx = new Model.linyuxinxi();
                            BLL.linyuxinxi blllyxx = new BLL.linyuxinxi();

                            if (blllyxx.Exists(pclassname.Trim()))   //存在领域
                            {
                            }
                            else
                            {
                                molyxx.title = pclassname.Trim();
                                molyxx.Sort = 1;
                                molyxx.linyuclassid = lyid;
                                molyxx.C_show = 1;

                                blllyxx.Add(molyxx);


                            }
                            addcount++;




                            //int classid = 0;
                            //if (int.TryParse(pclassid, out classid))
                            //{
                            //    if (pclass.Exists(classid))
                            //    {
                            //        IList<Model.ProductClass> categorysByParentId = pclass.GetModelList("PC_ParentID=" + classid);
                            //        if ((categorysByParentId != null) && (categorysByParentId.Count > 0))
                            //        {
                            //            err.Append("網頁模版編號:" + pcode + ";錯誤:類別編號不是最下層\r\n");
                            //            errcount++;
                            //        }
                            //        else
                            //        {
                            //            if (!string.IsNullOrEmpty(pcode))
                            //            {
                            //                if (bll.Count("P_Code='" + pcode + "'") == 0)
                            //                {
                            //                    Model.Product product = new Model.Product();

                            //                    product.P_SortKey = bll.GetMaxSortKey("") + 1;
                            //                    product.P_Code = pcode;
                            //                    product.P_Name = pname;
                            //                    product.P_PhotoUrl = "uploadfiles/" + pimageurl;
                            //                    product.P_ClassID = classid;
                            //                    DateTime now = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            //                    product.P_Uptime = now;
                            //                    product.P_ModName = "";
                            //                    product.P_Modtime = now;
                            //                    product.P_CreateName = Session["Admin"].ToString();
                            //                    product.P_IsShow = 0;
                            //                    product.P_State = 1;
                            //                    bll.Add(product);
                            //                    addcount++;
                            //                }
                            //                else
                            //                {
                            //                    Model.Product product = bll.GetModel(pcode);
                            //                    product.P_Name = pname;
                            //                    product.P_PhotoUrl = "uploadfiles/" + pimageurl;
                            //                    product.P_ClassID = classid;
                            //                    product.P_ModName = Session["Admin"].ToString();
                            //                    product.P_Modtime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            //                    product.P_State = 1;
                            //                    bll.Update(product);
                            //                    modfiycount++;
                            //                }
                            //            }
                            //            else
                            //            {
                            //                err.Append("網頁模版編號: ;錯誤:網頁模版編號有誤\r\n");
                            //                errcount++;
                            //            }
                            //        }
                            //    }
                            //    else
                            //    {
                            //        err.Append("網頁模版編號:" + pcode + ";錯誤:類別編號不存在\r\n");
                            //        errcount++;
                            //    }
                            //}
                            //else
                            //{
                            //    err.Append("網頁模版編號:" + pcode + ";錯誤:類別編號有誤\r\n");
                            //    errcount++;
                            //}
                        }
                        Session["Info"] = err.ToString();
                        Session["AddCount"] = addcount;
                        Session["ModfiyCount"] = modfiycount;
                        Session["ErrCount"] = errcount;
                    }
                }
            }
            catch (Exception)
            {
                //Response.Redirect("error.aspx?err=網頁模版訊息添加失敗!");
                MyTool.alertback("匯入領域廠商信息添加失敗!");
                return;
            }

            //Response.Redirect("success.aspx?success=網頁模版訊息添加成功!&backurl=Manage.aspx&otherurl=AutoUpload.aspx&action=add&title=網頁模版");

            MyTool.alert("匯入領域廠商信息成功!共添加" + Session["AddCount"] + "條數據", "Manage.aspx");

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
        //            if (dt.Rows[0][0].ToString().Trim() == "編號" && dt.Rows[0][1].ToString().Trim() == "企業名稱" && dt.Rows[0][2].ToString().Trim() == "所屬領域類別" && dt.Rows[0][3].ToString().Trim() == "所屬領域類別")
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

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    bool b = Upload(FileUpload1);  // 上传excel文件   
        //    if (!b)
        //    {
        //        return;
        //    }
        //    string name = FileUpload1.FileName;
        //    string filepath = Server.MapPath("~/UploadFiles/") + name;


        //    StreamReader fileReader = new StreamReader(filepath, Encoding.Default);
        //    try
        //    {
        //        //是否为第一行（如果HeadYes为TRUE，则第一行为标题行）
        //        int lsi = 0;
        //        //列之间的分隔符
        //        char cv = ',';
        //        bool drok = false;
        //        while (fileReader.EndOfStream == false)
        //        {
        //            string line = fileReader.ReadLine();
        //            string[] y = line.Split(cv);
        //            //第一行为标题行

        //                //第一行
        //                if (lsi == 0)
        //                {
        //                    //for (int i = 0; i < y.Length; i++)
        //                    //{
        //                    //    dt.Columns.Add(y[i].Trim().ToString());
        //                    //}

                            
        //                }
        //                //从第二列开始为数据列
        //                else
        //                {
        //                    //for (int i = 0; i < y.Length; i++)
        //                    //{
        //                    //    //dr[i] = y[i].Trim();
        //                    //}

        //                        //Model.guoclass moguo = new Model.guoclass();
        //                        //BLL.guoclass bllguo = new BLL.guoclass();

        //                        int gouid = 0;

        //                        //if (bllguo.Exists(y[3].Trim()))   //存在国家
        //                        //{
        //                        //    gouid = bllguo.GetModel_where(" NC_ClassName='" + y[3].Trim()+"' ").Id;
        //                        //}
        //                        //else
        //                        //{
        //                        //    moguo.ClassName = y[3].Trim();
        //                        //    moguo.Sort = 1;

        //                        //    gouid = bllguo.Add(moguo);

        //                        //}

        //                        Model.linyuclass moly = new Model.linyuclass();
        //                        BLL.linyuclass bllly = new BLL.linyuclass();
        //                        int lyid = 0;

        //                        if (bllly.Exists(y[2].Trim()))   //存在领域
        //                        {
        //                            lyid = bllly.GetModel_where(" ClassName='" + y[2].Trim() + "' ").id;
        //                        }
        //                        else
        //                        {
        //                            moly.ClassName = y[2].Trim();
        //                            moly.Sort = 1;
        //                            moly.guoclassid = gouid;

        //                            lyid = bllly.Add(moly);


        //                        }


        //                        Model.linyuxinxi molyxx = new Model.linyuxinxi();
        //                        BLL.linyuxinxi blllyxx = new BLL.linyuxinxi();

        //                        if (blllyxx.Exists(y[1].Trim()))   //存在领域
        //                        {
        //                        }
        //                        else
        //                        {
        //                            molyxx.title = y[1].Trim();
        //                            molyxx.Sort = 1;
        //                            molyxx.linyuclassid = lyid;
        //                            molyxx.C_show = 1;

        //                            blllyxx.Add(molyxx);


        //                        }


        //                        drok = true;





                            

                            

                            

        //                }


        //            //第一行不为标题行

        //            //else
        //            //{

        //            //    if (lsi == 0)
        //            //    {
        //            //        for (int i = 0; i < y.Length; i++)
        //            //        {
        //            //            dt.Columns.Add(i.ToString());
        //            //        }
        //            //        lsi++;
        //            //    }

        //            //    DataRow dr = dt.NewRow();

        //            //    for (int i = 0; i < y.Length; i++)
        //            //    {
        //            //        dr[i] = y[i].Trim();
        //            //    }
        //            //    dt.Rows.Add(dr);
        //            //}


        //                lsi++;
        //        }

        //        if (drok)
        //        {
        //            MyTool.alert("匯入成功", "manage.aspx");
        //        }
        //        else
        //        {
        //            MyTool.alert("匯入有誤");
        //        }

        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        fileReader.Close();
        //        fileReader.Dispose();
        //    }


        //}

        //private bool Upload(FileUpload myFileUpload)
        //{
        //    bool flag = false;
        //    //是否允许上载   
        //    bool fileAllow = false;
        //    //设定允许上载的扩展文件名类型 
        //    string[] allowExtensions = { ".csv" };


        //    //取得网站根目录路径   
        //    string path = HttpContext.Current.Request.MapPath("~/UploadFiles/");
        //    //检查是否有文件案   
        //    if (myFileUpload.HasFile)
        //    {
        //        //取得上传文件之扩展文件名，并转换成小写字母   
        //        string fileExtension = System.IO.Path.GetExtension(myFileUpload.FileName).ToLower();
        //        Session["fileExtension"] = fileExtension.ToString();
        //        //检查扩展文件名是否符合限定类型   
        //        for (int i = 0; i < allowExtensions.Length; i++)
        //        {
        //            if (Session["fileExtension"].ToString() == allowExtensions[i])
        //            {
        //                fileAllow = true;

        //            }
        //        }

        //        if (fileAllow)
        //        {
        //            try
        //            {
        //                //存储文件到文件夹  
        //                //string filenameup = DateTime.Now.ToString("yyyy-MM-dd") + Session["fileExtension"].ToString();
        //                myFileUpload.SaveAs(path + myFileUpload.FileName);
        //                //myFileUpload.SaveAs(filenameup);
        //                //lblMes.Text = "文件导入成功";
        //                flag = true;
        //            }
        //            catch (Exception ex)
        //            {
        //                //lblMes.Text += ex.Message;
        //                Response.Write("<script language=javascript>alert('" + ex.Message + "');</script>");
        //                flag = false;

        //            }
        //        }
        //        else
        //        {
        //            //lblMes.Text = "不允许上载：" + myFileUpload.PostedFile.FileName + "，只能上传xls的文件，请检查！";
        //            string temp = myFileUpload.PostedFile.FileName.Replace("\\", "\\\\");

        //            Response.Write("<script language=javascript>alert('不允許匯入：" + temp + "，只能匯入csv格式的文件，請檢查！');</script>");
        //            flag = false;
        //        }
        //    }
        //    else
        //    {
        //        //lblMes.Text = "请选择要导入的excel文件!";
        //        Response.Write("<script language=javascript>alert('請選著要匯入的csv文件!');</script>");
        //        flag = false;
        //    }
        //    return flag;
        //}

        ////public DataSet ExcelDataSource(string filepath, string sheetname)
        ////{
        ////    string strConn;
        ////    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
        ////    //strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0;";
        ////    OleDbConnection conn = new OleDbConnection(strConn);
        ////    OleDbDataAdapter oada = new OleDbDataAdapter("select * from [" + sheetname + "]", strConn);
        ////    DataSet ds = new DataSet();
        ////    oada.Fill(ds);
        ////    conn.Close();
        ////    return ds;
        ////}

        ////public ArrayList ExcelSheetName(string filepath)
        ////{
        ////    ArrayList al = new ArrayList();
        ////    string strConn;
        ////    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=Excel 8.0;";
        ////    //strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=Excel 12.0;";
        ////    OleDbConnection conn = new OleDbConnection(strConn);
        ////    conn.Open();
        ////    DataTable sheetNames = conn.GetOleDbSchemaTable
        ////    (System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
        ////    conn.Close();
        ////    foreach (DataRow dr in sheetNames.Rows)
        ////    {
        ////        al.Add(dr[2]);
        ////    }
        ////    return al;
        ////}
}
}