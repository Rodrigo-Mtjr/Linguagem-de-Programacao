using System;
using System.Globalization;

namespace Exercicio_nivelamento
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, pi = 3.14159;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = pi * r * r;

            Console.WriteLine("A= " + a.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}
