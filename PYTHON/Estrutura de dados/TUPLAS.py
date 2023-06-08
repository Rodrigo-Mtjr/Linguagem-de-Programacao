"""Em Python, as tuplas podem ser construídas de três maneiras:

Usando um par de parênteses para denotar uma tupla vazia: tupla1 = ()
Usando um par de parênteses e elementos separados por vírgulas: tupla2 = ('a', 'b', 'c')
Usando o construtor de tipo: tuple()"""

#EXEMPL0 1
print("\n\nExemplo1")
vogais = ('a,','e','i','o','u') #DECLARANDO UMA TUPLA, SABEMOS QUE É UMA TUPLA PELOS PARENTESES
print(f"o tipo da variavel vogais é = {type(vogais)}") #MOSTRANDO O TIPO DA VARIAVEL, QUE TEM QUE DAR TUPLE

for p, x in enumerate(vogais): #USANDO A FUNÇÃO FOR PARA ENUMERAR A POSIÇÃO E MOSTRAR QUAL VOGAL ESTA NESSA POSIÇÃO, UTILIZANDO VARIAVES DE CONTROLE
    print(f"Posição = {p}, vogais = {x}") #IMPRINDO O RESULTADO


#EXEMPLO 2
print("\n\nExemplo2")
vogais1 = ('a', 'e', 'i', 'o', 'u') #DECLARANDO A TUPLA
for item in enumerate(vogais1): #UTILIZANDO APENAS UMA VARIAVEL DE CONTROLE PARA IMPRIMIR A POSIÇÃO E QUAL O VALOR DA VOGAL QUE ESTA NESSA POSIÇÃO
                                #DENTRO DE UMA TUPLA, NÃO É NECESSARIO PEDIR PARA QUE SE GUARDE O VALOR E A POSIÇÃO EM OUTRA, A PROPRIA TUPLA JA FAZ ISSO
    print(item)                 #BASTA APENAS IMPRIMIR O RESULTADO, QUE ELE MOSTRA A POSIÇÃO E O VALOR DESSA POSIÇÃO

print(tuple(enumerate(vogais1)))
print(list(enumerate(vogais1)))

