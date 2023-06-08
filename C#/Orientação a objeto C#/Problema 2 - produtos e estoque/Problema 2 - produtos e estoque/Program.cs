using System;
using System.Globalization;

namespace Problema_2___produtos_e_estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
                      
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();


            Console.Write("Digite o numero de produtos a ser removidos do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            Console.WriteLine();
            p.RemoverProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
