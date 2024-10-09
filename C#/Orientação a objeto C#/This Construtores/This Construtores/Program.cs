using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Em vez de instanciar no começo do codigo, vai ser instanciado depois da entrada dos dados*/

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* Instanciando o objeto e usando o que foi digitado pelo usuario como parametro*/
            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            /*Sintaxe para instaciar o produto, mesmo que não tenha construtores*/
            Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 10
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
