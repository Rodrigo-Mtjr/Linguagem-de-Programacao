
namespace Exercicios_Herança_2
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            return Nome + ", R$: " + Preco.ToString("f2");
        }
    }
}
