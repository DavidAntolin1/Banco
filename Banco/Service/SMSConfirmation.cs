using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class SMSConfirmation
    {
        public void SendSMS(int phone1, int phone2, decimal amount)
        {
            Console.WriteLine($"SMS para Client1: \n Transacción realizada correctamente, cantidad: {0}", amount);
            Console.WriteLine($"SMS para Client2: \n Ingreso de: {0}", amount);
        }
    }
}
