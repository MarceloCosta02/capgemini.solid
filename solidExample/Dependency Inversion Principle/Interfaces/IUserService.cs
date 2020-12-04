using solidExample.Dependency_Inversion_Principle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Dependency_Inversion_Principle.Interfaces
{
    public interface IUserService
    {
        void AdicionarUsuario(User usuario);
    }
}
