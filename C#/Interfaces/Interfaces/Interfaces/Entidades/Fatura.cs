using System.Reflection.Metadata.Ecma335;

namespace Interfaces.Entidades
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double TotalPagamento
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento mínimo: "
                + PagamentoBasico.ToString("F2")
                + "\nImposto: "
                + Imposto.ToString("f2")
                + "\nTotal pagamento: "
                + TotalPagamento.ToString("f2");
        }
    }
}
