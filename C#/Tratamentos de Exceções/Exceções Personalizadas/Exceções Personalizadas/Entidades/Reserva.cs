using System;
using System.Numerics;
using Exceções_Personalizadas.Entidades.Excecoes;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Exceções_Personalizadas.Entidades
{
    public class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            //Dentro do construtor conseguimos colocar uma condição para verificar as datas de entrada e saida.
            if (checkOut < checkIn)
            {
                throw new DominioExececao("A data de check-out deve ser posterior a data de check -in");
            }

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        //Criando um método para calcular a duração da diára da reserva
        public int Duracao()
        {
            //Declarando uma variavel do tipo TimeSpan chamada duracao que vai receber a subtração entre a data de Checkout e Checkin
            //Que no caso queremos saber o calculo de tempo
            //Mas como queremos em dias, temos que retorna para o usuário formatando em INT, porque o calculo da variavel duração vai ser em double
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            //Então temos que fazer um casting (int) para transformar a duracao em int e depois imprimir na tela os dias sobre o calculo.
            return (int)duracao.TotalDays;
        }

        public void AtualizarDatas(DateTime checkIn, DateTime checkOut)
        {
            //Criando uma variável do tipo DateTime onde ela vai receber o dia atual.
            DateTime hoje = DateTime.Now;

            //Nesse if abaixo, estamos fazendo uma condição caso a data de checkin seja inferior que a data atual
            //Ele vai retornar um erro da Classe Dominino de Execeção, que foi o construtor que foi criado
            if (checkIn < hoje || checkOut < hoje)
            {
                //Caso for verdadeiro a condição acima, ele lança uma nova Exceção para o usuário.
                throw new DominioExececao("As datas das reservas devem estar em datas futuras comparadas a data atual!");
            }
            //Como a função THROW termina o código caso seja verdadeiro, para declarar outra condição, temos que escrever outro IF em vez de ELSE
            
            if (checkOut <= checkIn)
            {
                //Caso a condição acima seja verdadeiro, ele lança outra exceção para o usuário
                throw new DominioExececao("A data de check-out deve ser posterior a data de check-in");
            }

            //Caso não seja verdadeira nenhum dos dois IF's, ele faz a atribuição abaixo
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Quarto: "
                + NumeroQuarto
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", totalizando "
                + Duracao()
                + " noites.";
        }
    }
}
