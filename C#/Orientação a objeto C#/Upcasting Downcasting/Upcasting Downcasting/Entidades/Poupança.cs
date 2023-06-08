

namespace Upcasting_Downcasting.Entidades
{
    class Poupança : Herança.Entidades.Conta
    {
        public double TaxaJuros { get; set; }

        public Poupança()
        {
        }
        public Poupança(int numeroConta, string titular, double saldo, double taxajuros)
            : base(numeroConta, titular, saldo)
        {
            taxajuros = TaxaJuros;
        }


        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
