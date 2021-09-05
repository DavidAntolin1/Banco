using Banco.Models;
using Banco.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    interface IAccounteable
    {
        public void SendQuantity(Account account, Account accountIncrease, string phone, string phoneIncrease, decimal amount, SmsService sms);
    }
}
