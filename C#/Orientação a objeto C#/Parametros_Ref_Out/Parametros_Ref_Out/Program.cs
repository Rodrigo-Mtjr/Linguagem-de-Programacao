using Parametros_Ref_Out;
using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int triplo;

            //Vai executar a função e salvar o resultdo na variavel triplo.
            Calculadora.Triplo(a, out triplo);
            Console.WriteLine(triplo);

        }
    }
}
