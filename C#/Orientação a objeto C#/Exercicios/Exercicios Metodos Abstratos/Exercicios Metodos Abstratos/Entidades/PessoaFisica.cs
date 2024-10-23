namespace Exercicios_Metodos_Abstratos.Entidades
{
    class PessoaFisica : Contribuinte
    {
         public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }
        public override double Imposto()
        {
            if (RendaAnual < 2000.00)
            {
                return RendaAnual * 15.00 / 100.00 - GastoSaude * 50.00 / 100.00;
            }
            else
            {
                return RendaAnual * 25.00 / 100.00 - GastoSaude * 50.00 / 100.00;
            }
        }
    }
}
