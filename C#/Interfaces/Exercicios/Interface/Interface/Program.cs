using Interface.Entidades;
using Interface.Servicos;
using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as informações do contrato");
            Console.Write("Número do contrato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data Inicial (dd/mm/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: R$");
            double valorContrato = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            //Instanciando um objeto do tipo contrato chamado contrato.
            //Que vai receber os valores digitados pelo usuário em seus respectivos atributos dentro da classe contrato.
            Contrato contrato = new Contrato (numero, dataContrato, valorContrato);
          
            //Instanciando tambem, um objeto do tipo ServicoContrato, que com ele, estou chamando os métodos de saber a quantidade de parcelas e o valor das parcelas.
            //Só que, instanciando um parametro de entrada do tipo ServicoPaypal, dizendo para o sistema que quero utilizar no programa, as taxas que estão la.
            //Caso tenha outro sistema de pagamento online, eu posso colocar aqui na hora de chamar as taxas, por isso a utilização de interface. 
            //Com a interface colocamos os metodos padroes de um sistema de pagamento online
            //Dentro desse serviço de pagamento online (paypal) utilizamos os metodos criados na interface e acrescentamos os valores da taxa referente ao serviço de pagamento online paypal.
            
            ServicoParcelamento servicoContrato = new ServicoParcelamento(new ServicoPaypal());

            //Depois temos que chamar o metodo ProcessoContrato para executar o processo para saber os valores de cada parcela passada pelo usuario.
            //O serviçoContrato vai estar atrelado ao contrato, pois dentro do metodo ProcessoContrato, criado dentro da classe ServicoContrato, utilizamos as informações do contrato,
            //passada aqui pelo usuario, para calcular os valores de parcelamento e saber o valor de cada uma delas.
            servicoContrato.ProcessoContrato(contrato, parcelas);

            Console.WriteLine("Parcelamentos: ");
            foreach (Parcelamento parcelamento in contrato.Parcelamentos)
            {
                Console.WriteLine(parcelamento);
            }
        }
    }
}
