using System.Globalization;
namespace Course
{
    class Produto
    {
        
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }


        /*Nesse metodo abaixo, estamos apenas imprimindo o valor do atributo nome no programa principal, então ele apenas vai mostrar o que está salvo dentro do atribuo*/
        /*Get serve para obter a informação*/
        public string GetNome()
        {
            return _nome;
        }


        /*Nesse metodo abaixo, estamos alterando o nome do atribudo nome dentro do programa principal*/
        /*Set serve para alterar as informações dos atributos*/
        public void SetNome(string nome)
        {
            /*Essa condição foi usada para que verifique se o que esta sendo inserindo tem mais 1 caracteres e não esteja em branco, o usuario é obrigado a digitar algo maior que 1*/
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        /*Nesse metodo estamos mostrando o valor que temos dentro do atributo preço*/
        public double GetPreco()
        {
            return (_preco);
        }

        /*Nesse metodo estamos mostrando o valor que temos dentro do atributo quantidade*/
        public int GetQuantidade()
        {
            return _quantidade;
        }

        /*Isso tudo poque queremos que seja alterado os valores e a quantidade dos produtos com os metodos abaixo, adicionar, remover e valor em estoque*/


        public double ValorTotalEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos()
        {
            _quantidade = _quantidade + _quantidade;
        }

        public void RemoverProdutos()
        {
            _quantidade = _quantidade - _quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", R$"
                + _preco
                + ", "
                + _quantidade
                + " unidades, Total: R$"
                + ValorTotalEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }


    }
}
