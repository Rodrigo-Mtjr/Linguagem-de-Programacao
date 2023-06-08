'''Outro algoritmo usado para buscar um valor em uma sequência é o de busca binária.
A primeira grande diferença entre o algoritmo de busca linear e o algoritmo de busca binária é que, com este último, os valores precisam estar ordenados. A lógica é a seguinte:

Encontra o item no meio da sequência (meio da lista).
Se o valor procurado for igual ao item do meio, a busca se encerra.
Se não for, verifica-se se o valor buscado é maior ou menor que o valor central.
Se for maior, então a busca acontecerá na metade superior da sequência (a inferior é descartada); se não for, a busca acontecerá na metada inferior da sequência (a superior é descartada).'''


#EXEMPLO 1
print("EXEMPLO 1")
def executar_busca_binaria(lista, valor):
    minimo = 0 #CRIANDO UMA EXTREMIDA DENTRO DA LISTA VALENDO 0
    maximo = len(lista) - 1 #CRIANDO UMA EXTREMIDADE DA LISTA VALENDO ELA MENOS 1
    while minimo <= maximo: #EQUANTO O MININO FOR MENOR OU IGUAL A MAXIMO, FAÇA
        meio = (minimo + maximo) // 2 #AQUI ESTAMOS DECLARANDO O MEIO DA LISTA, ENTRE AS VARIAVEIS MININO E MAXIMO, COM A INFORMÇÃO QUE VAI SER PASSADA COMO PARAMETRO DE ENTRADA
        if valor < lista[meio]: #SE VALOR COMO PARAMETRO DE ENTRADA, FOR MENOR QUE O MEIO DA LISTA DEFINIDO PELA EQUAÇÃO A CIMA, ENTAO
            maximo = meio - 1 #A VARIAVEL MAXIMO AGORA TEM UM NOVO, VALOR, QUE SERIA O MEIO DA LISTA MENOS 1, EXCLUINDO A PARTE SUPERIOR DA LISTA
        elif valor > lista[meio]: #SE O VALOR COMO PARAMETRO DE ENTRADA, FOR MAIOR QUE O MEIO DA LISTA DEFINIDO PELA EQUAÇÃO A CIMA, ENTAO
            minimo = meio + 1 #A VARIAVEL MININO AGORA TEM UM NOVO VALOR, QUE SERIA O MEIO DA LISTA MAIS 1, EXCLUINDO A PARTE INFERIOR DA LISTA
        else:
            return True
    return False

lista = list(range(1, 50)) #CRIANDO UMA LISTA QUE COMECE DO VALOR 1, COM 50 POSIÇÕES

print(lista)
print('\n', executar_busca_binaria(lista= lista, valor = 10))
print('\n', executar_busca_binaria(lista= lista, valor = 200))
print("")


#EXEMPLO 2
print("EXEMPLO 2")
def procurar_valor(lista, valor):
    minimo = 0
    maximo = len(lista) - 1
    while minimo <= maximo:
        meio = (minimo + maximo) // 2
        if valor < lista[meio]:
            maximo = meio - 1
        elif valor > lista[meio]:
            minimo = meio + 1
        else:
            return meio
    return None

vogais = ['a', 'e', 'i', 'o', 'u']

resultado = procurar_valor(lista=vogais, valor='z')

if resultado:
    print(f"Valor encontrado an posição {resultado}")
else:
    print("Valor não encontrado")