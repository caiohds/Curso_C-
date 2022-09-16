using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class  Funcionario
    {
        
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public virtual double getBonificacao()
        {

            return Salario * 0.1; 
        }
        public static int totalFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Salario = salario;
            Cpf = cpf;
            
            totalFuncionarios++;
        }
        public virtual void aumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
