using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertis__Propriedades_
{
    class Produto
    {
        private string _nome;
        /*definindo direto no atributo os metodos get para mostrar a informação e o set para alterar*/
        public double Preco { get; private set; }
        /*definindo direto no atributo os metodos get para mostrar a informação e o set para alterar*/
        public int Quantidade { get; private set; }

        /*Definição de construtor para parametro de entrada*/
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*Definindo uma propriedade para o atributo nome*/
        /*Que com isso, podemos chamar o metodo get return _nome para retornar o nome do item*/
        /*E o metdo set que seria para alterar o nome pelo qual o usuario quiser*/
        public string Nome
        {
            /*Mostra o que tem dentro do atributo*/
            get { return _nome; }
            /*Altera o atributo caso ele seja diferente de null e maior que 1*/
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        /*Propriedade do metodo Valor em estoque*/
        public double ValorTotalEmEstoque
        {
            /*Retorna a multiplicação do quantidade entre o preço para saber em valor*/
            get { return Quantidade * Preco; }
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AumentarValorPreco(double preco)
        {
            Preco += preco;
        }

        public void BaixarValorPreco(double preco)
        {
            Preco -= preco;
        }

        public override string ToString()
        {
            return _nome
                    + ", $ "
                    + Preco.ToString("F2")
                    + ", "
                    + Quantidade
                    + " unidades, Total: $ "
                    + ValorTotalEmEstoque.ToString("F2");
        }

    }
}
