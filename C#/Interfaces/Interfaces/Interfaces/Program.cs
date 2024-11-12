using Interfaces.Entidades;
using Interfaces.Serviços;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data do aluguel: ");
            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();

            //Pedindo para o usuário digitar na tela a data de retirada do carro com a hora
            Console.Write("Retirada (dd/mm/yyyy hh:mm): ");

            //Pra usar o PARSEEXACT tem que importar o SYSTEM.GLOBALIZATION
            //Pois com ele, você consegue modificar o tipo de informação salva dentro da variavel, que no caso queremos em dia, mes e ano com 4 digitos
            DateTime retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Devolucao (dd/mm/yyyy hh:mm): ");
            DateTime devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);      
            
            Console.Write("Entre com o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine());

            Console.Write("Entre com o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());

            //Instanciando a variavel aluguelCarro com um objeto AluguelCarro, onde ele recebe como parametros a data de retirada
            //Data de devolução, e dentro da mesma linha de codigo, instanciamos tambem um objeto do tipo veiculo, para que podemos salvar o tipo de modelo do carro.
            //Isso só é possivel porque dentro da classe AluguelCarro, temos um atributo do tipo VEICULO.
            AluguelCarro aluguelCarro = new AluguelCarro(retirada, devolucao, new Veiculo(modelo));

            //Instanciando a variavel serviçoAluguel com um objeto ServicoAluguel, onde ele recebe como paramtro o precohora e preco dia
            ServicoAluguel servicoAluguel = new ServicoAluguel(precoHora, precoDia, new ImpostoBrasil());

            //Depois uso o motedo ProcessarFatura da classe ServiçoAluguel para calcular as informações de da classe AluguelCarro
            servicoAluguel.ProcessarFatura(aluguelCarro);

            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}