using ContaBancaria;
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
           
                ContaBancaria conta;
                Console.Write("Entre com o numero da conta: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Entre com o titular da conta: ");
                string titular = Console.ReadLine();

                Console.Write("Haverá deposito inicial? S/N: ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Entre com o valor incial: R$ ");
                    double valor = double.Parse(Console.ReadLine());
                    conta = new ContaBancaria(numero, titular, valor);
                }
                else
                {
                    conta = new ContaBancaria(numero, titular);
                }

            while (true)
            {

                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre com o valor para deposito: R$ ");
                double deposito = double.Parse(Console.ReadLine());
                conta.Depositar(deposito);

                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.Write("Entre um valor para saque: R$ ");
                double saque = double.Parse(Console.ReadLine());
                conta.Sacar(saque);

                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(conta);
                Console.WriteLine();

                Console.WriteLine("Deseja continuar? S/N: ");
                char continuar = char.Parse(Console.ReadLine());
                if (continuar == 'n' || continuar == 'N')
                {
                    break;
                }
            }

            Console.WriteLine("Finalizando sessão!");
            Console.WriteLine("Obrigado!");

           
        }
    }
}