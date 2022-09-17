using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario,Autenticavel
    {
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(string nome, string cpf,double salario) : base(nome, cpf, salario)
        {
           
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
