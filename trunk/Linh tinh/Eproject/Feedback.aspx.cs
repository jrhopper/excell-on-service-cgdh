using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        SmtpClient SmtpServer = new SmtpClient();
        SmtpServer.Credentials = new System.Net.NetworkCredential("eos.co9999@gmail.com", "eos12345678");
        SmtpServer.Port = 587;
        SmtpServer.Host = "smtp.gmail.com";
        SmtpServer.EnableSsl = true;
        MailMessage mail = new MailMessage();
        try
        {
			mail.To.Add("tronggia@gmail.com,qchuong100@gmail.com");
            mail.From = new MailAddress("eos.co9999@gmail.com", txtEmail.Text);
            mail.Subject = txtSubject.Text;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.Body = txtBody.Text;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mail.ReplyTo = new MailAddress(txtEmail.Text);
            SmtpServer.Send(mail);
            Response.Write(@"<script language='javascript'>alert('Send mail is completed !!!')</script>");
        }
        catch (Exception) {
            Response.Write(@"<script language='javascript'>alert('Send mail is failed, please check your internet system')</script>"); 
        }
    }
}