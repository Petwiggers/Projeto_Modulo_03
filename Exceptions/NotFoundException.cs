using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string mensagem) : base(mensagem)
        {

        }
    }
}