using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Sms : ISmsable
    {
        public string body { get; set; }
        public string SmsReply(string phone, string body)
        {
            return $"{phone} / {body}";
        }
    }
}
