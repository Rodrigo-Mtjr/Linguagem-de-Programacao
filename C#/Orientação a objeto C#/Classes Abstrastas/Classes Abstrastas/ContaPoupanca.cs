using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {
            TaxaJuros = 0;
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxa) : base(numero, titular, saldo)
        {
            TaxaJuros = taxa;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros / 100.00;
        }

        //Para puxar o metodo da superclasse, temos que usar a palavra override
        //E com a palavra sealed não deixa o metodo ser usado novamente em outra subclasse
        public sealed override void Sacar(double valor)
        {
            //a função base é para executar a mesma função da superclasse mas usando o valor da subclasse
            base.Sacar(valor);
            //nesse caso ele vai descontar mais 2 reais, ja que na superclasse ele desconta 5 do metodo.
            Saldo -= 2.00;
        }
    }
}