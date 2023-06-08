using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entidades
{
    class ContaBanco : Conta
    {
        public double Limiteemprestimo { get; set; }

        public ContaBanco()
        {
        }

        public ContaBanco(int numeroConta, string titular, double saldo, double limiteemprestimo)
            : base(numeroConta, titular, saldo)
        {
            Limiteemprestimo = limiteemprestimo;
        }

        public void Emprestimo(double quantidade)
        {
            if (quantidade <= Limiteemprestimo)
            {
                Saldo = Saldo + quantidade;
            }
        }
    }

   
}
