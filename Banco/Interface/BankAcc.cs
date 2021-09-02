using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Interface
{
    class BankAcc
    {
        public int AccNumber { get; set; }
        public decimal Quantity { get; set; }

        public void BankAcc(int accNumber, decimal quantity)
        {
            AccNumber = accNumber;
            Quantity = quantity;
        }
    }
}
