using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
         

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria (int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }


        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }


        public void Sacar(double valor)
        {

            if ((Saldo - 5.00) < valor)
            {
                Console.WriteLine("Valor de saque é maior do que em conta!");
                Console.WriteLine("Verificar extrato? S/N: ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'S' || resp == 's')
                {
                    Console.WriteLine("Saldo disponível: R$" + Saldo);
                    Console.WriteLine("Deseja continuar mesmo assim? S/N: ");
                    char resp2 = char.Parse(Console.ReadLine());
                    if (resp2 == 'S' || resp2 == 's')
                    {
                        Saldo = Saldo - (5.00 + valor);
                        Console.WriteLine("Saque realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Finalizando sessão!");
                        Console.WriteLine("Obrigado!");
                    }
                }
                else
                {
                    Console.WriteLine("Deseja continuar mesmo assim? S/N: ");
                    char resp2 = char.Parse(Console.ReadLine());
                    if (resp2 == 'S' || resp2 == 's')
                    {
                        Saldo = Saldo - (5.00 + valor);
                        Console.WriteLine("Saque realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Finalizando sessão!");
                        Console.WriteLine("Obrigado!");
                    }
                }
            }
            else
            {
                Saldo = Saldo - (5.00 + valor) ;
            }
             
        }


        public override string ToString()
        {
            return "Conta: "
                +Numero
                +", "
                +"Titular: "
                +Titular
                +", "
                +"Saldo: R$"
                +Saldo.ToString("F2")
                ;

        }

    }



}
