
namespace Upcasting_e_Downcasting
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia < LimiteEmprestimo)
            {
                Saldo += quantia;                
            }
        }
    }
}
