
using System.Reflection.Metadata.Ecma335;

namespace Interfaces.Entidades
{
    internal class AluguelCarro
    {
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Fatura Fatura { get; set; }
        public Veiculo Veiculo { get; set; }

        public AluguelCarro (DateTime dataRetirada, DateTime dataDevolucao, Veiculo veiculo)
        {
            
            DataRetirada = dataRetirada;
            DataDevolucao = dataDevolucao;
            Veiculo = veiculo;

        }
    }
}
