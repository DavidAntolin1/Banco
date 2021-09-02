﻿using Banco.Interface;
using Banco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Service
{
    public class UserService
    {
        List<Client> listaClientes = new List<Client>();
        public void ClientRegister(string name, string email,string password, string phone, bool permission)
        {
            ReplyService replyService = new ReplyService();
            switch (permission)
            {
                case false:
                    Client client = new Client(name, email, password, phone);
                    replyService.EmailSend(email,"Credenciales", "User: "+email+"\n"+"Contraseña: "+password);
                    break;

                case true:
                    Employee employee = new Employee(name, email, password, phone);
                    replyService.EmailSend(email, "Credenciales", "User: " + email + "\n" + "Contraseña: " + password);
                    break;
            }
        }
       
    }
}

