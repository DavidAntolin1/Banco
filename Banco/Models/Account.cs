using Banco.Interface;
using Banco.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public Account(string name, decimal quantity)
        {
            this.Name = name;
            this.Quantity = quantity;

        }
    }
}
