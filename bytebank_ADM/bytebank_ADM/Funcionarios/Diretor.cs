using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
       

        public Diretor (string nome, string cpf) : base(nome, cpf, 5000)
        {
            Console.WriteLine("Criando um diretor.");
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }
        public override double getBonificacao()
        {
            return Salario * 0.5; 
        }
        
    }
}
