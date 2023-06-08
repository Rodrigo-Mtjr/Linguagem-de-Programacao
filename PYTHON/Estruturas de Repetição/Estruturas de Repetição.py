#ESTRUTURA SIMPLES DE REPETIÇÃO-WHILE

#numero = 1

#while numero != 0:
    #numero  = int(input("Digite um numero: "))

    #if numero % 2 == 0:
        #print(f"O numero {numero} é Par!")
    #else:
        #print(f"O numero {numero} é Impar")
#enquanto o numero for diferente de zero, ele continua



#ESTRUTURA SIMPLES DE REPETIÇÃO - FOR

#nome = "Rodrigo"
#for c in nome:
    #print(c)
#armazena cada letra do nome na variavel de controle e imprimi na tela depois



#ESTRUTURA DE SIMPLES DE REPETÇÃO - ENUMERATE()

#nome = "Rodrigo"

#for i, c in enumerate(nome):
    #print (f"Posição = {i}, valor = {c}")

#vai pegar duas variaves de controle. em uma ele vai enumerar a posição de cada
#e na outra ele vai imprimir na tela cada letra em ordem



#ESTRUTURA DE SIMPLES DE REPETÇÃO - RANGE() METODO 1:

#for x in range(5):
    #print(x)
#imprimi na tela numeros de 0 até 4, buscando sempre contar o zero como uma posição

#RANGE METODO 2

#for i in range (1,6):
    #print(i)
#como parametro, pode escolher da onde a contagem vai começar e até aonde ela vai

#RANGE METODO 3

#for i in range(0,20,3):
    #print(i)
#escolhendo como parametro da onde começa, até aonde vai e o tipo de incremento.



#ESTRUTURAS SIMPLES DE REPETIÇÃO - BREAK

#nome = "Linguagem de programa"

#for c in nome:
    #if c == 'a':
        #break
    #else:
        #print(c)

#o break é usado para que o sistema encontre algo que foi dito na condição,
#e pause ele assim que achar, imprimindo só o resultado gravado na variavel de controle.



#ESTRUTURAS SIMPLES DE REPETIÇÃO - CONTINUE

#nome = "LINGUAGEM DE PROGRAMAÇÃO"

#for c in nome:
    #if c == 'A':
        #continue
    #else:
        #print(c)
#mesma logica do break, mas na hora que ele acha o que determinado, ele continua
#por toda a frase ou palavra, para no fim, ele imprimir na tela tudo,
#mas sem o que for passando para ele não imprimir.
