
using System.Text;

using M3P_BackEnd_Squad1.DTOs;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace M3P_BackEnd_Squad1.Utilities
{
    public class JwtUtilities
    {
        private readonly string _chaveJwt;
        public JwtUtilities(IConfiguration configuration)
        {
            _chaveJwt = configuration.GetSection("jwtTokenChave").Get<string>();
        }
        public string GerarToken(LoginDTO login)
        {
            // Usuario usuario = _usuarioService.ObterPorId(login.Usuario);

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

        public string CriptografarSenha(string senha)
        {
            HashAlgorithm _algoritmo = SHA256.Create();
            var encodedValue = System.Text.Encoding.UTF8.GetBytes(senha);
            var encryptePassword = _algoritmo.ComputeHash(encodedValue);
            return Convert.ToBase64String(encryptePassword);
        }
    }
}