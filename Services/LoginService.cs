using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.DTOs;
using M3P_BackEnd_Squad1.Utilities;
using Microsoft.IdentityModel.Tokens;

namespace M3P_BackEnd_Squad1.Services
{
    public class LoginService
    {
        // private readonly IUsuarioService _usuarioService;
        private readonly string _chaveJwt;
        private readonly JwtUtilities jwt;
        private LoginDTO loginMock = new LoginDTO
        {
            Email = "peterson@teste.com",
            Senha = "123",
        };

        public LoginService(/*IUsuarioService usuarioService,*/ IConfiguration configuration, JwtUtilities jwtUtilities)
        {
            // _usuarioService = usuarioService;
            _chaveJwt = configuration.GetSection("jwtTokenChave").Get<string>();
            jwt = jwtUtilities;
        }

        public bool Autenticar(LoginDTO login)
        {
            // Usuario usuario = _usuarioService.ObterPorId(login.Usuario);
            // if (usuario != null)
            // {
            // return usuario.Senha == JwtUtilities.CriptografarSenha(login.Senha);
            // }
            // return false;
            if (login.Email == loginMock.Email && login.Senha == loginMock.Senha)
            {
                return true;
            }
            return false;
        }

        public string GerarToken(LoginDTO login)
        {
            return jwt.GerarToken(login);
        }
    }
}