using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    interface ISmsable
    {
        string SmsReply(string phone, string body);
    }
}
