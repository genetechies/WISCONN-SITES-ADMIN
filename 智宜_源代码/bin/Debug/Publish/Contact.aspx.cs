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
using System.Text;

namespace ZeroStudio.Web {
    public partial class Contact_en : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void btnSend_Click(object sender, EventArgs e) {
            string mailto = "sales@wis-connector.com";
            string mailto1 = "sales.xmarketing@gmail.com";
            BLL.GuestBook bll = new ZeroStudio.BLL.GuestBook();
            Model.GuestBook model = new ZeroStudio.Model.GuestBook();
            model.G_Title = txtTitle.Text;
            model.G_Email = txtEmail.Text;
            model.G_Username = txtUserName.Text;
            model.G_Content = codetohtml(txtContent.Text);
            model.G_Datetime = Convert.ToDateTime(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            bll.Add(model);
            SendMail(model.G_Username, model.G_Email, model.G_Title, model.G_Content, mailto);
            SendMail(model.G_Username, model.G_Email, model.G_Title, model.G_Content, mailto1);
            reset();
            ClientScript.RegisterStartupScript(GetType(), "success", "alert('Send success！');", true);
        }
        private void reset() {
            txtUserName.Text = "";
            txtTitle.Text = "";
            txtEmail.Text = "";
            txtContent.Text = "";
        }
        private void SendMail(string username, string email, string subject, string content, string mailto) {
            System.Net.Mail.SmtpClient client;
            System.Net.Mail.MailAddress sender;
            System.Net.Mail.MailMessage message;


            client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("houguan2017@gmail.com", "homtzvusavtfebej");

            sender = new System.Net.Mail.MailAddress("houguan2017@gmail.com", "智宜網站線上留言", System.Text.Encoding.UTF8);




            

            StringBuilder body = new StringBuilder();


            body.Append("<p>" + content + "</p>");
            body.Append("<p>" + username + "&nbsp;&nbsp;&nbsp;&nbsp;<a href=\"mailto:" + email + "\" >" + email + "</a></p>");
            body.Append("<p>" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "</p>");
            using (message = new System.Net.Mail.MailMessage()) {
                message.IsBodyHtml = true;
                message.From = sender;
                message.To.Add(mailto);
                message.SubjectEncoding = System.Text.Encoding.UTF8;
                message.Subject = subject;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Body = body.ToString();
                client.Send(message);
            }
        }
        private string htmltocode(string str) {
            string newstr;
            if (string.IsNullOrEmpty(str)) {
                return "";
            }
            newstr = str.Replace("&lt;", "<");
            newstr = newstr.Replace("&gt;", ">");
            newstr = newstr.Replace("<br>", "\r\n");
            newstr = newstr.Replace("&nbsp;", " ");
            return newstr;
        }

        private string codetohtml(string str) {
            string newstr;
            if (string.IsNullOrEmpty(str)) {
                return "";
            }
            newstr = str.Replace("<", "&lt;");
            newstr = newstr.Replace(">", "&gt;");
            newstr = newstr.Replace("\r\n", "<br>");
            // newstr = newstr.Replace(" ", "&nbsp;");
            return newstr;
        }
    }
}