using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entidades
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

    }
}
