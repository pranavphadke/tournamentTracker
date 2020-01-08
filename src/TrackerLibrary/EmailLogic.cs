using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using TrackerLibrary.Configuration;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string toEmail,string subject,string body)
        {
            // Provide FROM address as defined in the App.config file
            MailAddress fromEmail = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderEmailDisplayName"));

            // Create a new blank email
            MailMessage mail = new MailMessage();

            // Add details to the blank email
            mail.To.Add(toEmail);
            mail.From = fromEmail;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            // Create email client as defined in App.cofig file
            SmtpClient client = new SmtpClient();

            // Tell client to send email
            client.Send(mail);

        }
    }
}
