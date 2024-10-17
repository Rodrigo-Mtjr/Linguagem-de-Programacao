using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Herança
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorPorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHoras;
        }

    }
}
