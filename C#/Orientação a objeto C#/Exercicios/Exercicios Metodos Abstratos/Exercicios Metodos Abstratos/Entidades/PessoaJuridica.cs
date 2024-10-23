
using System.Reflection.Metadata.Ecma335;

namespace Exercicios_Metodos_Abstratos.Entidades
{
    class PessoaJuridica : Contribuinte
    {
        public int QuantidadeFuncionario { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionario) : base(nome, rendaAnual)
        {
            QuantidadeFuncionario = quantidadeFuncionario;
        }

        public override double Imposto()
        {
            if (QuantidadeFuncionario <= 10)
            {
                return RendaAnual * 16 / 100;
            }
            else
            {
                return RendaAnual * 14 / 100;
            }
        }
    }
}
