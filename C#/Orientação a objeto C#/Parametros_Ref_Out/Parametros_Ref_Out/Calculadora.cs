using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_Ref_Out
{
    class Calculadora
    {
        public static void Triplo(int original, out int result)
        {
            result = original * 3;
        }
    }
}
