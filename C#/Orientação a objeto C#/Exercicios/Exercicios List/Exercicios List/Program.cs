using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionarios vao ser registrados?: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, name, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o codigo do funcionario que vai receber o aumento:");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == idAumento);
            if (func != null)
            {
                Console.Write("Digite o percentual de aumento: ");
                double percentual = double.Parse(Console.ReadLine());
                func.aumentoSalario(percentual);
            }
            else
            {
                Console.WriteLine("FUNCIONARIO NAO IDENTIFICADO");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios atualizada:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
