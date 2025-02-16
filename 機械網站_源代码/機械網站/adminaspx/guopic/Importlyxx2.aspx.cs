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

                if (!Utils.IsRight(Session["Admin"].ToString(), "logodr", RightStatus.Insert))
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
            string url = "logo.xls";
            base.Response.Redirect(url);
        }




        public void GetProduct()
        {
            Helper.CommonFunction.IsAdmin();

            if (!Utils.IsRight(Session["Admin"].ToString(), "logodr", RightStatus.Insert))
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
                filename = base.Server.MapPath("") + @"logodata.xls";
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
            if (!Utils.IsRight(Session["Admin"].ToString(), "excelupload", RightStatus.Insert))
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
                            string pclassname = (Request["pclassname[" + strArray[i] + "]"] != null) ? Request["pclassname[" + strArray[i] + "]"].ToString() : "";  //LOG圖片名稱
                            string pclassid = (Request["pclassid[" + strArray[i] + "]"] != null) ? Request["pclassid[" + strArray[i] + "]"].ToString() : "";   //LOG圖文件
                            string pname = (Request["pname[" + strArray[i] + "]"] != null) ? Request["pname[" + strArray[i] + "]"].ToString() : "";   //服務項目類別


                            Model.guoclass moguo = new Model.guoclass();
                            BLL.guoclass bllguo = new BLL.guoclass();

                            int gouid = 0;

                            if (bllguo.Exists(pname.Trim()))   //存在服務項目類別
                            {
                                gouid = bllguo.GetModel_where(" NC_ClassName='" + pname.Trim() + "' ").Id;
                            }
                            else
                            {
                                moguo.ClassName = pname.Trim();
                                moguo.Sort = 1;

                                gouid = bllguo.Add(moguo);

                            }

                            //Model.linyuclass moly = new Model.linyuclass();
                            //BLL.linyuclass bllly = new BLL.linyuclass();
                            //int lyid = 0;

                            //if (bllly.Exists(y[2].Trim()))   //存在领域
                            //{
                            //    lyid = bllly.GetModel_where(" ClassName='" + y[2].Trim() + "' ").id;
                            //}
                            //else
                            //{
                            //    moly.ClassName = y[2].Trim();
                            //    moly.Sort = 1;
                            //    moly.guoclassid = gouid;

                            //    lyid = bllly.Add(moly);


                            //}


                            Model.guopic moguopic = new Model.guopic();
                            BLL.guopic bllguopic = new BLL.guopic();

                            //if (blllyxx.Exists(y[1].Trim()))   //存在领域
                            //{
                            //}
                            //else
                            //{
                            moguopic.title = pclassname.Trim();
                            moguopic.Sort = (new BLL.guopic().Count("1=1") + 1);
                            moguopic.guoclassid = gouid;
                            moguopic.pic = "UploadFiles/" + pclassid.Trim();

                            bllguopic.Add(moguopic);
                            addcount++;

                            //}
                            
                            
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
                MyTool.alertback("匯入LOGO圖信息添加失敗!");
                return;
            }

            //Response.Redirect("success.aspx?success=網頁模版訊息添加成功!&backurl=Manage.aspx&otherurl=AutoUpload.aspx&action=add&title=網頁模版");

            MyTool.alert("匯入LOGO圖信息成功!共添加" + Session["AddCount"] + "條數據", "Manage.aspx");

        }

        
}
}