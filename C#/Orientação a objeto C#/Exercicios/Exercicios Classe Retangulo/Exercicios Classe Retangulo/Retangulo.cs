using System;

namespace Exercicios_Classe_Retangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura*Largura + Altura*Altura);
        }
    }
}
