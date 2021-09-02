using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Account
    {
        /// <summary>
        /// Modelo para definir la Cuenta Bancaria, definidos por dos valores, ID que será el email y una cantidad que será
        /// el fondo disponible.
        /// </summary>
        public string UserId { get; set; }
        public decimal Quantity { get; set; }
        public Account(string userId, decimal quantity)
        {
            UserId = userId;
            Quantity = quantity;

        }
        
    }
}
