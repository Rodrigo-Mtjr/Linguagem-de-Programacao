using System;
using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial(S/N)?: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double deposioInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposioInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor de saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}
