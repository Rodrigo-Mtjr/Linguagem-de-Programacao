using System;
using System.Globalization;

namespace Vetores_Exemplo_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de produtos que você quer: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o valor do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product(nome, preco);

            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum = sum + vect[i].Preço;
            }

            double avg = sum / n;

            Console.WriteLine("A MEDIA ENTRE OS PRODUTOS É: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
