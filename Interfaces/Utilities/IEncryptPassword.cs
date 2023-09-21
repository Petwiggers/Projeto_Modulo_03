
using System.Security.Cryptography;


namespace M3P_BackEnd_Squad1.Interfaces
{
    public interface EncryptPassword
    {
        public static abstract string CriptografarSenha(string senha);
    }
}