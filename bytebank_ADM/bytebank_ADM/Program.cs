using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");
GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
Funcionario joao = new Funcionario("João","12345698",2000.0);
Diretor paula = new Diretor("Paula","12345798", 5000.0);

Console.WriteLine("Bonificação do João: " + joao.getBonificacao());
Console.WriteLine("Bonificação da Paula: " + paula.getBonificacao());
gerenciador.Registrar(joao);
gerenciador.Registrar(paula);
Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
Console.WriteLine("Total de Funcionários: " + Funcionario.totalFuncionarios);

Console.WriteLine("Antigo salário do João: " + joao.Salario);
joao.aumentarSalario();
Console.WriteLine("Novo salário do João: " + joao.Salario);

Console.WriteLine("Antigo salário da Paula: " + paula.Salario);
paula.aumentarSalario();
Console.WriteLine("Novo salário da Paula: " + paula.Salario);
Console.ReadKey();
