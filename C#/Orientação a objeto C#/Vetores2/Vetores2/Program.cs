using System;
using System.Diagnostics.CodeAnalysis;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos: ");
            int qtde = int.Parse(Console.ReadLine());

            //Declarando um vetor do tipo produto, que é a classe criada para o problema, que ele vai receber a quantidade que for definida pelo usuario em QTDE.
            Produto[] vetor = new Produto[qtde];

            for (int i = 0; i < qtde; i++)
            {
                Console.Write("Digite o nome do item: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do item: R$");
                double preco = double.Parse(Console.ReadLine());
                //Instanciando o vetor com o objeto produto, onde colocamos os valores salvos em nome e preco, nos atributos do objeto na classe NOME e PRECO.
                //Usando a variavel i do for para salvar em cada posição conforme o loop continua.
                vetor[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i = 0;i < qtde; i++)
            {
                //Fazendo a soma usando o for com os valores salvos em cada posição do vetor onde se encontra o preço do produto.
                soma = soma + vetor[i].Preco;
            }

            double media = soma / qtde;

            Console.WriteLine("Soma média dos valores: R$" + media.ToString("f2"));

        }
    }
}