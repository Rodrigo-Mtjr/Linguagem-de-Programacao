using System;

namespace Estrutura_Repetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros você quer digitar?: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }

            Console.WriteLine("A soma dos numeros é = " + soma);
        }
    }
}
