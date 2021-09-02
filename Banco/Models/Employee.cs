using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public int AccNumber { get; set; }
        public int Quantity { get; set; }

        public bool Authentification { get; set; }

    }
}
