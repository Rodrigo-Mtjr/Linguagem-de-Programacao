using System;
using Upcasting_e_Downcasting;
using Upcasting_e_Downcasting;


namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1001, "Alex", 0.0);
            ContaEmpresarial ContaE = new ContaEmpresarial(1002, "Maria", 0.0, 500.00);


            //UPPCASTING

            //Nesse exemplo estamos dizendo que a conta1 do tipo Conta (superclasse) está recebendo tudo o que está dentro da variavel ContaEmpresa
            //Como o sistema de Herança é É-UM, isso significa que ContaEmpresa é uma Conta1, então podemos fazer isso.
            Conta conta1 = ContaE;
            
            //No próximo exemplo estamos criando uma nova variável do tipo Conta, onde esta sendo instanciado com a classe ContaEmpresarial, que segue a mesma logica da de cima.
            Conta conta2 = new ContaEmpresarial(1003, "Bob", 0.0, 200.0);

            //Mesma coisa pra esse proximo exemplo, usamos a ContaPoupança para falar que ela vai instanciar uma variavel conta3.
            Conta conta3 = new ContaPoupanca(1004, "Ana", 0.0, 0.01);

            //LEMBRANDO QUE OS TESTE ACIMA FORAM FEITOS DE SUBCLASSE PARA SUPERCLASSE. Uma subclasse pode ser uma superclasse porque ela herda os atributos e metódos das superclasse.


            //DOWNCASTING
            //só vai ser usado se REALMENTE for necessário, pois é inseguro o uso de downcasting.

            //No exemplo abaixo, estamos dizendo que a variável conta4 do tipo ContaEmpresarial(subclasse),
            //vai receber a variável conta2 do tipo Conta (Superclasse). Mas pra isso continuar, temos que fazer um casting (ContaEmpresarial)
            //Senão da um erro na hora de executar.
            ContaEmpresarial conta4 = (ContaEmpresarial)conta2;

        }
    }
}