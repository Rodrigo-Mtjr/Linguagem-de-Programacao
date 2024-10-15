using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando e instanciando uma nova lista do tipo string.
            List<string> list = new List<string>();

            //Adicionando as informações dentro da lista, que no caso são nomes.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            //Jeito diferente de inserir informações dentro da lista, mostrando em qual posição da lista quer salvar ela.
            list.Insert(2, "Marco");

            //Exemplo de impressão da lista, mas esse tipo teria que escrever todas as posições para conseguir visualizar as informações.
            Console.WriteLine("----------------------");
            Console.WriteLine(list[1]);
            Console.WriteLine("----------------------");

            //Outro exemplo para imprimir os resultados da lista, fazer um FOREACH para acessar cada posição dela e ir imprimindo.
            Console.WriteLine("Primeira lista:");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Nesse exemplo, a função COUNT faz uma contagem de quantas informações tem dentro da lista gerada.
            Console.WriteLine("Quantidade de informações: " + list.Count);
            Console.WriteLine("----------------------");

            //A função FIND sempre vai receber um predicado, que seria uma condição como parâmetro de entrada para realizar a função.
            //No exemplo abaixo, a função FIND vai percorrer todos os elementos que existem dentro da lista criado.
            //Em seguida para cada string salva, ele vai verificar essa string, no primeiro elemento dela "x[0]" que no caso seria a primeira letra da palavra e verificar se ela começa com "A"
            //Então resumidamente esse método verifica na lista criada, em todas as palavras a palavra cujo a inicial dela é a letra A. A primeira que ele achar ele salva na variável S1.
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro que começa com a letra A: " + s1);

            //Mesma função que a Find de cima, mas essa mostra a ultima palavra que começa com a letra A e salva na variavel s2.
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima que começa com a letra A: " + s2);
            Console.WriteLine("----------------------");

            //Esse metodo vai retornar um valor inteiro, que seria a posição onde a primeira palavra com a letra A se encontra.
            //O primeiro X é pra verificar todos os elementos, o segundo x[0] verifica nesse elemento a primeira letra para ver se ela começa com a letra 'A' (== A).
            //Se a palavra que ele verificou começar com a letra A, ele salva a posição que está essa palavra na variavel posi.
            int posi = list.FindIndex(x => x[0] == 'A');
            //Usei no final a concatenação mostrando o nome salvo na lista usando a posição achanda na variavel posi list[posi], para ficar mais facil o entendimento.
            Console.WriteLine("Posição da primeira palavra que começa com A: " + posi + ". Nome: " + list[posi]);
            
            //Mesma função que o metodo de cima, só que esse mostra a ultima posição onde tem a palavra que começa com a letra A.
            int posi2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição da ultima palavra que começa com A: " + posi2 + ". Nome: " + list[posi2]);
            Console.WriteLine("----------------------");

            //Declarando uma nova lista e instanciando ela.
            List<string> lista2 = new List<string>();
            //Nesse proximo metodo, estamos salvando as informações da lista 1 na lista 2 com o metodo FINDALL, onde ele vai salvar apenas as palavras que começam com a letra A
            lista2 = list.FindAll(x => x[0] == 'A');
            Console.WriteLine("Nova lista:");
            //Em seguinda usei o FOREACH novamente para imprimir cada palavra na tela para verificação.
            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------");


            //Esse metodo abaixo vai remover uma palavra que for passada como parametro de entrada, que no caso foi Alex.
            list.Remove("Alex");
            Console.WriteLine("Lista sem o nome Alex: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------");

            //Esse metodo usa predicado como condição para executar, nesse exemplo ele vai tirar todas as palavras que restaram na lista 1 que começam com a letra M
            list.RemoveAll(x => x[0]=='M');
            Console.WriteLine("Lista sem nomes que começam com a letra M: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
