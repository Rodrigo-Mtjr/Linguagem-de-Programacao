using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores_Exemplo_2
{
    class Product
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preço = preco;
        }
                       
    }

    
}
