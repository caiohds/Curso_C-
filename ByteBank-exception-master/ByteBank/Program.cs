using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 10);
                Console.WriteLine("Conta criada com sucesso!");
                conta.Depositar(50.0);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(550.0);
                Console.WriteLine(conta.Saldo);

            }
            catch(ArgumentException e)
            {
                //Console.WriteLine("Erro no parâmetro " + e.ParamName);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                //Console.WriteLine(e.Message);
            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Saldo insuficiente!");
            }
           
            Console.ReadLine();
        }
    }
}
