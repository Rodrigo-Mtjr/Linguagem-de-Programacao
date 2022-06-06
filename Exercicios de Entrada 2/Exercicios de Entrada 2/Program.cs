using System;

namespace Exercicios_de_Entrada_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int total = numero1 + numero2;

            Console.Write("SOMA = " + total);           
           

        }
    }
}
