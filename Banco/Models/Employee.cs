using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Employee : User
    {
        /// <summary>
        /// Clase hija de User para definir un empleado.
        /// </summary>
        public string Name { get; set; }
        public string Phone { get; set; }
        public Employee(string name, string email, string password, string phone) : base(email, password)
        {
            Name = name;
            Phone = phone;
        }
        
    }
}
