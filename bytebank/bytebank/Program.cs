using bytebank;
Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente cc = new ContaCorrente();
cc.Titular = "Caio";
cc.Conta = "10123-x";
cc.Numero_agencia = 12;
cc.Nome_agencia = "Agência central";
cc.Saldo = 100.0;

ContaCorrente conta1 = new ContaCorrente("Celso", "1910-x", 13, "Agência X", 100.0);

Console.WriteLine("Saldo do " + cc.Titular + " pré transferência: " + cc.Saldo);
Console.WriteLine("Saldo do " + conta1.Titular + " pré transferência: " + conta1.Saldo);


Console.WriteLine();
Console.WriteLine(conta1.tranferir(30, cc) ? "Transferência realizada com sucesso!" : "Falha na transferência");
Console.WriteLine();
Console.WriteLine("Saldo do " + cc.Titular + " pós transferência: " + cc.Saldo);
Console.WriteLine("Saldo do " + conta1.Titular + " pós transferência: " + conta1.Saldo);


Console.ReadKey();