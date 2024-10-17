using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_e_Downcasting
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxa) : base(numero, titular, saldo)
        {
            TaxaJuros = taxa;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}
