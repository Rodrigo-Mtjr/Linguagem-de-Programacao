using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    //Criando uma classe do tipo CONTA com seus atributos e métodos, essa será a SUPER CLASSE.
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //Declarando que o atributo Saldo só pode ser alterado pela mesma classe ou pela subclasse que herde ela.
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta (int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
