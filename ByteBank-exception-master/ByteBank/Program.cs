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
            //ContaCorrente conta1 = new ContaCorrente(7480, 874250);

           // Console.WriteLine(ContaCorrente.TaxaOperacao);
 
            metodo(0);
            Console.ReadLine();

        }
        private static void metodo(int numero)
        {
            try
            {
                TestaDivisao(numero);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir um número por 0!");
            }
           
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + ": " + resultado);
        }
        private static int dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
