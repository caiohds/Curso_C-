using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; }
        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = Arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo Linha...");
            throw new IOException();
            return "Linha do arquivo";
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando o arquivo...");
        }
    }
}
