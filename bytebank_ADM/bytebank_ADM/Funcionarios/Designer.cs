using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf) : base(nome,cpf,3000.0)
        {
            Console.WriteLine("Criando um desinger");
        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.11;
        }
        public override double getBonificacao()
        {
            return Salario * 0.17; 
        }
    }
}
