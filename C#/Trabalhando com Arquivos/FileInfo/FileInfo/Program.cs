using System;
//Usando a biblioteca para ter acesso a classe FILE
using System.IO;
using System.IO.Pipes;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armazena o caminho do arquivo de origem
            string CaminhoOrigem = @"D:\ARQUIVOS PARA GIT\Linguagem-de-Programacao\C#\Trabalhando com Arquivos\FileInfo\teste1.txt";
            //Armazena o caminho do arquivo de destino, que no caso, onde sera copiado
            string CaminhoDestino = @"D:\ARQUIVOS PARA GIT\Linguagem-de-Programacao\C#\Trabalhando com Arquivos\FileInfo\teste2.txt";

            try
            {
                //Esse comando FILE COPY copia o arquivo do caminho de origem para o destino
                //Copia então o arquivo CaminhoOrigem, para CaminhoDestino.
                File.Copy(CaminhoOrigem, CaminhoDestino);
                //Lendo todas as linhas do arquivo de origem e salvando dentro de uma lista.
                string[] linhas = File.ReadAllLines(CaminhoOrigem);

                //O foreach serve para depois fazer o teste e ver se todas as linhas vão ser impressas na tela
                foreach (string line in linhas)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
