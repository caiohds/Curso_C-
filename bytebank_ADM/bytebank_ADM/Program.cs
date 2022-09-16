using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("Boas vindas ao ByteBank Administração.");
CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer pedro = new Designer("Pedro", "833.222.048-39");

    Diretor paula = new Diretor("Paula", "159.753.398-04");

    Auxiliar igor = new Auxiliar("Igor", "981.198.778-53");

    GerenteDeContas camila = new GerenteDeContas("Camila", "326.985.628-89");

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Bonificação total: " + gerenciador.getBonificacao());
}







Console.ReadKey();
