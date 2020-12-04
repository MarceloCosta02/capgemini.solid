using solidExample.Dependency_Inversion_Principle.Interfaces;
using solidExample.Dependency_Inversion_Principle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace solidExample.Dependency_Inversion_Principle.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _usuarioRepository;
        public UserServices(IUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void AdicionarUsuario(User usuario)
        {
            _usuarioRepository.Persistir(usuario);
        }        
    }
}
