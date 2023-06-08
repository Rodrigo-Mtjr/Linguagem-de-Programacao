using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Membros_Estaticos
{
    class ConversorDeMoeda
    {

        public static double iof = 6.0;


        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * iof / 100;
        }
    }
}
