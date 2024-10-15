using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando e instancinado uma matriz do tipo double, onde ela vai ter duas linhas e três colunas.
            double[,] matriz = new double[2, 3];

            //Contando o tamanho da matriz, que será o total de posições que existem dentro dela.
            Console.WriteLine(matriz.Length);

            //Contando o total de linhas que existe dentro da matriz
            Console.WriteLine(matriz.Rank);

            //Contando o tamanho de linhas usando o get e colocando qual parametro para identificar
            Console.WriteLine(matriz.GetLength(0));

            //Mesma coisa que o de cima, agora usando o parametro das colunas, que sera 3.
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}