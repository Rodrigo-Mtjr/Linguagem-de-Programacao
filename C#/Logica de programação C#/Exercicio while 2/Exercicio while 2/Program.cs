using System;

namespace Exercicio_while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O CODIGO DO COMBUSTIVEL QUE VOCE ABASTECEU");    
            Console.WriteLine("1 - ALCOOL | 2 - GASOLINA | 3 - DIESEL | 4 - SAIR");
            int escolha = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
          

            while (escolha  != 4)
            {
                if (escolha == 1)
                {
                    alcool = alcool + 1;
                }
                else if (escolha == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (escolha == 3)
                {
                    diesel = diesel + 1;
                }

                Console.WriteLine("                                                 ");
                Console.WriteLine("DIGITE O CODIGO DO COMBUSTIVEL QUE VOCE ABASTECEU");
                Console.WriteLine("1 - ALCOOL | 2 - GASOLINA | 3 - DIESEL | 4 - SAIR");
                escolha = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("MUITO OBRIGADO!!!");
            Console.WriteLine("                                                     ");
            Console.WriteLine("ALCOOL: " + alcool);
            Console.WriteLine("GASOLINA: " + gasolina);
            Console.WriteLine("DIESEL: " + diesel);
 
        }
    }
}
