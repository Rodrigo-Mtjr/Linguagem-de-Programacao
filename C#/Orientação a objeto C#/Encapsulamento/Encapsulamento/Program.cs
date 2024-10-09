using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instanciando um objeto usando os parametros de entrada dos construtores, tem que ter algo para dar entrada*/
            Produto p = new Produto("TV", 500.00, 10);

            /*Como foi criado um metodo SetNome na classe, então para alterar o nome, temos que chamar esse medoto e executar*/
            p.SetNome("TV 4k");

            /*Aqui temos a chamada do metodo GETNOME que foi criado na classe produto, para retornar o nome do salvo no atributo*/
            Console.WriteLine(p.GetNome());







        }
    }
}