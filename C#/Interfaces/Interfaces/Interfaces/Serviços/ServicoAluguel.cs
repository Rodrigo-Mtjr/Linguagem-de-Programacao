using Interfaces.Entidades;

namespace Interfaces.Serviços
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        //Declanrando uma variavel do tipo ISERVICOIMPOSTO, que é a interface
        private IServicoImposto _servicoImposto;

        //Colocando no construtor, o parametro de entrada junto com o serviço de imposto criado
        //Para que quando o usuario for indicar o tipo de serviço, ele instanciar o serviço do pais certo
        public ServicoAluguel(double precoHora, double precoDia, IServicoImposto servicoImposto)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _servicoImposto = servicoImposto;
        }

        
        public void ProcessarFatura(AluguelCarro aluguelCarro)
        {
            //Criando um metodo onde ele vai processar o valor da fatura desse aluguel de carro
            //Nessa parte abaixo estamos criando uma variavel do tipo TIMESPAN chamada duracao
            //Ela vai receber da classe ALUGUELCARRO a data de devolução menos a data de retirada, da mesma classe.
            //A diferença que der, vai ser salva na variavel DURACAO
            TimeSpan duracao = aluguelCarro.DataDevolucao.Subtract(aluguelCarro.DataRetirada);

            //Em seguida declaramos uma variavel do tipo double recebendo zero, que vai ser a variavel que vai conter o valor dessa fatura
            double pagamentoBasico = 0.0;

            //Se a duração em HORAS for menor que 12 horas
            if (duracao.TotalHours < 12)
            {
            //F azemos entao a variavel pagamentobasico receber o PrecoHora da classe ServicoAlguel * a quantidade de horas obtida na diferença.
            //MATH.CEILING ARREDONDA PRA CIMA!!
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }

            else
            {
            //Fazemos entao a varaivel pagamentobasico receber o PRECODIA * a quantidade de dias obtido na diferença
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _servicoImposto.Imposto(pagamentoBasico);

            aluguelCarro.Fatura = new Fatura(pagamentoBasico, imposto);

        }
    }
}
