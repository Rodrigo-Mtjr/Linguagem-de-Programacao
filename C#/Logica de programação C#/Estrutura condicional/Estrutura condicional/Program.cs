using System;

namespace Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("O numero escolhido é par");
            }
            else
            {
                Console.WriteLine("o numero escolhido é impar");
            }

        }
    }
}
