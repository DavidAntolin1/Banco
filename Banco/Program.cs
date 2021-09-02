using Banco.Models;
using Banco.Service;
using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.ClientRegister("Primero", "primero@email.com", "passw1", "987654", false);
            userService.ClientRegister("Primero", "primero@email.com", "passw2", "123456", false);
            Account account1 = new Account("primero@email.com", 500.3m);
            Account account2 = new Account("segundo@email.com", 725.5m);
            Client usuario1 = new Client("Primero", "primero@email.com", "passw", "987654");
            Client usuario2 = new Client("Segundo", "segundo@email.com", "passw", "987654");
            AccountService accountService = new AccountService();
            accountService.SendQuantity(account1, account2, usuario1.Phone, usuario2.Phone, 250.0m);

        }


    }
}
