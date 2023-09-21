
using System.Text;

using M3P_BackEnd_Squad1.DTOs;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using M3P_BackEnd_Squad1.Interfaces;

namespace M3P_BackEnd_Squad1.Utilities
{
    public class JwtUtilities : EncryptPassword
    {
        public static string CriptografarSenha(string senha)
        {
            HashAlgorithm _algoritmo = SHA256.Create();
            var encodedValue = System.Text.Encoding.UTF8.GetBytes(senha);
            var encryptePassword = _algoritmo.ComputeHash(encodedValue);
            return Convert.ToBase64String(encryptePassword);
        }
    }
}