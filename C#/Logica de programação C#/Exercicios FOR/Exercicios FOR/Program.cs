using System;
using System.Globalization;
namespace Exercicios_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 1 - NUMERO IMPARES

            /*Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Numeros impares: " + i);
                }
            }*/




            //EXERCICIO 2 -- NUMEROS DENTRO DE UM INTERVALO

            /*Console.Write("DIGITE A QUANTIDADE DE NUMERO DE UM INTERVALO: ");
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("valor #{0}: ", i);
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }
            Console.WriteLine(cont_in + " IN");
            Console.WriteLine(cont_out + " OUT");*/




            //EXERCICIO 3 - TABUADA

            /*Console.WriteLine("DIGITE QUAL TABUADA VOCE QUER SABER: ");
            int x = int.Parse(Console.ReadLine());

            int resultado = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * x;
                Console.WriteLine(i + " * " + x + " = " + resultado);
            }*/




            //EXERCICIO 4 

            /*int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
            }*/
        }
    }
}
