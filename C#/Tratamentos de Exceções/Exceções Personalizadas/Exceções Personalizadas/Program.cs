using Exceções_Personalizadas.Entidades;
using System;
using Exceções_Personalizadas.Entidades.Excecoes;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Declaração do programa como um todo dentro da função TRY
                Console.Write("Qual o numero do quarto? :");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Check-in data (dd/mm/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/mm/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reserva reserva = new Reserva(quarto, checkin, checkout);
                Console.WriteLine(reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com a data para atualizar a reserva: ");
                Console.Write("Check-in data (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out data (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reserva.AtualizarDatas(checkin, checkout);
                Console.WriteLine(reserva);
            }
            //Caso tenha um erro, ele cai para a função CATCH
            catch (DominioExececao e)
            {
                //Que vai mostrar para o usuário o tipo de Erro que foi declarado na classe Reserva
                //Usando a ApplicationException, e depois imprimi na tela a variavel e.Message
                Console.WriteLine("Erro na reserva! " + e.Message);
            }
        }
    }
}