using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variáveis opcionais que podem iniciar com o valor null ou com valores definidos
            double? x = null;
            double? y = 10;

            //Imprimindo na tela o valor que tiver na variavel x ou o valor como padrão, que será 0
            Console.WriteLine(x.GetValueOrDefault());
            //Imprimindo na tela o valor que tiver na varivael y ou o valor como padrão, que será 10
            Console.WriteLine(y.GetValueOrDefault());

            //Imprimindo na tela o teste para saber se existe ou não valor dentro das variaveis, se sim TRUE senão FALSE
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Verificando com a função HASVALUE se existe valor dentro da variavel x, caso tenha, ele vai imprimir o valor com a função VALUE
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é nullo.");
            }

            //Verificando com a função HASVALUE se existe valor dentro da variavel y, caso tenha, ele vai imprimir o valor com a função VALUE
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nullo");
            }

            //Operador de coalescência nula
            //Essa operação em baixo, quer dizer que a variavel A esta recebendo o valor de X, e caso o valor seja nulo (??) ela recebe então o valor de 5.00
            double a = x ?? 5.00;
            //Essa operação em baixo, quer dizer que, a variavel B esta recebendo o valor de Y, e caso o valor seja nulo (??) ela recebe então o valor de 5.00
            double b = y ?? 5.00;


        }
    }
}