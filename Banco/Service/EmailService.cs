using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class EmailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="reason"></param>
        /// <param name="body"></param>
        public void EmailSend(string email, string reason, string body)
        {
            Email reply = new Email();
            EmailService emailService = new EmailService();
            if (!emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            Console.WriteLine(reply.EmailReply(reason, body));

        }

    }
}
