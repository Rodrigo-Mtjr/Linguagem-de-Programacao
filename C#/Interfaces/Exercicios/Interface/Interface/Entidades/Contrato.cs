using System;
using System.Collections.Generic;

namespace Interface.Entidades 
{
     public class Contrato
    {
        public int Numero { get; set; }
        public DateTime DataInicio { get; set; }
        public double ValorContrato { get; set; }
        public List<Parcelamento> Parcelamentos { get; set; }

        public Contrato(int numero, DateTime dataContrato, double valorContrato)
        {
            Numero = numero;
            DataInicio = dataContrato;
            ValorContrato = valorContrato;
            Parcelamentos = new List<Parcelamento>();
        }

        public void AddParcelamento(Parcelamento parcelamento)
        {
           Parcelamentos.Add(parcelamento);
        }
    }
}
