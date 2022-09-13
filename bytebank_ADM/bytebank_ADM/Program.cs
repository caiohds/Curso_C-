

using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");

Funcionario joao = new Funcionario();

joao.Nome = "João";
joao.Cpf = "12345698";
joao.Salario = 2000.0;

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "12345798";
paula.Salario = 5000.0;
Console.WriteLine("Bonificação do João: " + joao.getBonificacao());
Console.WriteLine("Bonificação da Paula: " + paula.getBonificacao());
Console.ReadKey();
