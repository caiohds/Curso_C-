

using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");

Funcionario joao = new Funcionario(2);

joao.Nome = "João";
joao.Cpf = "12345698";
joao.Salario = 2000.0;

Console.WriteLine("Bonificação: " + joao.getBonificacao());
Console.ReadKey();
