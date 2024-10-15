using System;

namespace Condicional_Ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto;

            //Expressão condicional padrão
            if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);

            //Expressão condicional ternaria, as duas vão dar o mesmo valor para as variáveis.
            //Primeiro declaramos a variável e ja colocamos que ela vai receber a condição com os valores se verdadeiro ou falso.
            double desconto2 = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto2);
        }
    }
}