using Banco.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    class SMSConfirmation
    {
        public string SMSConfirmation (IClientable client1, IClientable client2, int amount)
        {


            Console.WriteLine("SMS enviado");
        }
    }
}
