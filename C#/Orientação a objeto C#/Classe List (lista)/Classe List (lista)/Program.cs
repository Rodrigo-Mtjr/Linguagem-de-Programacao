using System;
using System.Collections.Generic;

namespace Classe_List__lista_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); //CRIANDO LISTA VAZIA

            //UTILIZANDO O MODO ADD PARA ADICIONAR INFORMAÇÕES NA LISTA
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(2, "Rodrigo");
            list.Insert(3, "Pedro");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Quantidade de nomes: " + list.Count);


            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Começa com a letra A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo com a letra A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(3, 2);
            Console.WriteLine("------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }

        
    }
}
