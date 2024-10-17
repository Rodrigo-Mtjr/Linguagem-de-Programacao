using System;
using Exercicios_Herança_2;

namespace Exericios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto {i}: ");
                Console.Write("Produto comum, importado ou usado?(c/u/i): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                if (resp == 'i')
                {
                    Console.Write("Digite o valor da taxa alfandegaria R$: ");
                    double taxa = double.Parse(Console.ReadLine());
                    lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else if (resp == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (resp == 'u')
                {
                    Console.Write("Digite a data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    Console.WriteLine("Por favor, digite uma das letras como solicitado!");
                    resp = char.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("ETIQUE DE PREÇOS: ");
            foreach (Produto produto in lista)
            {
                Console.WriteLine(produto.EtiquetaPreco());
            }
        }
    }
}