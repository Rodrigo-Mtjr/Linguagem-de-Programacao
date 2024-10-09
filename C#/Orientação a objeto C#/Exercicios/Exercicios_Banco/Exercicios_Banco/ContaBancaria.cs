using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Banco
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            Numero = numeroConta;
            Titular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this (numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public double DepositarValor
        {
            set { Saldo += value; }
        }

        public double SacarValor
        {
            set { Saldo = (Saldo - 5.00) - value ;}
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", "
                + "Titular: "
                + Titular 
                + ", Saldo em conta: R$"
                + Saldo.ToString("F2");
        }

    }
}
