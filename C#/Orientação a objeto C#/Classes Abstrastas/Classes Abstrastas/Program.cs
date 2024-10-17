using System;
using System.Collections.Generic;
using System.Diagnostics;
using Sobreposicao;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> lista = new List<Conta>();

            //Como a classe Conta ficou abstrata, não podemos instanciar um objeto do tipo Classe
            //Mas podemos dizer que a lista, é do tipo conta e que vai ter objetos dentro dela do tipo poupança e empresarial
            lista.Add(new ContaPoupanca(1001, "Alex", 500.00, 0.01));
            lista.Add(new ContaEmpresarial(1002, "Maria", 500.00, 400.00));
            lista.Add(new ContaPoupanca(1003, "Bob", 500.00, 0.01));
            lista.Add(new ContaPoupanca(1004, "Anna", 500.00, 500.00));

            double soma = 0.00;

            foreach (Conta conta in lista)
            {
                soma += conta.Saldo;
            }

            Console.WriteLine("Total do saldo: " + soma.ToString("F2"));

            foreach (Conta conta in lista)
            {
                conta.Sacar(10.00);
            }

            foreach (Conta conta in lista)
            {
                Console.WriteLine("Saldo atualizado para a conta: " + conta.Numero + ": " + conta.Saldo.ToString("f2"));
            }


        }
    }
}
