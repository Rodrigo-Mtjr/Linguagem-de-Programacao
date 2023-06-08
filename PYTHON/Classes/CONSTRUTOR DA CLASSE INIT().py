'''a função init ,também chamada de "método construtor", possui a responsabilidade de criar o objeto daquela classe.
Nem sempre você precisará cria-lá, porém, se o seu projeto exige que você utilize essa função, nela será contida todas as informações principais do objeto.
Um exemplo disso pode ser o objeto "Pessoa":'''

'''
class Pessoa: #CRIANDO UMA CALSSE CHAMADA PESSOA
    def _init_(self, nome, idade): #COLOCANDO COMO INIT, TODOS OS ATRIBUTOS QUE VAMOS CONTRUIR AO LONGO DA CLASSE, PARA QUE POSSAMOS UTILIZAR EM OUTRAS SUBCLASSES
        self.nome = nome #DECLANDO UMA ATRIBUTO NOME
        self.idade = idade #DECLRANDO UM ATRIBUTO IDADE
'''


#EXEMPLO 1
class Televisao: #DECLARANDO UMA CLASSE CHAMADA TELEVISAO
    def __init__(self): #DEFININDO OS ATRIBUTOS E METODOS DE FORMA INIT
        self.volume = 10 #DIZENDO QUE A CLASSE TELEVISAO, QUANDO FOR INSTANCIADA, VAI INICIAR COM O VALOR DE 10

    def aumentar_volume(self): #DEFININDO UM METODO
        self.volume += 1 #DIZENDO QUE ASSIM QUE ESSE METODO FOR INVOCADO, O MESMO VAI ALTERAR O VALOR PADRAO DA CLASSE TELEVISAO

    def diminuir_volume(self): #DEFININDO UM METODO
        self.volume -= 1 #DIZENDO QUE ASSIM QUE ESSE METODO FOR INVOCADO, O MESMO VAI ALTERAR O VALOR PADRAO DA CLASSE TELEVISAO


tv = Televisao() #CRIANDO UM OBJETO DO TIPO TELEVISAO, SEM PARAMETRO DE ENTRADA, POIS NAO FOI DEFINIDO NA CRIAÇÃO DA CLASSE
print("Volume ao ligar a tv = ", tv.volume) #PEDINDO PARA PRINTAR O VOLUME PADRAO DA CLASSE

tv.aumentar_volume() #EXECUTANDO O METODO PARA ALTERAR O VALOR PADRAO
print("Volume atual = ", tv.volume) #PRINTANDO PARA VER O RESULTADO

tv.diminuir_volume() #EXECUTANDO O METODO PARA ALTERAR O VALOR PADRAO
print("Volume atual = ", tv.volume) #PRINTANDO PARA VER O RESULTADO
