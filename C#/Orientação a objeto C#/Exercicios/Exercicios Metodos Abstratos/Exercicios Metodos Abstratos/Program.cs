using System;
using System.Runtime.Serialization;
using Exercicios_Metodos_Abstratos.Entidades;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contribuinte> lista = new List<Contribuinte>();
            Console.Write("Entre com o numero de contribuientes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i <=n; i++)
            {
                Console.WriteLine($"Contribuinte #{i}: ");
                Console.Write("Pessoa Física ou Jurídica (P/F)?: ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Faturamento Anual R$: ");
                double faturamento = double.Parse(Console.ReadLine());

                if (resp == 'p' || resp == 'P')
                {
                    Console.Write("Gastos totais com saúde R$: ");
                    double valor = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(nome, faturamento, valor));
                }
                else
                {
                    Console.Write("Número total de funcionários: ");
                    int qtde = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, faturamento, qtde));
                }
            }

            double soma = 0;
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");
            foreach (Contribuinte contribuinte in lista)
            {
                double imposto = contribuinte.Imposto();
                Console.WriteLine("Nome: " + contribuinte.Nome + ": R$" + imposto.ToString("f2"));
                soma += imposto;
            }
                Console.WriteLine("IMPOSTO TOTAL: " + soma.ToString("F2"));

        }
    }
}