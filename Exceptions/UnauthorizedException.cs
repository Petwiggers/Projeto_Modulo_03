using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string mensagem) : base(mensagem)
        {

        }
    }
}