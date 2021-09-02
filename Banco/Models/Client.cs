using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class Client : User
    {
        /// <summary>
        /// Clase hija de User para definir un cliente.
        /// </summary>
        public string Name { get; set; }
        public string Phone { get; set; }
        public Client (string name, string email, string password, string phone) : base(email, password)
        {
            Name = name;
            Phone = phone;
        }

        
    }
}
