using solidExample.Dependency_Inversion_Principle.Interfaces;
using solidExample.Dependency_Inversion_Principle.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace solidExample.Dependency_Inversion_Principle.Repository
{
    public class UserRepository : IUserRepository
    {
        public void Persistir(User usuario)
        {
            Debug.WriteLine("Usuário criado");
        }
    }
}
