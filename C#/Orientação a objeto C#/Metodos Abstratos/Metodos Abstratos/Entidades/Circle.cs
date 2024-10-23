using Metodos_Abstratos.Entidades.Enums;
using System;

namespace Metodos_Abstratos.Entidades
{
    class Circle : Shape
    {
        public double Raio { get; set; }

        public Circle(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
