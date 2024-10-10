using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de alturas: ");
            int n = int.Parse(Console.ReadLine());

            //Criando uma variavel com o nome de vetor, que a mesma vai ser um array (vetor) que vai receber um new double e a quantidade que for digitada na variavel N.
            double[] vetor = new double[n];

            //Utilizando FOR para acessar as posições do vetor e salvar cada altura digita na sua posição utilizando a variavel i como parametro para isso (vetor[i]).
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os " + n + " valores das alturas: ");
                //Salvando cada valor digitado pelo usuario dentro das posições do vetor com a variavel i do for.
                vetor[i] = double.Parse(Console.ReadLine());
            }

            //Declarando uma variavel sum recebendo zero.
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                //Utilizando o FOR novamente para que ele percorra cada posição do vetor e vá somando com o valor na variavel sum e cada posição i do vetor.
                sum = sum + vetor[i];
            }
            
            //Fazendo a media das alturas e mostrando no final
            double media = sum / n;
            Console.WriteLine("MEDIA DAS ALTURAS: " + media);
        }
    }
}