using Metodos_Abstratos.Entidades;
using Metodos_Abstratos.Entidades.Enums;
using System;


namespace Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> lista = new List<Shape>();
            Console.Write("Entre com o numero de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura {i}: ");
                Console.Write("Retângulo ou circulo (r/c)? :");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Cor (Black/Blue/Red): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());    

                if (tipo == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    lista.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    lista.Add(new Circle(raio, cor));
                }
            }

            foreach (Shape shape in lista)
            {
                Console.WriteLine("Areas das Figuras: " + shape.Area().ToString("F2"));
            }
        }
    }
}