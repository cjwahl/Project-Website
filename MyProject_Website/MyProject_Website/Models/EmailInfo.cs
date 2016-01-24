using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;

namespace MyProject_Website.Models
{
    public class EmailInfo
    {
        public string name { get; set; }

        public string message { get; set; }

        public string email { get; set; }

        public string error { get; set; }

        public static EmailInfo SendEmail(EmailInfo emailInfo)
        {
            emailInfo.error = "No Error";
            var fromAddress = new MailAddress("cjwahlwebsite@gmail.com", "Chris Wahl");
            var toAddress = new MailAddress("cjwahlwebsite@gmail.com", "Chris Wahl");
            var password = "**********:)";
            var subject = "Message From " + emailInfo.name;
            var body = emailInfo.email + "    " + emailInfo.message;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                }
                catch (Exception ex)
                {
                    emailInfo.error = ex.ToString();
                }
            }

            return emailInfo;
        }
    }
}