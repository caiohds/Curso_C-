using bytebank;
using bytebank.Titular;

Cliente cliente = new Cliente("Caio Henrique","12345678-23","Programador c#");


ContaCorrente conta1 = new ContaCorrente(cliente,"12034-x",12,"Agência x", 100.0);


Console.WriteLine(cliente.Nome);
Console.WriteLine(conta1.Saldo);

Console.ReadKey();