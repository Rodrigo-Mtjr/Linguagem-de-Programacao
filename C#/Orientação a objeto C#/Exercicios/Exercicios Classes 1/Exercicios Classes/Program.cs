using System;
using System.Globalization;

namespace Exercicios_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1

            /*Dados p1 = new Dados();
            Dados p2 = new Dados();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.nome);
            }*/



            //EXERCICIO 2

            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();
            double media;

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("f2", CultureInfo.InvariantCulture));
    
          


        }
    }
}
