using System;
using System.Globalization;

namespace NULLABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double? x = null;
            double? y = null;

            Console.WriteLine(x);
            Console.WriteLine(y);*/

            Console.WriteLine("DIGITE A QUANTIDADE DE NUMEROS PARA MEDIA: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum = sum + vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("A MEDIA ENTRE OS NUMEROS É = " + avg.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
