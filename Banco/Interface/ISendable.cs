using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    interface ISendable
    {
        string SmsReply(string phone, string body);
        string EmailReply(string email, string body);

    }
}
