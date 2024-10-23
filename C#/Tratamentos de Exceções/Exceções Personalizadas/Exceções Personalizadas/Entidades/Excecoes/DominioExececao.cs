namespace Exceções_Personalizadas.Entidades.Excecoes
{
    //Criando uma subclasse de ApplicationException que é um tratamento de exceção onde o usuário pode criar os tipos
    public class DominioExececao : ApplicationException
    {
        //Criando um construtor recebendo uma string mensagem
        public DominioExececao(string mensagem) : base(mensagem)
        {
        }
    }
}
