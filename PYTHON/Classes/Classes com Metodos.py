'''class PrimeiraClasse: #CRIANDO UMA CLASSE CHAMADA PRIMEIRA CLASSE
    def imprimir_mensagem(self, nome): #DEFININDO OS METODOS DESSSE VARIAVEL, QUE VAI TER QUE SER INICIADA COM UM NOME
        print(f"olá {nome}, seja bem vindo!!") #ESSE É O RESULTADO QUE A CLASSE VAI TER QUE MOSTRAR ASSIM QUE FOR INSTANCIADA

objeto1 = PrimeiraClasse() #CRIANDO UM OBJETO E DIZENDO QUE ELE VAI SER DO TIPO PRIMEIRA CLASSE
objeto1.imprimir_mensagem('João') #USANDO O METODO DEFINIDO DENTRO DA CLASSE E USANDO O PARAMETRO DE ENTRADA OBRIGATORIO, QUE SERIA UM NOME'''
#-----------------------------------------------------------------------------------------------------------------------------------------------

class Calculadora:  #DEFININDO UMA CLASSE CHAMADA CALCULADORA
    def somar(self, n1, n2): #DECLARANDO UM METODO PARA ESSA CLASSE, CHAMADA SOMAR, COM DOIS PARAMETROS DE ENTRADA OBRIGATORIOS, N1 E N2
        return n1 + n2 #PEDINDO PARA RETURNAR A SOMA DOS DOIS PARAMETROS DIGITADOS PELO USUARIO

    def subtrair(self, n1, n2): #DECLARANDO OUTRO METODO, COM A MESMA OBRIGATORIEDADE, COM DOIS PARAMETROS DE ENTRADA PARA SER INSTANCIADA
        return n1 - n2 #RETORNANDO A SUBTRAÇÃO ENTRE ELES

    def multiplicar(self, n1, n2):
        return n1 * n2

    def dividir(self, n1, n2):
        return n1 / n2

    def dividir_resto(self, n1, n2):
        return n1 % n2


calc = Calculadora() #CRIANDO UM OBJETO E DIZENDO QUE ELE VAI SER DO TIPO CALCULADORA

#PARA CHAMAR ALGUM DOS METODOS DENTRO DE UMA CLASSE, BASTA CALOCAR O NOME DA VARIAVEL CRIADA PARA SER DO TIPO DA CLASSE, E DEPOIS PONTO E O NOME DO METODO
#COMO MOSTRA A PARTE DE BAIXO DESSSE CODIGO:

print('Soma: ', calc.somar(4, 3)) #PRINTANDO O METODO SOMA, COM DOIS PARAMETROS DE ENTRADA, COMO É SOLICITADO NA CRIAÇÃO DO MESMO
print('Subtração:', calc.subtrair(13, 8)) #PRINTANDO O METODO SUBTRAIR, COM DOIS PARAMETROS DE ENTRADA, COMO É SOLICITADO NA CRIAÇÃO DO MESMO
print('Multiplicação:', calc.multiplicar(10, 10))
print('Divisão:', calc.dividir(5, 5))
print('Resto da divisão:', calc.dividir_resto(7, 3))
