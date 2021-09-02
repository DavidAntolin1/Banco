using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    class Account
    {
        public string UserId { get; set; }
        public decimal Quantity { get; set; }
        public Account(string userId, decimal quantity)
        {
            UserId = userId;
            Quantity = quantity;

        }
    }
}
