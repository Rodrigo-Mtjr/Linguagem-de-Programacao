using System;
using System.Globalization;

namespace Exercicio_de_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preço = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idada e altura (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade1 = int.Parse(vet[1]);
            double altura1 = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Resultado do exercicio: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preço);
            Console.WriteLine(nome1);
            Console.WriteLine(idade1);
            Console.WriteLine(altura1);

        }
    }
}
