namespace bytebank
{
    public class ContaCorrente
    {
        public string Titular;
        public string Conta;
        public int Numero_agencia;
        public string Nome_agencia;
        public double Saldo;

        public ContaCorrente(string titular, string conta, int numero_agencia, string nome_agencia, double saldo)
        {
            this.Titular = titular;
            this.Conta = conta;
            this.Numero_agencia = numero_agencia;
            this.Nome_agencia = nome_agencia;
            this.Saldo = saldo;
        }
        public ContaCorrente() { 
            this.Numero_agencia = 0;
            this.Conta = "";
            this.Titular = "";
            this.Nome_agencia = "";
            this.Saldo = 0.0;
        }
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
       
        public override string ToString()
        {
            return "Titular: " + Titular + 
                   "\nConta: " + Conta + 
                   "\nNúmero da Agência: " + Numero_agencia + 
                   "\nNome da Agência: " + Nome_agencia +
                   "\nSaldo: " + Saldo;
        }
    }
}