using Exericio_Lista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionarios> lista = new List<Funcionarios>();

            Console.Write("Quantos funcionários vão ser cadastrados?: ");
            int qtdeFuncionario = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeFuncionario; i++)
            {
                Console.WriteLine("Funcionário #{0}: ", i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: R$ ");
                double salario = double.Parse(Console.ReadLine());
                lista.Add(new Funcionarios(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Entre com o Id do funcionário que vai receber o aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            while (true)
            {
                Funcionarios pesquisa = lista.Find(x => x.Id == idFuncionario);
                if (pesquisa == null)
                {
                    Console.WriteLine("Código de funcionário não existe!");
                    Console.WriteLine("Deseja continuar? S/N: ");
                    char resp = char.Parse(Console.ReadLine());

                    if (resp == 'S' || resp == 's')
                    {
                        Console.Write("Digite o id correto: ");
                        idFuncionario = int.Parse(Console.ReadLine());
                        pesquisa = lista.Find(x => x.Id == idFuncionario);

                        if (pesquisa != null)
                        {
                            Console.WriteLine("Funcionário escolhido: " + pesquisa.Nome);
                            Console.Write("Digite qual a porcentagem de aumento: ");
                            double porcentagem = double.Parse(Console.ReadLine());
                            pesquisa.AumentarSalario(porcentagem);
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Funcionário escolhido: " + pesquisa.Nome);
                    Console.Write("Digite qual a porcentagem de aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    pesquisa.AumentarSalario(porcentagem);
                    break;
                }

            }
            Console.WriteLine("Finalizando a sessão!");
            Console.WriteLine("Obrigado!");
            Console.WriteLine("Dados da lista de funcionários: ");
            foreach (Funcionarios obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}