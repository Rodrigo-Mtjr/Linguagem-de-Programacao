#Listas - elas podem ser criadas de varias formas:

'''
lista1 = []
lista2 = ['a','b','c']
list()
'''
#------------------------------------------------------------------------------------------------------------------------------------------------------

#EXEMPLO 1
'''
vogais = ['a','e','i','o','u']

for vogal in vogais: #estamos pedindo para que salve na variavel de controle VOGAL as letras definidas em VOGAIS
    print (f"Posição = {vogais.index(vogal)}, valor = {vogal}") #para enumerarmos e imprimir na tela, precisamos usar a função index dentro da lista
    
for i, c in enumerate(vogais):
    print(f"Posição = {i}, Valor {c}")
'''
#------------------------------------------------------------------------------------------------------------------------------------------------------

#EXEMPLO 2
'''
vogais = [] #declarando uma lista

vogais.append('a') #acrescentando um valor dentro da posição 0 dessa lista
vogais.append('e') #acrescentando um valor dentro da posição 1 dessa lista
vogais.append('i') #acrescentando um valor dentro da posição 2 dessa lista
vogais.append('o') #acrescentando um valor dentro da posição 3 dessa lista
vogais.append('u') #acrescentando um valor dentro da posição 4 dessa lista

for i, c in enumerate(vogais): #usando a função enumerate() para salvar dentro de duas variaveis de controle a posição e a vogal
    print (f"Posição = {i}, valor {c}") #imprimindo essas inforações salvas

print(f"O tipo da variavel é = {type(vogais)}") #imprimindo o tipo da variavel
'''
#----------------------------------------------------------------------------------------------------------------------------------------------------

#EXEMPLO 3
'''
frutas = ["maça", "banana", "uva", "mamão", "maça"] #DECLANDO A LISTA JÁ COM OS CONTEUDOS INSERIDOS
notas = [8.7, 5.2, 10, 3.5] #DECLRANDO UMA LISTA COM OS CONTEUDOS INSERIDOS

print("maça" in frutas) #PERGUNTANDO SE A PALAVRA MAÇA ESTA DENTRO DA LISTA FRUTAS
print("abacate" in frutas) #PERGUNTANDO SE A PALAVRA ABACATE ESTA DENTRO DA LISTA FRUTAS
print("abacate" not in frutas) #PERGUNTANDO SE A PALAVRA ABACATE NAO ESTA DENTRO DA LISTA FRUTAS
print(min(frutas)) #MOSTRANDO A MENOR PALAVRA DE FRUTA, NAO PELO TAMANHO, MAS PELA QUESTAO DE ORDEM ALFABETICA
print(max(notas))  #MOSTRANDO O MAIOR DENTRO DA LISTA NOTAS
print(frutas.count("maça")) #CONTANDO QUANTAS PALAVRAS MAÇA EXISTE DENTRO DE FRUTAS
print(frutas + notas) #CONCATENANDO AS DUAS LISTAS
print(2 * frutas) #MULTIPLICANDO A LISTA FRUTAS, IMPRIMINDO ELA DUAS VEZES
'''
#----------------------------------------------------------------------------------------------------------------------------------------------------

#EXEMPLO 3

lista = ['Python', 30.61, "Java", 51 , ['a', 'b', 20], "maça"] #definindo a lista com o seu conteudo

print (f"Tamanho da lista = {len(lista)}") #mostrando o tamanho da lista

for i, c in enumerate(lista): #enumerando e salvando a posição dentro de duas variaveis de controle
    print(f"Posição = {i},\t valor = {c} ------------------> tipo individual = {type(lista)}") #imprimindo a posição, valor e o tipo de cada conteudo dentro da lista

print("\nEXEMPLOS DE SLICES: \n")

print("lista[1] = ", lista[1]) #mostrando o que tem na posição 1 da lista
print("lista[0:2] = ", lista[0:2]) #mostrando o que tem entre as posições 0 e 2 da lista, a posição SUPERIOR não entra, entao vai de 0 a 1
print("lista[:2] = ", lista[:2]) #mostrando o que tem entre as posições 0 e 2 da lista, a posição SUPERIOR não entra, entao vai de 0 a 1
print("lista[3:5] = ", lista[3:5]) #mostrando o que tem entre as posições 3 e 5 da lista, a posição SUPERIOR não entra
print("lista[3:6] = ", lista[3:6]) #mostrando o que tem entre as posições 3 e 6 da lista, a posição SUPERIOR não entra
print("lista[3:] = ", lista[3:]) #mostrando tudo o que tem dentro da lista da posição 3 até a ultima
print("lista[-2] = ", lista[-2]) #mostrando a posição de tras pra frente da lista, entao seria a penultima posição
print("lista[-1] = ", lista[-1]) #mostrando a posição de tras pra frente da lista, entao seria a ultima posição
print("lista[4][1] = ", lista[4][1]) #como a quarta posição é outra lista dentro da lista principal, com esse comando estamos acessando ela e mostrando a posição 1 da mesma.