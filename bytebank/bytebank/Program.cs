using bytebank;
Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente cc = new ContaCorrente();
cc.titular = "Caio";
cc.conta = "10123-x";
cc.numero_agencia = 12;
cc.nome_agencia = "Agência central";
cc.saldo = 100.0;

Console.WriteLine("Titular: " + cc.titular + 
                  "\nConta: " + cc.conta +
                  "\nNúmero da Agência: " + cc.numero_agencia + 
                  "\nNome da Agência: " + cc.nome_agencia +
                  "\nSaldo: " + cc.saldo);

Console.ReadKey();