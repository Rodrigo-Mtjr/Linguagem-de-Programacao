using Exercicio_Excecao.Entidades;
using Exercicio_Excecao.Entidades.Excecao;
using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informações da Conta");
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            Console.Write("Saldo Inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            Console.Write("Limite para saque: ");
            double limiteSaque = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numero, titular, saldoInicial, limiteSaque);

            Console.WriteLine();
            Console.Write("Digite o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            try
            {
                conta.Sacar(valorSaque);
                Console.WriteLine("Novo saldo: R$ " + conta.Saldo.ToString("F2"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: O valor digitado não é um número válido.");
            }
            catch (DominioExcecao e)
            {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
            catch (Exception e) // Captura qualquer exceção não tratada
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}