using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string Conta;
        public int Numero_agencia;
        public string Nome_agencia;
        public double Saldo;

     
        public bool sacar(double valor) 
        {
            if (Saldo < valor) 
            {
                Console.WriteLine("Digite um valor menor que o saldo!");
                return false;
            }
            if (valor < 0) 
            {
                Console.WriteLine("Digite um valor maior que 0!");
                return false;
            }
            Console.WriteLine("Saque Realizado com sucesso!");
            Saldo = Saldo - valor;
            return true;
        }
        public bool depositar(double valor)
        {   
            if(valor <= 0)
            {
                Console.WriteLine("Valor inválido!");
                return false;
            }
            Saldo = Saldo + valor;
            Console.WriteLine("Saldo realizado com sucesso!");
            return true; 
        }
        public bool tranferir(double valor,ContaCorrente destino)
        {
            if(Saldo < valor)
            {
                return false;
            }if(valor < 0)
            {
                return false;
            }
            Saldo = Saldo - valor;
            destino.Saldo = destino.Saldo + valor;
            return true;
        }
       
        public override string ToString()
        {
            return "Nome do Titular: " + titular.nome + 
                   "\nConta: " + Conta + 
                   "\nNúmero da Agência: " + Numero_agencia + 
                   "\nNome da Agência: " + Nome_agencia +
                   "\nSaldo: " + Saldo;
        }
    }
}