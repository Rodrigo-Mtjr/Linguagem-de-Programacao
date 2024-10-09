using System;

namespace Exercicios_Classes_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p1 = new Produtos();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p1);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int remove = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(remove);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);

        }
    }
}