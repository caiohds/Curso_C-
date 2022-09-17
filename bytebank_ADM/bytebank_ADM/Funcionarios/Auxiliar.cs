using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000.0)
        {
            Console.WriteLine("criando um auxiliar");
        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.10;
        }
        public override double getBonificacao()
        {
            return Salario * 0.2; 
        }
      
    }
}
