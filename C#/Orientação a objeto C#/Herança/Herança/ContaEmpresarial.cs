using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    //Criando uma classe do tipo ContaEmpresarial, que será a SUBCLASSE e que vai herdar alguns metodos e atributos da classe Conta.
    class ContaEmpresarial : Conta
    {
        //Acrescentando apenas mais um atributo que se refere a uma conta empresarial
        public double LimiteSaque { get; set; }

        //Criando um construtor genérico
        public ContaEmpresarial()
        { 
        }

        //Criando outro construtor onde esse vai receber como parâmetro o numero, titular e saldo que são atributos da outra classe.
        //Em seguida, junto aos atributos, colocamos o atributo que foi atribuído a essa classe de Conta Empresarial
        //E depois, dizemos ao sistema que, utilizando os dois pontos e a palavra BASE(numero, titular, saldo), que ele vai herdar esses atributos junto com os valores da classe conta.
        public ContaEmpresarial (int numero, string titular, double saldo, double limitesaque) : base(numero, titular, saldo)
        {
            //Criando mais um atributo para a classe conta empresarial
            LimiteSaque = limitesaque;
            
        }

        //Metodo para emprestimo na classe conta empresarial
        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteSaque)
            {
                Saldo += quantia;
            }
            
        }
    }
}
