using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf) : base(nome,cpf,4000.0)
        {
            Console.WriteLine("Criando um gerente de contas.");
        }
        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }
        public override double getBonificacao()
        {
            return Salario * 0.25; 
        }
       
    }
}
