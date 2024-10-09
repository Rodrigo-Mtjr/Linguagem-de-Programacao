using System;
using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /*Construtor padrão*/
        public Produto()
        {

        }

        /*Construtor para iniciar a instancia*/
        /*Usando também a palavra THIS para ele considerar o construtor padrão na hora de instanciar*/
        public Produto(string nome, double preco, int quantidade) : this()
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*Outro tipo de construtor com sobrecarga apenas em dois atributos da classe*/
        /*Nesse caso, como ja tinha um construtor com todos os parametros, foi utilizado apenas o this com quantidade, para ele utilizar a quantidade do construtor de cima*/
        public Produto(string nome, double preco) : this (quantidade)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}