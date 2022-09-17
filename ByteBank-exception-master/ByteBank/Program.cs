using System;
using System.Collections.Generic;
using System.Data;
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
            ContaCorrente conta1 = new ContaCorrente(7480, 874250);

            Console.WriteLine(ContaCorrente.TaxaOperacao);
            metodo(11);
            Console.ReadLine();
            
        }
        private static void metodo(int numero)
        {
             TestaDivisao(numero);
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = dividir(10, divisor);
            if(resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por 0!");
                return;
            }
            if(resultado == -2)
            {
                Console.WriteLine("O divisor não pode ser maior que 10!");
                return;
            }
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + ": " + resultado);
        }
        private static int dividir(int numero, int divisor)
        {
            if(divisor == 0)
            {
                return -1;
            }
            if(divisor > numero)
            {
                return -2;
            }
            return numero / divisor;
        }
    }
}
