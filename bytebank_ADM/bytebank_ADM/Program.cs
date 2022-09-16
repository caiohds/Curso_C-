using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");
GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
Funcionario joao = new Funcionario();

joao.Nome = "João";
joao.Cpf = "12345698";
joao.Salario = 2000.0; 

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "12345798";
paula.Salario = 5000.0;

Funcionario pedro = new Diretor();

Console.WriteLine("Bonificação do João: " + joao.getBonificacao());
Console.WriteLine("Bonificação da Paula: " + paula.getBonificacao());
gerenciador.Registrar(joao);
gerenciador.Registrar(paula);
Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());

Console.ReadKey();
