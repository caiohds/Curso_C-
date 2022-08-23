using bytebank;
using bytebank.Titular;

Cliente cliente = new Cliente();
cliente.nome = "Caio Henrique";
cliente.cpf = "12345678-91";
cliente.profissao = "Programador c#";

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = cliente;
conta1.Conta = "2513252-X";
conta1.Numero_agencia = 35;
conta1.Nome_agencia = "Agência Central";

Console.WriteLine(cliente.nome);
Console.WriteLine(conta1.titular.nome);

Console.ReadKey();