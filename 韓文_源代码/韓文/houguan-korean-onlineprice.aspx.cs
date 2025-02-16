using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Data.SqlClient;
using System.Data;
using Helper;
using DBUtility;
using System.Text;
using System.Configuration;

public partial class houguan_korean_onlineprice : System.Web.UI.Page
{
    BLL.Bll_DisableIP bll_disableip = new BLL.Bll_DisableIP();
    private bool ischeck = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
        if (CheckIP(Request.UserHostAddress) >= 3)
        {
            codetr.Style.Value = "display:block";
            ischeck = true;
        }
    }
    private int CheckIP(string ip)
    {
        int count = new BLL.XunJia().GetCountByIP(ip);
        return count;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string ip = Request.UserHostAddress;
        //IP黑名單驗證
        if (bll_disableip.Exists(ip))
        {
            Response.Redirect("houguan-korean-contact.html");
        }
        //1小時內提交超過10次加入黑名單
        if (CheckIP(ip) >= 10)
        {
            Model.Model_DisableIP disableip = new Model.Model_DisableIP();
            disableip.IPAddress = ip;
            disableip.AddDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            bll_disableip.Add(disableip);
        }
        try
        {
            if (username.Value.Trim() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('聯絡人不能為空');</script>");
                return;
            }
            if (!MyTool.CheckUserName(username.Value))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('姓名裡面不能含有特殊字元');</script>");
                return;
            }
            if (!MyTool.IsDigital(tel.Value))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('聯繫電話只能輸入數位');</script>");
                return;
            }
            if (!MyTool.isEmail(email.Value.Trim()))
            {
                //MyTool.alertback("聯絡郵件格式不對");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('聯絡郵件格式不對');</script>");
                return;
            }
            if (!MyTool.IsNumeric(translationamount.Value))
            {
                //MyTool.alertback("估計頁數或字數為空了");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('估計頁數或字數為空了');</script>");
                return;
            }

            if (!MyTool.IsValidDate(posttime.Value.Trim()))
            {
                //MyTool.alertback("交件時間有誤");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('交件時間有誤');</script>");
                return;
            }

            //驗證碼驗證
            if (ischeck)
            {
                string Code = txtCode.Value;
                string validateCode = string.Empty;
                if (Session["NUM_CODE"] == null)
                {
                    //MyTool.alertback("提示：你在登陸頁面停留的時間過長，驗證碼已失效！");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('提示：你在登陸頁面停留的時間過長，驗證碼已失效！');</script>");
                    return;

                }
                else
                {
                    validateCode = Session["NUM_CODE"].ToString();
                }
                if (Code.Equals(""))
                {
                    //MyTool.alertback("驗證碼不能為空！");
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('驗證碼不能為空');</script>");
                    return;
                }
                else
                {
                    if (validateCode.ToLower() != Code.ToLower())
                    {
                        //MyTool.alertback("驗證碼錯誤，請重新輸入！");
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('驗證碼錯誤，請重新輸入！');</script>");
                        return;
                    }
                }
            }

            Model.XunJia mo = new Model.XunJia();

            mo.LinksName = username.Value;
            mo.LinksTel = tel.Value;
            mo.LinksEmail = email.Value;
            mo.SerPro = ddltranslationskill.SelectedItem.Value == "0" ? "" : ddltranslationskill.SelectedItem.Text;
            mo.OrgLanguage = ddllanguagefrom.SelectedItem.Value == "0" ? "" : ddllanguagefrom.SelectedItem.Text;
            mo.ToLanguage = ddllanguageto.SelectedItem.Value == "0" ? "" : ddllanguageto.SelectedItem.Text;

            mo.TxtCount = Convert.ToInt32(translationamount.Value);
            mo.TxtSCount = ddltranslationtype.SelectedItem.Text;
            mo.ispaiban = rty.Checked ? 1 : 0;
            mo.ercijiaogao = rpy.Checked ? 1 : 0;
            mo.rungao = rdy.Checked ? 1 : 0;
            mo.JiaojianTime = Convert.ToDateTime(posttime.Value.Trim());
            mo.gongzuori = updays.Value;
            mo.zhuyicontent = ttbNotes.Text;

            string sUpFileName = "";
            if (file1.HasFile)
            {
                //驗證檔案格式
                if (MyTool.CheckFileType(file1.FileName))
                {
                    //去除檔案名裡面特殊字元
                    string filename = MyTool.StripSpecialSymbol(file1.FileName);
                    string path = Server.MapPath(".") + "\\UpLoadFiles\\" + filename;
                    file1.PostedFile.SaveAs(path);
                    mo.Annex = "/online/UpLoadFiles/" + filename;
                    string url = Request.Url.AbsoluteUri;

                    mo.Annex = url.Substring(0, url.LastIndexOf(@"/")) + "/UpLoadFiles/" + filename;
                }
                else
                {
                    MyTool.alertback("檔案格式錯誤，只能上傳doc|docx|xls|jpg|jpeg|tiff|png|gif|pdf|zip|rar類型檔！");
                }

            }
            else
            {
                mo.Annex = "";
            }

            //mo.addTime=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mo.addTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            mo.ip = ip;
            mo.Finish = 0;

            //BLL.XunJia xj = new BLL.XunJia();
            string Mcon = ConfigurationManager.AppSettings["MConnectionString"];
            //xj.Add(mo);
            string id = "";
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into  " + Mcon + ".dbo.XunJia(LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime,ip,Finish,[Note]) values(@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime,@ip,@Finish,@Note) select @@identity";               
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         ////string sql = "insert into XunJia(LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime) values(@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LinksName", mo.LinksName);
                cmd.Parameters.AddWithValue("@LinksTel", mo.LinksTel);
                cmd.Parameters.AddWithValue("@LinksEmail", mo.LinksEmail);
                cmd.Parameters.AddWithValue("@SerPro", mo.SerPro);
                cmd.Parameters.AddWithValue("@OrgLanguage", mo.OrgLanguage);
                cmd.Parameters.AddWithValue("@ToLanguage", mo.ToLanguage);
                cmd.Parameters.AddWithValue("@TxtCount", mo.TxtCount);
                cmd.Parameters.AddWithValue("@TxtSCount", mo.TxtSCount);
                cmd.Parameters.AddWithValue("@ispaiban", mo.ispaiban);
                cmd.Parameters.AddWithValue("@ercijiaogao", mo.ercijiaogao);
                cmd.Parameters.AddWithValue("@rungao", mo.rungao);
                cmd.Parameters.AddWithValue("@JiaojianTime", mo.JiaojianTime);
                cmd.Parameters.AddWithValue("@gongzuori", mo.gongzuori.ToString());
                cmd.Parameters.AddWithValue("@zhuyicontent", mo.zhuyicontent);
                cmd.Parameters.AddWithValue("@Annex", mo.Annex);
                cmd.Parameters.AddWithValue("@addTime", mo.addTime);
                cmd.Parameters.AddWithValue("@ip", mo.ip);
                cmd.Parameters.AddWithValue("@Finish", mo.Finish);
                cmd.Parameters.AddWithValue("@Note", "來自韩文站點");
                //cmd.ExecuteNonQuery();


                object b = cmd.ExecuteScalar();
                if (b != null)
                {
                    id = b.ToString();
                }

            }
            string address = "";// IpAddress.getIpAddr(mo.ip);
            DbHelperSQL.ExecuteSql(string.Format("update " + Mcon + ".dbo.XunJia set country=N'{0}' where id={1} ", address, id));

            //object b = DbHelperSQL.GetSingle("select top 1 id from XunJia order by addtime desc");
            //if (b != null)
            //{
            //    string address = IpAddress.getIpAddr(ip);
            //    DbHelperSQL.ExecuteSql(string.Format("update XunJia set country=N'{0}' where id={1} ", address, b.ToString()));
            //}

            DataSet ds = GetList();
            if (ds.Tables[0].Rows.Count > 0)
            {
                string touser = "";
                string title = "";
                string tobody = "";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    touser = ds.Tables[0].Rows[i][2].ToString();
                    title = "管理員" + ds.Tables[0].Rows[i][1].ToString() + "你好,後冠翻譯社網站上發在起線上詢價，請注意查看！";
                    tobody = "管理員" + ds.Tables[0].Rows[i][1].ToString() + "你好,後冠翻譯社網站上發在起線上詢價，請注意查看！" +
                        "詢價者大名:" + username.Value + ",聯絡電話:" + tel.Value +
                        ",聯絡郵件:" + email.Value;
                    //touser = "522125549@qq.com";
                    SendEmail(touser, title, tobody);
                }
            }

            MyTool.alert("感謝您的詢價，我們已收到，會儘速請報價專員與您聯絡！", "houguan-korean-onlineprice.aspx");
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('感謝您的詢價，我們已收到，會儘速請報價專員與您聯絡！');localhost.href = localhost.href;</script>");

        }
        catch (Exception ex)
        {
            JsAlert(ex.Message);
            throw new Exception(ex.Message);
        }

    }

    public DataSet GetList()
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * ");
        strSql.Append(" FROM EmailInfo ");
        return DbHelperOledb.Query(strSql.ToString());
    }
    public void SendEmail(string touser, string title, string tobody)
    {
        try
        {
            //MailAddress MessageFrom = new MailAddress("ceshixmarketing@gmail.com"); //寄件者郵箱地址 
            string MessageTo = touser; //收件人郵箱地址 
            string MessageSubject = title; //郵件主題 
            string MessageBody = tobody; //郵件內容 
            if (GmailSend.Send(MessageTo, MessageSubject, MessageBody))
            {
                Response.Write("發送成功");
            }
            else
            {

                if (Send(MessageTo, MessageSubject, MessageBody))
                {
                    Response.Write("發送成功");
                }
                else
                {
                    Response.Write("發送失敗");
                }

            }
        }
        catch { Response.Write("發送失敗"); }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        username.Value = "";
        tel.Value = "";
        email.Value = "";
        ddltranslationskill.SelectedIndex = 0;
        ddllanguagefrom.SelectedIndex = 0;
        ddllanguageto.SelectedIndex = 0;
        translationamount.Value = "";
        ddltranslationtype.SelectedIndex = 0;
        rty.Checked = true;
        rtn.Checked = false;
        rpy.Checked = true;
        rpn.Checked = false;
        rdy.Checked = true;
        rdn.Checked = false;
        posttime.Value = "";
        updays.Value = "";
        ttbNotes.Text = "";

    }


    private void JsAlert(string sMessage)
    {
        string strPopupWeb = "PopupWeb";
        Type csType = this.GetType();
        ClientScriptManager csm = Page.ClientScript;
        if (!csm.IsClientScriptBlockRegistered(csType, strPopupWeb))
        {
            String strModalDialog = "alert('" + sMessage + "');";
            csm.RegisterClientScriptBlock(csType, strPopupWeb, strModalDialog, true);
        }
    }


    /// <summary> 
    /// 發送電子郵件 
    /// </summary> 
    /// <param name="MessageFrom">寄件者郵箱地址</param> 
    /// <param name="MessageTo">收件人郵箱地址</param> 
    /// <param name="MessageSubject">郵件主題</param> 
    /// <param name="MessageBody">郵件內容</param> 
    /// <returns></returns> 
    public bool Send(string MessageTo, string MessageSubject, string MessageBody)
    {

        //方法一
        //MailMessage message = new MailMessage();

        // if (FileUpload1.PostedFile.FileName != "")
        // {
        //  Attachment att = new Attachment("d://test.txt");//發送附件的內容
        //    message.Attachments.Add(att);
        // }

        //message.From = MessageFrom;
        //message.To.Add(MessageTo); //收件人郵箱位址可以是多個以實現群發 
        //message.Subject = MessageSubject;
        //message.Body = MessageBody;
        ////message.Attachments.Add(objMailAttachment);
        //message.IsBodyHtml = false; //是否為html格式 
        //message.Priority = MailPriority.High; //發送郵件的優先等級 

        //SmtpClient sc = new SmtpClient();
        //sc.Host = "smtp.gmail.com"; //指定發送郵件的伺服器地址或IP 
        //sc.Port = 465; //指定發送郵件埠 
        //sc.Credentials = new System.Net.NetworkCredential("ceshixmarketing@gmail.com", "xmarketing"); //指定登錄伺服器的用戶名和密碼
        //sc.Send(message); //發送郵件 


        ////方法二
        //MailMessage msg = new MailMessage();

        //msg.From = "ceshixmarketing@gmail.com";
        //msg.To = MessageTo;
        //msg.Subject = MessageSubject;
        //msg.Body = MessageBody;

        //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
        //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "ceshixmarketing@gmail.com");
        //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "xmarketing");


        //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 465);


        //msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "1");


        //SmtpMail.SmtpServer = "smtp.gmail.com";
        //SmtpMail.Send(objMailMessage);







        //方法三qq郵箱通過測試
        MailMessage objMailMessage;
        //MailAttachment objMailAttachment;

        // 創建一個附件物件 
        //objMailAttachment = new MailAttachment("F:\\focus2.swf");//發送郵件的附件 
        // 創建郵件消息 
        objMailMessage = new MailMessage();
        objMailMessage.From = "811695259@qq.com";//源邮件地址 发送方
        objMailMessage.To = MessageTo;//目的邮件地址，也就是发给我哈 
        objMailMessage.Subject = MessageSubject;//发送邮件的标题 
        objMailMessage.Body = MessageBody;//发送邮件的内容 
        objMailMessage.BodyFormat = MailFormat.Html;
        //objMailMessage.Attachments.Add(objMailAttachment);//将附件附加到邮件消息对象中 
        //接着利用sina的SMTP来发送邮件，需要使用Microsoft .NET Framework SDK v1.1和它以上的版本 
        //基本权限 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
        //用户名 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "811695259@qq.com");   //发送方用户名
        //密码 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tgf459tgf");    //密码
        //如果沒有上述三行代碼，則出現如下錯誤提示：伺服器拒絕了一個或多個收件人位址。伺服器回應為: 554 : Client host rejected: Access denied 
        //SMTP地址 
        SmtpMail.SmtpServer = "smtp.qq.com";

        //開始發送郵件 
        //SmtpMail.Send(objMailMessage);

        //核心代碼結束

        //方法四

        //System.Net.Mail.MailMessage mailObj = new System.Net.Mail.MailMessage();
        //mailObj.IsBodyHtml = true;
        //mailObj.Subject = MessageSubject;
        //mailObj.Body = MessageBody;
        //mailObj.To.Add(MessageTo);
        //System.Net.Mail.SmtpClient SmtpMail = new SmtpClient("smtp.gmail.com");
        //mailObj.From = new MailAddress("ceshixmarketing@gmail.com", "後冠國際行銷", System.Text.Encoding.UTF8);
        //SmtpMail.Credentials = new System.Net.NetworkCredential("ceshixmarketing@gmail.com", "xmarketing");
        ////gmail 專有配置 開始
        //SmtpMail.Port = 587;
        //SmtpMail.EnableSsl = true;
        ////gmail 專有配置 結束
        ////SmtpMail.Send(mailObj);


        ////方法五
        //SmtpClient client = new SmtpClient();
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.EnableSsl = true;
        //client.Host = "smtp.gmail.com";
        //client.Port = 465;

        //// setup Smtp authentication
        //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("ceshixmarketing@gmail.com", "xmarketing");
        //client.UseDefaultCredentials = false;
        //client.Credentials = credentials;
        //MailMessage msg = new MailMessage();
        //msg.From = new MailAddress("ceshixmarketing@gmail.com");
        //msg.To.Add(new MailAddress(MessageTo));

        //msg.Subject = MessageSubject;
        //msg.IsBodyHtml = true;
        //msg.Body = MessageBody;

        //try
        //{
        //client.Send(msg);
        //    lblMsg.Text = "Your message has been successfully sent.";
        //}
        //catch (Exception ex)
        //{
        //    lblMsg.ForeColor = Color.Red;
        //    lblMsg.Text = "Error occured while sending your message." + ex.Message;
        //}





        try
        {


            //sc.Send(message); //發送郵件 
            SmtpMail.Send(objMailMessage);

            //SmtpMail.Send(msg);

            //client.Send(mm);

            //SmtpMail.Send(mailObj);

            //client.Send(msg);
        }
        catch
        {
            return false;
        }
        return true;

    }
}
