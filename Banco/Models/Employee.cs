using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Employee : User
    {
        /// <summary>
        /// Clase hija de User para definir un empleado y cuenta de empleado.
        /// </summary>
        public string Name { get; set; }
        public string Phone { get; set; }
        public Employee(string name, string email, string password, string phone)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Password = password;
        }
        
    }
}
