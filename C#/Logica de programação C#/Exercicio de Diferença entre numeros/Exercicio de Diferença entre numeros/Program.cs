using System;

namespace Exercicio_de_Diferença_entre_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 numeros na mesma linha depois aperte enter:");

            string[] vet = Console.ReadLine().Split(' ');
            int x1 = int.Parse(vet[0]);
            int x2 = int.Parse(vet[1]);
            int x3 = int.Parse(vet[2]);
            int x4 = int.Parse(vet[3]);

            int diff = x1 * x2 - x3 * x4;

            Console.WriteLine("diferença dos numeros =" + diff);
            
            
        }
    }
}
