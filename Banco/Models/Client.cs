using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public int AccNumber { get; set; }
        public decimal Quantity { get; set; }

        public bool Authentification { get; set; }

        
    }
}
