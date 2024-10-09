using Exercicios_Classes_Funcionarios;
using System;


namespace Exercicios_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine();

            Console.WriteLine("Digite o valor de porcentagem para aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }

}
