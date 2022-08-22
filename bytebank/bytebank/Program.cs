using bytebank;
Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente cc = new ContaCorrente();
cc.Titular = "Caio";
cc.Conta = "10123-x";
cc.Numero_agencia = 12;
cc.Nome_agencia = "Agência central";
cc.Saldo = 100.0;



//Console.WriteLine(cc.ToString());

Console.WriteLine("Saldo pré saque: " + cc.Saldo);
Console.WriteLine("Digite o valor do saque: ");
cc.sacar(Double.Parse(Console.ReadLine()));

Console.WriteLine("Saldo pós saque: " + cc.Saldo);
Console.ReadKey();