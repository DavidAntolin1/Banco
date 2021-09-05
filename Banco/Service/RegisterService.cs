using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class RegisterService
    {
        public enum Permission
        {
            TOTAL,
            PARCIAL,
            MINIMA
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="phone"></param>
        /// <param name="permission"></param>
        public User UserRegister(string name, string email,string password, string phone, Permission permission)
        {

            EmailService emailService = new EmailService(); /**/
            switch (permission)
            {
                case Permission.MINIMA:
                    Client client = new Client(name, email, password, phone);
                    emailService.EmailSend(email,"Autentificacion", $"User: {email} /Contraseña: {password}");
                    return client;

                case Permission.TOTAL:
                    Employee employee = new Employee(name, email, password, phone);
                    emailService.EmailSend(email, "Autentificacion", $"User: {email} /Contraseña: {password}");
                    return employee;
                default:
                    return null;
            }
        }
       
    }
}

