using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");
//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer pedro = new Designer("Pedro", "833.222.048-39");

    Desenvolvedor samia = new Desenvolvedor("Samia", "451585606416");

    Diretor paula = new Diretor("Paula", "159.753.398-04");

    Auxiliar igor = new Auxiliar("Igor", "981.198.778-53");

    GerenteDeContas camila = new GerenteDeContas("Camila", "326.985.628-89");

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samia);
    Console.WriteLine("Bonificação total: " + gerenciador.getBonificacao());
    Console.WriteLine("Quantidade de Funcionários registrados no sistema: " + Funcionario.totalFuncionarios);

}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();
    Diretor roberta = new Diretor("Roberta", "159.753.398-04");
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("Ursula", "326.985.628-89");
    ursula.Senha = "321";

    Funcionario pedro = new Designer("Pedro", "326.985.628-89");
    pedro.Senha = "2022";

    sistemaInterno.Logar(pedro, "2022");
    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(ursula, "321");
}





Console.ReadKey();
