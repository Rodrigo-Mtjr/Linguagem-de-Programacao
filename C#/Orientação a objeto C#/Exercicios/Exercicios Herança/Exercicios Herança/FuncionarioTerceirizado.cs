using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Herança
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional {  get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHoras, double despesaAdicional) : base(nome, horas, valorPorHoras)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }

    }
}
