using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class Client : User
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Client (string name, string email, string password, string phone) : base(email, password)
        {
            Name = name;
            Phone = phone;
        }

        
    }
}
