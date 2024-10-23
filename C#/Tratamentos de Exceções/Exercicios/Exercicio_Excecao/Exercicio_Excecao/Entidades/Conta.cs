using Exercicio_Excecao.Entidades.Excecao;
using Exercicio_Excecao.Entidades;

namespace Exercicio_Excecao.Entidades
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta ()
        {
      
        }

        public Conta (int numeroConta, string titular, double saldo, double limiteSaque)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > LimiteSaque)
            {
                throw new DominioExcecao("O valor excedeu o limite de saque");
            }
            if (valor > Saldo)
            {
                throw new DominioExcecao("Saldo insuficiente");
            }

            Saldo -= valor;
        }


    }
}
