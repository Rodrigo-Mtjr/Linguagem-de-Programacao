using System;
using System.Globalization;

namespace Exercicios_estrutura_condicional_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 5 -  LANCHONETE 

            Console.WriteLine("DIGITE O CODIGO DO ITEM E A QUANTIDADE:");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("TOTAL R$: "+ total.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
