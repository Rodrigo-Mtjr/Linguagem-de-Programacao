using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertis__Propriedades_
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        /*Definição de construtor para parametro de entrada*/
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        /*Definindo uma propriedade para o atributo nome*/
        /*Que com isso, podemos chamar o metodo get return _nome para retornar o nome do item*/
        /*E o metdo set que seria para alterar o nome pelo qual o usuario quiser*/
        public string Nome
        {
            /*Mostra o que tem dentro do atributo*/
            get { return _nome; }
            /*Altera o atributo caso ele seja diferente de null e maior que 1*/
            set { if (value != null && value.Length > 1) 
                {
                    _nome = value;
                } 
            }

        }

        /*Propriedade do atributo preço*/
        public double Preco
        {
            /*Retorna na tela o valor do produto instanciado*/
            get { return _preco; }
        }

        /*Propriedade do atributo Quantidade*/
        public int Quantidade
        {
            /*Retorna na tela a quantidade do produto*/
            get { return _quantidade; }
        }

        /*Propriedade do metodo Valor em estoque*/
        public double ValorTotalEmEstoque
        {
            /*Retorna a multiplicação do quantidade entre o preço para saber em valor*/
            get { return _quantidade * _preco; }
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade = _quantidade + quantidade; 
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public void AumentarValorPreco(double preco)
        {
            _preco += preco;
        }

        public void BaixarValorPreco(double preco)
        {
            _preco -= preco;
        }

        public override string ToString()
        {
            return _nome
                + ", R$"
                + ValorTotalEmEstoque
                + ", "
                + _quantidade
                + " unidades.";
        }

    }
}
