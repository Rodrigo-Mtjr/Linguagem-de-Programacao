namespace Exercicios_Herança_2
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " (usado) - R$: " + Preco.ToString("f2") + " (Data de fabricação: " + DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
