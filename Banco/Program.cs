using Banco.Models;
using Banco.Service;
using System;

namespace Banco
{
    class Program
    {
        
        static void Main(string[] args)
        {        
            //TODO: 
            var registerService = new RegisterService();
            var smsService = new SmsService();
            var rateInterestService = new RateInterestService();

            var usuario1 = (Client)registerService.UserRegister("Primero", "primero@email.com", "passw1", "987654", RegisterService.Permission.MINIMA);
            var usuario2 = (Client)registerService.UserRegister("Primero", "primero@email.com", "passw2", "123456", RegisterService.Permission.MINIMA);
            var usuario3 = (Employee)registerService.UserRegister("Tercero", "tercero@email.com", "passw3", "55555", RegisterService.Permission.TOTAL);


            Account account1 = new Account("primero@email.com", 500.3m);
            Account account2 = new Account("segundo@email.com", 725.5m);

            AccountService accountService = new AccountService();
            accountService.SendQuantity(account1, account2, usuario1.Phone, usuario2.Phone, 250.2m, smsService);

            rateInterestService.CalcRate(usuario1, account1, 4000, usuario3);

        }


    }
}
