using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o exercicio do Hotel para colocar o FOREACH em pratica

            Hotel[] hotel = new Hotel[10];

            Console.Write("Quantos quartos serão reservados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("ALUGUEL #{0}",i);
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write("EMAIL: ");
                string email = Console.ReadLine();
                Console.Write("QUARTO: ");
                int quarto = int.Parse(Console.ReadLine());

                hotel[quarto] = new Hotel(nome, email);   
            }

            Console.WriteLine();
            Console.WriteLine("QUARTOS OCUPADOS:");


            foreach (object obj in hotel)
            {
                if (obj is Hotel != null)
                {
                    Console.WriteLine(obj);
                }

            }
        }
    }
}