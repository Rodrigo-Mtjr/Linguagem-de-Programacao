using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicios_List
{
    public class Funcionario
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

        public void aumentoSalario(double percentual) //metodo
        {
            Salario = Salario + (Salario * percentual / 100);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario;
        }
    }
}
