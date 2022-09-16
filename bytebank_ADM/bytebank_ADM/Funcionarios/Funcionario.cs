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

        public abstract double getBonificacao();
        
        public static int totalFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Salario = salario;
            Cpf = cpf;
            
            totalFuncionarios++;
        }
        public abstract void aumentarSalario();
       
    }
}
