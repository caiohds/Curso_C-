using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        

        public Cliente Titular{get; set;}
        private string Conta { get; set; }
        private int Numero_agencia { get; set; }
        private string Nome_agencia { get; set; }
        private double saldo;

        public ContaCorrente()
        {
            Titular = new Cliente();
            Conta = "";
            Numero_agencia = 0;
            Nome_agencia = "";
            saldo = 0.0;
        }
     
        public bool sacar(double valor) 
        {
            if (saldo < valor) 
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
            saldo = saldo - valor;
            return true;
        }
        public bool depositar(double valor)
        {   
            if(valor <= 0)
            {
                Console.WriteLine("Valor inválido!");
                return false;
            }
            saldo = saldo + valor;
            Console.WriteLine("Saldo realizado com sucesso!");
            return true; 
        }
        public bool tranferir(double valor,ContaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            }if(valor < 0)
            {
                return false;
            }
            saldo = saldo - valor;
            destino.saldo = destino.saldo + valor;
            return true;
        }
        
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {   
                if(value < 0)
                {
                    return; 
                }
                saldo = value;
            }
        }
        public override string ToString()
        {
            return "Nome do Titular: " + titular.nome + 
                   "\nConta: " + conta + 
                   "\nNúmero da Agência: " + numero_agencia + 
                   "\nNome da Agência: " + nome_agencia +
                   "\nSaldo: " + saldo;
        }
    }
}