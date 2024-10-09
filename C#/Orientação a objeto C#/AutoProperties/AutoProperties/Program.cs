using Propertis__Propriedades_;
using System;

namespace Propertis
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 0);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("f2"));


            p.Nome = "TV 4k";
            p.AumentarValorPreco(50.00);
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("f2"));

            p.BaixarValorPreco(100.00);
            Console.WriteLine(p.Preco.ToString("f2"));



        }


    }
}
