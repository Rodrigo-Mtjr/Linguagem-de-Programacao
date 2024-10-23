using System;
using System.Dynamic;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abrindo a função try para executar o programa
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            //Criando algo para caso tenha um erro, uma exceção
            //No caso abaixo, como ja tem pré definido uma exceção para divisão por zero, temos apenas que colocar o tipo da exceção 
            catch (DivideByZeroException) 
            {
                //Então se na parte do TRY, o usuário tentar dividir um numero por zero, ele cai nesse CATCH e imprimi na tela a mensagem de erro.
                Console.WriteLine("Não é permitido divisão por zero!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
        }
    }
}
