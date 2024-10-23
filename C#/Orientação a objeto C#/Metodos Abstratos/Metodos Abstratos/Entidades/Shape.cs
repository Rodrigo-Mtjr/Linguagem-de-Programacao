using Metodos_Abstratos.Entidades.Enums;

namespace Metodos_Abstratos.Entidades
{
    abstract class Shape
    {
        public Color Color {  get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
