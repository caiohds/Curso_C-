using bytebank;
using bytebank.Titular;

Cliente cliente = new Cliente();
cliente.nome = "Caio Henrique";
cliente.cpf = "12345678-91";
cliente.profissao = "Programador c#";

ContaCorrente conta1 = new ContaCorrente();

conta1.Titular = cliente;
conta1.conta = "2513252-X";
conta1.numero_agencia = 35;
conta1.nome_agencia = "Agência Central";
conta1.Saldo = 150;

Console.WriteLine(cliente.nome);
Console.WriteLine(conta1.Saldo);

Console.ReadKey();