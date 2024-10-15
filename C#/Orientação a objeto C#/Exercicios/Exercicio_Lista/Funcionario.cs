using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio_Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return "ID: " 
                + Id
                + ", Nome: "
                + Name
                + ", Salario: R$"
                + Salario.ToString("F2");
        }
    }
}
