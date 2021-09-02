using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class ReplyService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="reason"></param>
        /// <param name="body"></param>
        public void EmailSend(string email, string reason, string body)
        {
            Reply reply = new Reply();
            EmailService emailService = new EmailService();
            if (!emailService.ValidateEmail(email))
                throw new Exception("Email is not an email");
            Console.WriteLine(reply.EmailReply(reason, body));

        }
        public void SendSMS(string phone, string body)
        {
            Reply reply = new Reply();
            EmailService emailService = new EmailService();
            Console.WriteLine(reply.SmsReply(phone, body));
        }
    }
}
