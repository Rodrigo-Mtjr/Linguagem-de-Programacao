
namespace Interfaces.Serviços
{
    //criando uma interface para ligar com outra classe
    //Nesse caso, estamos facilitando caso tenha outro tipo de imposto de outro pais
    //Então em vez de abrir o codigo na classe SERVIÇO DE ALUGUEL e trocar o codigo todo
    //juntamente alterando a classe IMPOSTOBRASIL, fazendo isso, a gente só tem que criar depois uma classe para o pais novo, caso tenha

    interface IServicoImposto
    {
        //Criando um metodo que vai receber o valor da taxa.
        //Depois ele é chamado dentro da classe que vai executar esse metodo com o valor do imposto
        double Imposto(double quantia);
    }
}
