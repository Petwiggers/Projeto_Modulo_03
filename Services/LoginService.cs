using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.DTOs;
using M3P_BackEnd_Squad1.Exceptions;
using M3P_BackEnd_Squad1.Interfaces.Repositories;
using M3P_BackEnd_Squad1.Models;
using M3P_BackEnd_Squad1.Utilities;
using Microsoft.IdentityModel.Tokens;

namespace M3P_BackEnd_Squad1.Services
{
    public class LoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly string _chaveJwt;
        private LoginDTO loginMock = new LoginDTO
        {
            Email = "peterson@teste.com",
            Senha = "123",
        };

        public LoginService(ILoginRepository loginRepository, IConfiguration configuration)
        {
            _loginRepository = loginRepository;
            _chaveJwt = configuration.GetSection("jwtTokenChave").Get<string>();
        }

        public string LoginValidation(LoginDTO login)
        {
            User user = _loginRepository.GetUserEmail(login.Email);
            if (!(login.Email == loginMock.Email && login.Senha == loginMock.Senha))
            {
                throw new UnauthorizedException("Login or password invalid");
            }
            return GerarToken(login);
        }

        private string GerarToken(LoginDTO login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_chaveJwt);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                  {
                      new Claim(ClaimTypes.Name,""),
                      new Claim("Nome", ""),
                      new Claim(ClaimTypes.Role,""),
                  }),
                Expires = DateTime.UtcNow.AddHours(4),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}