using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {

        public Desenvolvedor(string nome, string cpf) : base(nome,cpf,3000.0)
        {
            Console.WriteLine("Criando um desenvolvedor.");
        }

        public override void aumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;   
        }
    }
}
