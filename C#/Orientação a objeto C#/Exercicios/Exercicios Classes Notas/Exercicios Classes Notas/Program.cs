using Exercicios_Classes_Notas;
using System;
using System.Globalization;
namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("f2"));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM: " + aluno.NotaRestante().ToString("f2") + " PONTOS");
            }
        }
    }
}