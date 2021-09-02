using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class EmailService
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
       
    }
}
