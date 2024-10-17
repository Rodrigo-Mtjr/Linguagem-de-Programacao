using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao
{
    //Classe Conta ABSTRATA
    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }


        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //Declarando a função na Superclasse como virtual, para que ela possa ser usada em outras subclasses
        public virtual void Sacar(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
