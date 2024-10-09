using Exercicios_Banco;
using System;
using System.ComponentModel.Design;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            
            Console.WriteLine("Haverá deposito inicial (S/N)?: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {    
                Console.Write("Entre com o valor de deposito: R$");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            conta.DepositarValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            conta.SacarValor = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}