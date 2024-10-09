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
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /*Outro tipo de construtor com sobrecarga apenas em dois atributos da classe*/
        public Produto(string nome, double preco)
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