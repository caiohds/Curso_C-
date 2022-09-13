using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        //0 - FUNCIONÁRIO COMUM
        //1 - DIRETOR
        //2- DESIGNER
        private int _tipo;
        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

       


        public double getBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario; //Caso ele seja direto, recebe 100% de bonificação
            }
                return Salario * 0.1; // caso não seja, ele recebe 10%
        }
    }
}
