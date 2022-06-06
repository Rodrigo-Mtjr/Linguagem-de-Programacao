using System;
using System.Globalization;


namespace Exercicios_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite o codigo da primeira peça: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade dessa peça: ");
            int qntd1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario dessa peça: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo da segunda peça: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade dessa peça: ");
            int qntd2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitario dessa peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (qntd1 * valor1) + (qntd2 * valor2);

            Console.WriteLine("VALOR A PAGAR R$" + (total.ToString("f2", cultureInfo.InvariantCulture)));*/



            Console.WriteLine("Digite o codigo do item 1, quantidade e valor unitario na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int qntd1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo do item 2, quantidade e valor unitario na mesma linha: ");
            string[] vet2 = Console.ReadLine().Split(' ');

            int n2 = int.Parse(vet[0]);
            int qntd2 = int.Parse(vet[1]);
            double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double total = (qntd1 * valor1) + (qntd2 * valor2);

            Console.WriteLine("VALOR A PAGAR R$" + (total.ToString("f2", CultureInfo.InvariantCulture)));




        }
    }
}
