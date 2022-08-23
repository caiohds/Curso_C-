using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Titular
{
    public class Cliente
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string Profissao { get; set; }

        public Cliente()
        {
            this.Nome = "";
            this.Cpf = "";
            this.Profissao = "";
        }
    }
}
