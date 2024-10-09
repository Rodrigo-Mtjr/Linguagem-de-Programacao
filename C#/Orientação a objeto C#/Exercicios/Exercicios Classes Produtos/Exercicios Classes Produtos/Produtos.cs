using System;
using System.Xml;



namespace Exercicios_Classes_Produtos
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", R$ " 
                + Preco.ToString("f2")
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
