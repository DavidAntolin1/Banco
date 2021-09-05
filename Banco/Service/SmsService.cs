using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class SmsService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="reason"></param>
        /// <param name="body"></param>
        
        public void SendSMS(string phone, string body)
        {
            Sms sms = new Sms();
            EmailService emailService = new EmailService();
            Console.WriteLine(sms.SmsReply(phone, body));
            
        }
    }
}
