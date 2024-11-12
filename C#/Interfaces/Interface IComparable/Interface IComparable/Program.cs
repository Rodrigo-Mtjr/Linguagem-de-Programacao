using Interface_IComparable.Entidades;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando uma variavel string chamada PATH, que está recebendo o caminho onde existe um arquivo para ser aberto e lido.
            string caminho = @"D:\ARQUIVOS PARA GIT\Linguagem-de-Programacao\C#\Interfaces\Interface IComparable\Nome.txt";

            try
            {
                //A declaração do USING faz com que o arquivo seja fechado automaticamente depois de ser usado
                //O STREAMREADER é utilizado para ler o conteudo de um arquivo de texto
                //File.OPENTEXT vai fazer com que o arquivo salvo na variavel PATH seja aberto.
                //Então a variavel SR vai receber a leitura do arquivo que vai ser aberto no caminho que foi colocado na variavel PATH
                using (StreamReader sr = File.OpenText(caminho))
                {
                    //Criando uma lista do tipo funcionarios, que é a classe criada, e ja instanciando.
                    List<Funcionarios> lista = new List<Funcionarios>();
                    
                    //Enquanto não chegar no fim da leitura do arquivo aberto em SR
                    while (!sr.EndOfStream)
                    {
                        //Ele vai adicionando na lista as informações conforme os atributos da classe funcionario e conforme a leitura de cada linha em SR.READLINE()
                        lista.Add(new Funcionarios(sr.ReadLine()));
                    }

                    //Depois de ler e adicionar as informações conforme as linhas, ele vai colocar as linhas em ordem alfabetica.
                    lista.Sort();

                    //Criando um foreach para imprimir as informações na tela
                    //Pra cada Funcionario salvo em lista, imprimi na tela as informações de cada linha.
                    foreach (Funcionarios func in lista)
                    {
                        Console.WriteLine(func);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aconteceu algo de errado!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}