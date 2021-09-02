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
        public void SendEmail(string email,string id, string pass)
        {
            Console.WriteLine($"Email para : {0} \n ID: {1} \n Password: {2}", email, id, pass);
        }
    }
}
