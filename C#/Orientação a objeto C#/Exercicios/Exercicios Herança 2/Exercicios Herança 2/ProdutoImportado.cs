
namespace Exercicios_Herança_2
{
    public class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string name, double preco, double taxaAlfandega) : base(name, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal()
        {
            return TaxaAlfandega + Preco;
        }

        public override string EtiquetaPreco()
        {
            return Nome + ", R$: " + PrecoTotal().ToString("f2") + " (Taxa Alfandega R$: " + TaxaAlfandega.ToString("F2") + ")";
        }
    }
}
