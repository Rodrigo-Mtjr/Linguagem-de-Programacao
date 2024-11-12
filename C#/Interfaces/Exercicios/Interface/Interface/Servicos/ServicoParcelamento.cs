using Interface.Entidades;
using Interface.Servicos;


//Essa classe foi criada, para gerar o processo que a empresa deseja sobre os contratos, que é automatizar a questão de valores de parcelas do contrato total.
namespace Interface.Servicos 
{
    public class ServicoParcelamento
    {
        //criando um atributo privado, do tipo IServicoPagamento (interface), fazendo com que essa classe, consiga acessar os metodos criados na interface e com as taxas da outra classe.
        private IServicoPagamento _servicoPagamentoOnline;

        //Criando um construtor, que vai receber o atributo servicoPagamentoOnline, que vai ser colocado dentro da variável com o mesmo nome.
        public ServicoParcelamento(IServicoPagamento servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        //Criando um metodo, onde ele vai receber como parametro uma variavel do tipo CONTRATO, para poder acessar as informações da classe CONTRATO e os MESES que o usuario passar.
        public void ProcessoContrato(Contrato contrato, int meses)
        {
            //Querendo saber qual o valor da cota por mes, pegando o valor total do contrato e dividindo pelo numero de meses.
            double valorBase = contrato.ValorContrato / meses;
            for (int i = 1; i <= meses; i++)
            {
                //Declarando uma variável Datetime, que vai ser responsável em aumentar a quantidade de meses sobre parcelamento.
                //Ele sempre vai acrescentar um mês a mais dependendo da quantidade que foi passada na variável meses, utilizando o i do for.
                DateTime data = contrato.DataInicio.AddMonths(i);
                
                //Declarando uma variável atualizarValor, onde ela vai receber o valorBase do contrato, que é adquirido com o valor total do contrato divido pelos meses de parcelas.
                //Ela vai receber o valorBase + o calculo definido dentro da interface com os calculos dentro da classe SERVIÇOPAYPAL
                double atualizarValor = valorBase + _servicoPagamentoOnline.JurosMensal(valorBase, i);

                //Declarando uma variável valorTotal, onde ela vai receber a variável atualizarValor, que é a cota do parcelamento com juros mensal, mais o metodo TaxaPagamento 
                //Que vai calcular o valor obtido em atualizarValor * a TaxaPagamento que foi definida na classe SERVIÇOPAYPAL
                double valorTotalParcelamento = atualizarValor + _servicoPagamentoOnline.TaxaPagamento(atualizarValor);

                //Depois de tudo isso, salvamos o valor da parcela do mes i dentro da lista criada em contrato, utilizando o metodo AddParcelamento.
                //Com ele que vamos salvar todas as parcelas colocadas pelo usuário na hora de definir a quantidade.
                //Ele vai usar a nova data, salva em DATA no começo do FOR, e depois o valor total, que seria o valor final do parcelamento.
                contrato.AddParcelamento(new Parcelamento(data, valorTotalParcelamento));
            }
        }
    }
}
