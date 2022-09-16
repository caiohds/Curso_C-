using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario + base.getBonificacao(); // o diretor recebe 100% de bonificação
        }

        public Diretor (string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
