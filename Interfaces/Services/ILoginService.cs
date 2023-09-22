using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.DTOs;

namespace M3P_BackEnd_Squad1.Interfaces.Services
{
    public interface ILoginService
    {
        public string LoginValidation(LoginDTO login);
        public string GenerateToken(LoginDTO login);
    }
}