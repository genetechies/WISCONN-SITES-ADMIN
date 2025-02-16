using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Helper;
using System.Text;
using DBUtility;
using System.Web.Mail;
using System.Web.Script.Serialization;

public partial class center01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            if (username.Value.Trim() == "")
            {
                MyTool.alertback("聯絡人為空了");
            }
            if (email.Value.Trim() == "")
            {
                MyTool.alertback("聯絡郵件為空了");
            }
            if (!MyTool.isEmail(email.Value.Trim()))
            {
                MyTool.alertback("聯絡郵件格式不對");
            }
            if(!MyTool.IsNumeric(translationamount.Value))
            {
                MyTool.alertback("估計頁數或字數為空了");
            }

            if(!MyTool.IsValidDate(posttime.Value.Trim()))
            {
                MyTool.alertback("交件時間有誤");
            }

            Model.XunJia mo = new Model.XunJia();

            mo.LinksName = username.Value;
            mo.LinksTel = tel.Value;
            mo.LinksEmail = email.Value;
            mo.SerPro = ddltranslationskill.SelectedItem.Value == "0" ? "" : ddltranslationskill.SelectedItem.Text;
            mo.OrgLanguage = ddllanguagefrom.SelectedItem.Value == "0" ? "" : ddllanguagefrom.SelectedItem.Text;
            mo.ToLanguage = ddllanguageto.SelectedItem.Value == "0" ? "" : ddllanguageto.SelectedItem.Text;

            mo.TxtCount =Convert.ToInt32( translationamount.Value);
            mo.TxtSCount = ddltranslationtype.SelectedItem.Text;
            mo.ispaiban = rty.Checked ? 1 : 0;
            mo.ercijiaogao = rpy.Checked ? 1 : 0;
            mo.rungao = rdy.Checked ? 1 : 0;
            mo.JiaojianTime =Convert.ToDateTime(posttime.Value.Trim());
            mo.gongzuori = updays.Value;
            mo.zhuyicontent = ttbNotes.Text;
            mo.Note = "來自網頁";
            string sUpFileName = "";
            if (file1.HasFile)
            {
                string path = Server.MapPath(".") + "\\UpLoadFiles\\" + file1.FileName.Replace(" ","");
                file1.PostedFile.SaveAs(path);
                sUpFileName = file1.FileName.Replace(" ", "");

                mo.Annex = "/online/UpLoadFiles/" + sUpFileName;


            }
            else
            {
                mo.Annex = "";
            }

            mo.addTime=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mo.ip=Request.UserHostAddress;
            mo.Finish=0;

            BLL.XunJia xj = new BLL.XunJia();

            xj.Add(mo);




            DataSet ds = GetList();
            if (ds.Tables[0].Rows.Count > 0)
            {
                string touser = "";
                string title = "";
                string tobody = "";
                string ttranslationskill = ddltranslationskill.SelectedItem.Value == "0" ? "" : ddltranslationskill.SelectedItem.Text;
                string tlanguagefrom=ddllanguagefrom.SelectedItem.Value == "0" ? "" : ddllanguagefrom.SelectedItem.Text;
                string tlanguageto=ddllanguageto.SelectedItem.Value == "0" ? "" : ddllanguageto.SelectedItem.Text;
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    touser = ds.Tables[0].Rows[i][2].ToString();
                    title = "管理員" + ds.Tables[0].Rows[i][1].ToString() + "你好,后冠翻譯公司網站上發在起線上詢價，請注意查看！";
                    tobody = "管理員" + ds.Tables[0].Rows[i][1].ToString() + "你好,后冠翻譯公司網站上發在起線上詢價，請注意查看！" +
                        "<br>詢價者大名:" + username.Value + "<br>聯絡電話:" + tel.Value +
                        "<br>聯絡郵件:" + email.Value + "<br>服務項目:" + ttranslationskill.ToString() +
                        "<br>原語言:" + tlanguagefrom.ToString() + "<br>目標語言:" + tlanguageto.ToString() +
                        "<br>總字數:" + Convert.ToInt32(translationamount.Value) + ddltranslationtype.SelectedItem.Text + "<br>交件時間:" + Convert.ToDateTime(posttime.Value.Trim()) +
                        "<br>備註:" + ttbNotes.Text + "<br>此為簡訊,正確資訊請至后冠後台查詢!!";
                    //touser = "522125549@qq.com";
                    SendEmail(touser, title, tobody);
                }
            }

            MyTool.alert("感謝您的詢價，我們已收到，會儘速請報價專員與您聯絡！", "/online/index.aspx");
            MyTool.alert("感謝您的詢價，我們已收到，會儘速請報價專員與您聯絡！", "/online/index.aspx");

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }

        

        //string sql = "insert into useraskpay (UserName,TEL,Email,TransLationSkill,LanguageFrom,LanguageTo,TranslationAmount,TranslationType,IsTypesetting,IsTwoProofreading,IsDraft,SubmitTime,RunDays,Remark,UpFileName,CreateDate) values ('" + sUserName + "','" + sTel + "','" + sMail + "','" + sTranslationskill + "','" + sLanguagefrom + "','" + sLanguageto + "','" + sTranslationamount + "','" + sTranslationtype + "','" + sRty + "','" + sRpy + "','" + sRdy + "','" + sPosttime + "','" + sUpdays + "','" + sNotes + "','" + sUpFileName + "','" + sCreateDate + "')";
        //AccessExeNonQuery(sql);



        //JsAlert("感謝您的詢價，我們已收到，會儘速請報價專員與您聯絡！");
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
        //MailAddress MessageFrom = new MailAddress("ceshixmarketing@gmail.com"); //发件人邮箱地址 
        string MessageTo = touser; //收件人邮箱地址 
        string MessageSubject = title; //邮件主题 
        string MessageBody = tobody; //邮件内容 
        if (Send(MessageTo, MessageSubject, MessageBody))
        {
            Response.Write("發送成功");
        }
        else
        {
            Response.Write("發送失敗");
        }
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
    /// 发送电子邮件 
    /// </summary> 
    /// <param name="MessageFrom">发件人邮箱地址</param> 
    /// <param name="MessageTo">收件人邮箱地址</param> 
    /// <param name="MessageSubject">邮件主题</param> 
    /// <param name="MessageBody">邮件内容</param> 
    /// <returns></returns> 
    public bool Send(string MessageTo, string MessageSubject, string MessageBody)
    {

        //方法一
        //MailMessage message = new MailMessage();

        // if (FileUpload1.PostedFile.FileName != "")
        // {
        //  Attachment att = new Attachment("d://test.txt");//发送附件的内容
        //    message.Attachments.Add(att);
        // }

        //message.From = MessageFrom;
        //message.To.Add(MessageTo); //收件人邮箱地址可以是多个以实现群发 
        //message.Subject = MessageSubject;
        //message.Body = MessageBody;
        ////message.Attachments.Add(objMailAttachment);
        //message.IsBodyHtml = false; //是否为html格式 
        //message.Priority = MailPriority.High; //发送邮件的优先等级 

        //SmtpClient sc = new SmtpClient();
        //sc.Host = "smtp.gmail.com"; //指定发送邮件的服务器地址或IP 
        //sc.Port = 465; //指定发送邮件端口 
        //sc.Credentials = new System.Net.NetworkCredential("ceshixmarketing@gmail.com", "xmarketing"); //指定登录服务器的用户名和密码
        //sc.Send(message); //发送邮件 


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







        //方法三qq邮箱通过测试
        MailMessage objMailMessage;
        //MailAttachment objMailAttachment;

        // 创建一个附件对象 
        //objMailAttachment = new MailAttachment("F:\\focus2.swf");//发送邮件的附件 
        // 创建邮件消息 
        objMailMessage = new MailMessage();
        objMailMessage.From = "1485520636@qq.com";//源邮件地址 发送方
        objMailMessage.To = MessageTo;//目的邮件地址，也就是发给我哈 
        objMailMessage.Subject = MessageSubject;//发送邮件的标题 
        objMailMessage.Body = MessageBody;//发送邮件的内容 
        objMailMessage.BodyFormat = MailFormat.Html;
        //objMailMessage.Attachments.Add(objMailAttachment);//将附件附加到邮件消息对象中 
        //接着利用sina的SMTP来发送邮件，需要使用Microsoft .NET Framework SDK v1.1和它以上的版本 
        //基本权限 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
        //用户名 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "2803748671@qq.com");   //发送方用户名
        //密码 
        objMailMessage.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "edc951edc");    //密码
        //如果没有上述三行代码，则出现如下错误提示：服务器拒绝了一个或多个收件人地址。服务器响应为: 554 : Client host rejected: Access denied 
        //SMTP地址 
        SmtpMail.SmtpServer = "smtp.qq.com";

        //开始发送邮件 
        //SmtpMail.Send(objMailMessage);

        //核心代码结束

        //方法四

        //System.Net.Mail.MailMessage mailObj = new System.Net.Mail.MailMessage();
        //mailObj.IsBodyHtml = true;
        //mailObj.Subject = MessageSubject;
        //mailObj.Body = MessageBody;
        //mailObj.To.Add(MessageTo);
        //System.Net.Mail.SmtpClient SmtpMail = new SmtpClient("smtp.gmail.com");
        //mailObj.From = new MailAddress("ceshixmarketing@gmail.com", "后冠國際行銷", System.Text.Encoding.UTF8);
        //SmtpMail.Credentials = new System.Net.NetworkCredential("ceshixmarketing@gmail.com", "xmarketing");
        ////gmail 专有配置 开始
        //SmtpMail.Port = 587;
        //SmtpMail.EnableSsl = true;
        ////gmail 专有配置 结束
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


            //sc.Send(message); //发送邮件 
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
