namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        public ContaCorrente(string titular, string conta, int numero_agencia, string nome_agencia, double saldo)
        {
            this.titular = titular;
            this.conta = conta;
            this.numero_agencia = numero_agencia;
            this.nome_agencia = nome_agencia;
            this.saldo = saldo;
        }
        public ContaCorrente() { 
            this.numero_agencia = 0;
            this.conta = "";
            this.titular = "";
            this.nome_agencia = "";
            this.saldo = 0.0;
        }
        public string toString() {
            return "Titular: " + titular + 
                   "\nConta: " + conta + 
                   "\nNúmero da Agência: " + numero_agencia + 
                   "\nNome da Agência: " + nome_agencia +
                   "\nSaldo: " + saldo;
        }
    }
}