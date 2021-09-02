using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    class AccountService
    {
        public void SendQuantity(Account account, Account accountIncrease, string phone, string phoneIncrease, decimal amount)
        {
            account.Quantity -= amount;
            accountIncrease.Quantity += amount;
            ReplyService replyService = new ReplyService();
            replyService.SendSMS(phone, "Transacción realizada con éxito, su saldo actual es: "+ account.Quantity);
            replyService.SendSMS(phoneIncrease, "Transacción recibida con éxito, su saldo actual es: "+ accountIncrease.Quantity);

        }
    }
}
