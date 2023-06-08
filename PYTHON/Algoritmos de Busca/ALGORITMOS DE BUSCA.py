#ALGORITMO DE BUSCA

#EXEMPLO1
print("EXEMPLO 1")
def executar_busca_linear(lista, valor): #CRIANDO A FUNÇÃO EXECUTAR BUSCA LINEAR, COM DOIS PARAMETROS DE ENTRADA, LISTA E VALOR
    for elemento in lista: #AQUI ESTAMOS CRIANDO UMA FUNÇÃO FOR, QUE DIZ, PARA CADA ELEMENTOD DENTRO DA LISTA, SALVE ELES DENTRO DA VARIAVEL ELEMENTO
        if valor == elemento: #CONDIÇÃO SE, SE O VALOR FOR IGUAL AO ELEMENTO SALVO DE LISTA, DENTRO DA VARIAVEL ELEMENTRO, FAÇA
            return True       #RETORNE VERDADEIRO
    return False    #SENAO RETURN FALSO


import random

lista = random.sample(range(1000), 50) #CRIAMOS UMA LISTA RANDOM, COM 50 NUMEROS DIFERENTES, DE 0 A 100
print(sorted(lista))  #AQUI, COM A FUNÇÃO SORTED, PEDIMOS PARA ELE IMPRIMIR EM ORDEM, OS NUMEROS GERADOS ALEATORIAMENTE
executar_busca_linear(lista, 100) #DEPOIS EXECUTAMOS A FUNÇÃO CRIADA COM A LISTA E O VALOR A SER BUSCADO
print("")



#ALGORITMO DE BUSCA COM INDEX, POSIÇÃO DO CARACTER
#EXEMPLO2
print("EXEMPLO 2")

vogais = 'aeiou'
resultado = vogais.index('e')
print(resultado)
print("")



#EXEMPLO 3
print("EXEMPLO 3")
def procurar_valor(lista, valor): #DEFININDO UMA FUNÇÃO, COM DOIS PARAMETROS DE ENTRADA
    tamanho_lista = len(lista) #DEFININDO UMA VARIAVEL, AONDE ELA VAI RECEBER O TAMANHO DO PARAMETRO DE ENTRADA DA FUNÇÃO, LISTA
    print(f"Tamanho da lista criada = {tamanho_lista}")
    for i in range(tamanho_lista): #DIZENDO PARA O SISTEMA SALVAR, CADA POSIÇÃO RETIRADA NA FUNÇÃO LEN, NA VARIAVEL DE CONTROLE I
        if valor == lista[i]: #CONDIÇÃO SE, PARA DIZER QUE, SE O VALOR COMO PARAMETRO DE ENTRADA, FOR IGUAL A ALGUMA POSIÇÃO DENTRO DA LISTA, QUE ESTÁ COMO VARIAVEL DA LETRA I,
            return i          #ELE RETORNA A MESMA POSIÇÃO
    return None               #SENAO ELE RETORNA NONE

vogais = 'aeiou'

resultado = procurar_valor(lista = vogais, valor = 'a')

if resultado != None:
    print(f"Valor encontrado na posição {resultado}")
else:
    print("Valor não encontrado")
print("")



#EXEMPLO 4
print("EXEMPLO 4")
def procurar_valor(lista, valor):
	tamanho_lista = len(lista)
	for i in range(tamanho_lista):
	 if valor == lista[i]:
	    return i
	return None

def testar_resultado(resultado):
	if resultado:
	    print(f"Valor encontrado na posição {resultado}")
	else:
	    print("Valor não encontrado")


vogais = ['a', 'e', 'i', 'o', 'u']

	# Usando nossa função
resultado = procurar_valor(lista=vogais, valor='o')
testar_resultado(resultado)