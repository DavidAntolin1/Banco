using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    class AccountService 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="accountIncrease"></param>
        /// <param name="phone"></param>
        /// <param name="phoneIncrease"></param>
        /// <param name="amount"></param>
        public void SendQuantity(Account account, Account accountIncrease, string phone, string phoneIncrease, decimal amount, SmsService sms)
        {
            if (amount > account.Quantity || amount < 0)
            {
                Console.WriteLine("Imposible realizar operación");
            }
            account.Quantity -= amount;
            accountIncrease.Quantity += amount;
            SmsService replyService = new SmsService();
            replyService.SendSMS(phone, "Transacción realizada con éxito, su saldo actual es: "+ account.Quantity);
            replyService.SendSMS(phoneIncrease, "Transacción recibida con éxito, su saldo actual es: "+ accountIncrease.Quantity);
        }
    }
}
