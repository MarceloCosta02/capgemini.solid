using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Dependency_Inversion_Principle.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
