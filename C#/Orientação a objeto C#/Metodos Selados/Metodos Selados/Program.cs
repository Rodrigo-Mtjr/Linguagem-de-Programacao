using System;
using Sobreposicao;
using static System.Net.Mime.MediaTypeNames;


namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1001, "Alex", 500.00);

            Conta conta2 = new ContaPoupança(1002, "Anna", 500.00, 0.0);

            conta1.Sacar(10.00);
            conta2.Sacar(10.00);

            Console.WriteLine("Saldo da conta 1: " + conta1.Saldo);
            Console.WriteLine("Saldo da conta 2: " + conta2.Saldo);


        }
    }
}
