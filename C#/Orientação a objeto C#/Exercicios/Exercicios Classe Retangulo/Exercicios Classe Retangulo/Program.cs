using System;

namespace Exercicios_Classe_Retangulo
{
    class Program
    {
        static void Main (string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do rentagulo: ");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());


          
            Console.WriteLine("Area = " + ret.Area());
            Console.WriteLine("Perimetro = " + ret.Perimetro());
            Console.WriteLine("Diagonal = " + ret.Diagonal());
        }
    }
}

