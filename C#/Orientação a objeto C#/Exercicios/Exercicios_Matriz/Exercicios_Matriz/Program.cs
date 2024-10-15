using System;

namespace Exercicio_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            //Criando um for para acessar cada linha (l) da matriz que vai usar o valor de N como parada
            for (int l = 0; l < n; l++)
            {
                //Pedindo para o usuário digitar os valores e depois salvar eles em um vetor string dividindo por split "espaço".
                Console.WriteLine("Digite os valores da linha #{0}: ", l+1);
                string[] valores = Console.ReadLine().Split(' ');

                //Criando um for para acessar as colunas (c) da matriz, que também vai usar o valor de N.
                for (int c = 0; c < n; c++)
                {
                    //Fazendo com que o que foi digitado no vetor valores, seja salvo como int dentro da matriz
                    //No primeiro momento a coluna e linha vão ser zero matriz[l = 0 e c = 0]
                    //Depois vai ter a iteração do for e vai sempre aumentar a coluna, coluna 0, coluna 1 e coluna 2 (total 3 no exemplo).
                    //Em seguida o sistema sai do for, porque na declaração o valor de N é 3, 3 coluna e 3 linhas, então passou quando iterou.
                    //E assim ele testa o for de cima, para agora ir para a linha 1 assim por diante.
                    matriz[l,c] = int.Parse(valores[c]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            //Criando um for para acessar todas os valores da matriz, mas nesse caso queremos apenas os valores em diagonal.
            for (int i = 0; i <n; i++)
            {
                //A logica foi pensar que quando se trata de diagonal, os valores estão dentro das posições onde os numeros de colunas e linhas são iguais.
                //Então utilizamos o i que vai começar com 0, pois temos valores na posição [0,0] e repetimos ele novamente pra puxar a coluna.
                //Com isso ficou (matriz[i,i]), pois cada iteração do for, vai aumentar o valor de i até o limite de n e vai nos dar os valores da diagonal [0,0] [1,1] [2,2].
                Console.Write(matriz[i,i] + " ");
            }

            Console.WriteLine();

            //Criando um for para acessar novamente a matriz criada, onde usei a variavel l para linhas e c para colunas, para ficar mais facil.
            //Nesse caso queremos que mostre para o usuario a quantidade de numeros negativos dentro da matriz
            //Então a estrutura para percorrer a matriz é a mesma dos for's de cima, o que muda é que nesse tem um IF para saber se na posição matriz[l,c] o numero é menor que 0.
            //Se sim, ele aumenta o valor da variavel contador, que é a variavel de controle para saber a quantidade.
            int contador = 0;
            for (int l=0; l < n; l++)
            {
                for (int c = 0; c <n; c++)
                {
                    if (matriz[l,c] < 0)
                    {
                        contador = contador + 1;
                    }
                }
            }
            Console.Write("Total de números negativos: " + contador);
        }
    }
}