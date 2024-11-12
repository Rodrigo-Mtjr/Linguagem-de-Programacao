
namespace Interface.Entidades
{
    public class Parcelamento
    {
        public DateTime DataVencimento { get; set; }
        public double Quantia { get; set; }

        public Parcelamento (DateTime dataVencimento, double quantia)
        {
            DataVencimento = dataVencimento;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2");
        }
    }
}
