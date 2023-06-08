#EXEMPLO 1

print("Exemplo 1")
linguagens1 = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split() # Essa sintaxe produz o mesmo resultado que a linha 1

print("Antes da listacomp = ", linguagens1) #PRINTANDO ELA ANTES DA MUDANÇA

linguagens1 = [item.lower() for item in linguagens1] #MODIFICANDO AS LETRAS EM MAISCULO, PARA MINUSCULO, DE TODAS AS PALAVRAS, E SUBSCREVENDO ELAS NO MESMA VARIAVEL

print("\nDepois da listcomp = ", linguagens1) #PRINTANDO A MUDANÇA
print("")

#EXEMPLO 2
print("Exemplo 2")
linguagens2 = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split() #DECLARANDO A VARIAVEL
print("Antes da listcomp = ", linguagens2) #PRINTANDO ANTES DA MUDANÇA

for i, item in enumerate(linguagens2): #USANDO A FUNÇÃO FOR, PARA FAZER A MUDANÇA
    linguagens2[i] = item.lower()
print("\nDepois da listcomp = ", linguagens2)
print("")

#EXEMPLO 3

print("Exemplo 3")

linguagem3 = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split() #DECLARANDO A VARIAVEL
linguagem_java = [item for item in linguagem3 if "Java" in item] #DECLRANDO OUTRA VARIAVEL PARA RECEBER APENAS AS PALAVRAS COM JAVA
                  #ESSA FUNÇÃO SE LE, SALVE DENTRO DA VARIAVEL ITEM, DA VARIAVEL LINGUAGEM3, TUDO O QUE TIVER A PALAVRA JAVA = JAVA ESTÁ EM JAVASCRIPT
                  #ESSA ELE MOSTRA A PALAVRA QUE USAMOS DE PARAMETRO, MAIS O RESULTADO

print(linguagem_java)
print("")

#EXEMPLO 4
print("Exemplo 4")

linguagem3 = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split() #DECLARANDO A VARIAVEL
linguagem_java = [item for item in linguagem3 if "Java" == item] #DECLRANDO OUTRA VARIAVEL PARA RECEBER APENAS AS PALAVRAS COM JAVA
                  #PROCURAR QUAIS SAO IGUAIS. = JAVA É IGUAL A JAVA
                  #ESSA ELE MOSTRA APENAS O RESULTADO ENCONTRADO, QUE SERIA JAVA.
print(linguagem_java)
print("")

#EXEMPLO 5
print("Exemplo 5")
linguagens = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split()
linguagens_java = []

for item in linguagens:
    if "Java" in item:
        linguagens_java.append(item)

print(linguagens_java)