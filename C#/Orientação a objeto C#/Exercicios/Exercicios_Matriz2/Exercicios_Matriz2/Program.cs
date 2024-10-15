using System;

namespace Exercicios_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                Console.WriteLine("Digite os valores da linha #{0}: ", l + 1);
                string[] valores = Console.ReadLine().Split(' ');
                for (int c = 0; c < coluna; c++)
                {
                    matriz[l, c] = int.Parse(valores[c]);
                }
            }


            Console.WriteLine();
            Console.Write("Digite um valor da matriz: ");
            int valor = int.Parse(Console.ReadLine());

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    //Verificando se o valor que está na matriz posição [l,c] é igual a o valor digitado
                    //se sim, ele vai mostrar na tela a posição dele
                    if (matriz[l, c] == valor)
                    {
                        Console.WriteLine("Posição " + l + "," + c + ":");

                        //Vendo se a coluna que o numero se encontra é maior que zero, se sim, vai mostrar o numero que esta a esquerda do valor
                        if (c > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[l, c - 1]);
                        }
                        //Verificando se a linha que o numero se encontra é maior que zero, se sim, vai mostrar o numero acima do valor digitado
                        if (l > 0)
                        {
                            Console.WriteLine("Em cima: " + matriz[l - 1, c]);
                        }
                        //Verifica se a coluna atual (c) é menor que o número total de colunas menos 1 (coluna - 1). Se for, imprime o elemento à direita (coluna c + 1) da posição atual.
                        if (c < coluna - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[l, c + 1]);
                        }
                        //Verifica se a linha atual (l) é menor que o número total de linhas menos 1 (linha - 1). Se for, imprime o elemento abaixo (linha l + 1) da posição atual.
                        if (l < linha - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[l + 1, c]);
                        }
                    }
                }

            }
        }
    }
}