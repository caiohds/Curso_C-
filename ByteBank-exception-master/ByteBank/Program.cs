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
                ContaCorrente conta = new ContaCorrente(12, 10);
                ContaCorrente conta2 = new ContaCorrente(10, 10);
                conta.Transferir(500, conta2);

            }
            catch(ArgumentException e)
            {
                //Console.WriteLine("Erro no parâmetro " + e.ParamName);
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                //Console.WriteLine(e.Message);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna)");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
           
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            leitor.LerProximaLinha();

            leitor.Fechar();
        }
    }  
}
