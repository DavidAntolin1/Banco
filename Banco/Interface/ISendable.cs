using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    interface ISendable
    {
        /// <summary>
        /// Interfaz para que pueda devolver una respuesta.
        /// </summary>
        string SmsReply(string phone, string body);
        string EmailReply(string email, string body);

    }
}
