using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.DTOs;

namespace M3P_BackEnd_Squad1.Interfaces.Services
{
    public interface ILoginService
    {
        public bool Autenticar(LoginDTO login);
        public string GerarToken(LoginDTO login);
    }
}