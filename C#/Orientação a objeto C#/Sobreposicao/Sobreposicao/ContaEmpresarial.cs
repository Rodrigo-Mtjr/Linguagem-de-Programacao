using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao
{
    public class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        ContaEmpresarial()
        {
        }
        public ContaEmpresarial(int numero, string titular, double saldo, double limiteemprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteemprestimo;
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
