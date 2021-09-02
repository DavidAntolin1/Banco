using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class UserService
    {
        
        public void ClientRegister(string name, int phone, string email, int quantity, string id, string password, int accNumber, EmailService emailService)
        {
            Client user1 = new Client();
            user1.Name = name;
            user1.Phone = phone;
            user1.Email = email;
            user1.Quantity = quantity;
            user1.ID = id;
            user1.Password = password;
            user1.AccNumber = accNumber;
            user1.Authentification = false;
            if (!emailService.ValidateEmail(user1.Email))
                throw new Exception("Email is not an email");
            emailService.SendEmail(user1.Email, user1.ID, user1.Password);
        }

        public void UserLogin()
        {

        }
    }
}

