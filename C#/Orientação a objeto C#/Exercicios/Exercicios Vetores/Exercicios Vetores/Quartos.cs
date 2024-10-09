using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_Vetores
{
    class Quartos
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        
        public Quartos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
