using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.ComponentModel;

/// <summary>
///GmailSend 的摘要说明
///Gmail邮件发送
/// </summary>
public class GmailSend{
	

    public static bool Send(string MessageTo, string MessageSubject, string MessageBody)
    {                
        MailAddress fromaddress = new MailAddress("anglex888@gmail.com");
        MailAddress toAddress = new MailAddress(MessageTo);
        MailMessage msg = new MailMessage(fromaddress,toAddress);
        //msg.From = fromaddress;
        //msg.To = toAddress;
        msg.Subject = MessageSubject;
        msg.Body = MessageBody;
        msg.BodyEncoding = Encoding.UTF8;
        msg.IsBodyHtml = false;
        msg.Priority = MailPriority.High;

        SmtpClient smtpclient = new SmtpClient();
        smtpclient.Credentials = new NetworkCredential("anglex888@gmail.com", "ad123456ad"); 
        smtpclient.Port = 587; // Gmail 使用 465 和 587 端口 
        smtpclient.Host = "smtp.gmail.com"; // 如 smtp.163.com, smtp.gmail.com 
        smtpclient.EnableSsl = true; // 如果使用GMail，则需要设置为true 
        //smtpclient.SendCompleted += new SendCompletedEventHandler(SendMailCompleted); 
        try {
            smtpclient.Send(msg); 
        } 
        catch (SmtpException ex) 
        {     
            //Console.WriteLine(ex.ToString());
            return false;
        }
        return true;


    }

    void SendMailCompleted(object sender, AsyncCompletedEventArgs e)
    {

        MailMessage mailMsg = (MailMessage)e.UserState;

        string subject = mailMsg.Subject;

        if (e.Cancelled) // 邮件被取消 
        {

            Console.WriteLine(subject + " 被取消。");

        }

        if (e.Error != null)
        {

            Console.WriteLine("错误：" + e.Error.ToString());

        }

        else
        {

            Console.WriteLine("发送完成。");

        }

    }
}