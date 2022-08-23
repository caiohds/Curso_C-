using bytebank;
using bytebank.Titular;

Cliente cliente = new Cliente("Caio Henrique","12345678-23","Programador c#");
Cliente cliente2 = new Cliente("Joana", "12201301-12", "Atendente");

ContaCorrente conta1 = new ContaCorrente(cliente,"12034-x",12,"Agência x", 100.0);
ContaCorrente conta2 = new ContaCorrente(cliente2, "12043-x", 13, "Agência y", 100.0);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();