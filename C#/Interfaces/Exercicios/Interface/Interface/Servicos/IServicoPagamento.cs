namespace Interface.Servicos
{
    public interface IServicoPagamento
    {
        //Criando esses metodos abaixo para facilitar na implementação de outras plataformas de pagamento.
        //Porque de uma plataforma de pagamento para outra, o que muda, são as taxas. 
        //Entao com esses dois metodos, que provavelmente vai ser igual pra todas, fica mais facil modificar no codigo que vai "herdar" a implementação, outros valores de taxas
        //de diferentes plataformas de pagamento. Deixando o codigo mais facil para possiveis mudanças.

        //Taxa de pagamento vai sempre receber a taxa como para calculo.
        double TaxaPagamento(double quantia);
        //Juros mensal vai sempre receber o valor do juros, mais os meses para calculo desse juros ao longo do tempo.
        double JurosMensal(double quantia, int meses);
    }
}
