﻿using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Reply : ISendable
    {
        public string Reason { get; set; }
        public string body { get; set; }

        public string EmailReply(string reason, string body)
        {
            return reason+"\n"+body;
        }
        public string SmsReply(string phone, string body)
        {
            return phone + "\n" + body;
        }
    }
}
