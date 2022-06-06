using System;
using System.Globalization;

namespace Exercicio_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do funcionario :");
            int numerofun = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas desse funcionario: ");
            double horario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos que ele recebe por hora? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salariotot = horario * salario;

            Console.WriteLine("Numero do Funcionario: " + numerofun);
            Console.WriteLine("Salario Mensal: R$" + salariotot.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
