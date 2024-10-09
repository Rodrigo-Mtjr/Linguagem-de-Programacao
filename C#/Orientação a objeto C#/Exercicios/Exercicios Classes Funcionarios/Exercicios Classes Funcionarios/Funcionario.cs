using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Classes_Funcionarios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * (Imposto/100));
        }

        public void AumentarSalario(double porcentagem)
        {
            
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }


        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2");
        }
    }
}
