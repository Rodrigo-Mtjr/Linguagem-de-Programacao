using System;
using System.Globalization;

namespace exercicios_1
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é de R${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é de R${preco2}");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            Console.Write("Regristro: ");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais)" + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant cultutre: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
