using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    class RateInterestService
    {
        public void CalcRate (Client user1, Account account, int loan,  Employee user2)
        {
            decimal ratio = 0.01m;
            if (account.Quantity < 1000 && account.Quantity!=0)
            {
                ratio = 0.04m;
            }
            if (account.Quantity > 1000 && account.Quantity < 5000)
            {
                ratio = 0.03m;
            }
            if (account.Quantity < 10000 && account.Quantity > 5000)
            {
                ratio = 0.02m;
            }
            decimal result = loan * ratio;
            Console.WriteLine($"Su préstamo de {loan}€ tiene un interés del {ratio}%, total a pagar: {result}€");
        }


    }
}
