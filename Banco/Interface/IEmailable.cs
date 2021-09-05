using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    interface IEmailable
    {
        /// <summary>
        /// Interfaz para que pueda devolver una respuesta.
        /// </summary>
        string EmailReply(string email, string body);

    }
}
