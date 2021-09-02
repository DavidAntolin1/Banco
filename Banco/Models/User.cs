﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        
    }
}

