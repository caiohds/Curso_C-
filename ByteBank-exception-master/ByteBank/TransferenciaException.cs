using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class TransferenciaException : Exception
    {
        public TransferenciaException(string mensagem) : base(mensagem)
        {

        }
    }
}
