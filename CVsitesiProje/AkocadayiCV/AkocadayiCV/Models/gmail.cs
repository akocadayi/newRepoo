using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace AkocadayiCV.Models
{
    public static class gmail
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("cvsitesi@gmail.com", " CV ");
            var toAddress = new MailAddress("cvsitesi@gmail.com");
            const string subject = " CV ";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "123456arif")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }                     
}