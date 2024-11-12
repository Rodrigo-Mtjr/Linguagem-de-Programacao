namespace Interface.Servicos
{
    public class ServicoPaypal : IServicoPagamento
    {
        //Criando os atributos e ja passando os valores para eles.
        private const double TaxaPorPagamento = 0.02;
        private const double TaxaParcela = 0.01;


        //Metodos de JurosMensal, igual na interface, com os mesmo parametros de entrada.
        public double JurosMensal(double quantia, int meses)
        {
            //Só que aqui, a gente entra com o calculo do metodo, na interface não. 
            //Lembrando que o nome tem que ser igual ao da interface, senão, da erro.
            //Vai retornar para o usuário a quantia de parametro vezes a TaxaParcela que é o atributo + os meses que é de parametro de entrada. 
            return quantia * TaxaParcela * meses;
        }

        public double TaxaPagamento(double quantia)
        {
            return quantia * TaxaPorPagamento;
        }
    }
}
