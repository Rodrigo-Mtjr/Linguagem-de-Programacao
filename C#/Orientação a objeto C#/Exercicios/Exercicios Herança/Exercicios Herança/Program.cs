using Exercicios_Herança;
using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Digite a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário {i}: ");
                Console.Write("É terceirizado? S/N: ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double valorPorHoras = double.Parse(Console.ReadLine());

                if (resp == 'S' || resp == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double despesa = double.Parse(Console.ReadLine());
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorHoras, despesa));
                }
                else
                {
                    lista.Add(new Funcionario(nome, horas, valorPorHoras));
                }
            }

            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func.Nome + " - " + "R$: " + func.Pagamento().ToString("f2"));
            }

        }
    }
}