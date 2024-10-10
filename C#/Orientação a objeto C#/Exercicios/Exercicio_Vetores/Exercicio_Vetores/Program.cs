using Exercicio_Vetores;
using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando que a classe Hotel vai receber um vetor com um parametro de entrada de 10 posições na memoria.
            Hotel[] vetor = new Hotel[10];
            Console.Write("Quantos quartos serão alugados?: ");
            int qtde = int.Parse(Console.ReadLine());

            //Criando um for para salvar as informações de cada pessoa que vai fazer a reserva no hotel utilizando a quantidade que foi definida pelo usuario.
            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine();
                //Tratamento de string, para utilizar a posição do i do for para colocar o numero da reserva.
                Console.WriteLine("Reserva #{0}", i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                //Salvando as informações digitadas pelo usuario, dentro do vetor em seu respectivo lugar. 
                int quarto = int.Parse(Console.ReadLine());
                //Utilizando o numero que foi digitado em quarto, para que seja acessado dentro do vetor a mesma posição, indicando que essa posição é um quarto.
                //E depois salvando o nome digitado e o email, conforme feito no construtor.
                //O quarto que o usuario digitar, vai ser a posição do vetor.
                vetor[quarto] = new Hotel(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            //Usando o For para imprimir na tela quais foram os quartos preenchidos e ocupados.
            for (int i = 0; i < 10; i++)
            {
                //Caso o vetor na posição i seja diferente de zero ou nullo, ele vai mostrar a sequencia de NUMERO DO QUARTO, MAIS AS INFORMAÇÕES DELE.
                if (vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }

        }
    }
}