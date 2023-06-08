'''O algoritmo selection sort recebe esse nome, porque faz a ordenação sempre escolhendo o menor valor para ocupar uma determinada posição.
Para entendermos como funciona o algoritmo, suponha que exista uma fila de pessoas, mas que, por algum motivo, elas precisem ser colocadas por ordem de tamanho, do menor para o maior.
Essa ordenação será feita por um supervisor. Segundo o algoritmo selection sort, esse supervisor olhará para cada uma das pessoas na fila e procurará a menor delas.
Quando encontrá-la, essa pessoa trocará de posição com a primeira. Veja que, agora, a primeira pessoa da fila está na posição correta, pois é a menor.
Em seguida, o supervisor precisa olhar para as demais e escolher a segunda menor pessoa; quando encontrá-la, a pessoa troca de lugar com a segunda.
Agora as duas primeiras pessoas da fila estão ordenadas. Esse mecanismo é feito até que todos estejam em suas devidas posições. Portanto, a lógica do algoritmo é a seguinte:

Iteração 1: percorre toda a lista, procurando o menor valor para ocupar a posição 0.
Iteração 2: a partir da posição 1, percorre toda a lista, procurando o menor valor para ocupar a posição 1.
Iteração 3: a partir da posição 2, percorre toda a lista, procurando o menor valor para ocupar a posição 2.
Esse processo é repetido N-1 vezes, sendo N o tamanho da lista.'''

#EXEMPLO 1
print("EXEMPLO 1\n")
def executar_selection_sort(lista):
    n = len(lista)

    for i in range(0, n): #ESTA SALVANDO NA VARIVAVEL DE CONTROLE I, O VALOR DE CADA POSIÇÃO DE DE 0 A N, QUE SAO OS VALORES PASSADO COMO PARAMETRO DA LISTA.
        index_menor = i   #CRIANDO UMA OUTRA VARIAVEL DE AUXILIO PARA RECEBER O VALOR DE I
        for j in range(i + 1, n): #ESTA SALVANDO NA VARIAVEL DE CONTROLE J, A POSIÇÃO DE I MAIS UM, ATÉ N
            if lista[j] < lista[index_menor]: #SE O VALOR J, QUE SERA O NUMERO A SER TROCADO, FOR MENOR QUE A POSIÇÃO SALVA DENTRO DA VARIAVEL MENOR_VALOR, QUE RECEBE A POSIÇÃO SOBRE I
                index_menor = j #O MENOR VALOR PASSAR A SER O VALOR QUE ESTAVA EM J. POIS COMO NA COMPARAÇÃO, ELE FOI MENOR QUE A POSIÇÃO I, ELE ENTRA NO LUGAR.
        lista[i], lista[index_menor] = lista[index_menor], lista[i] #E AQUI, DEFININMOS A TROCA DOS VALORES ACHADOS NA CONDIÇÃO A CIMA
    return lista

lista = [10, 9, 5, 8, 11, -1, 3]
print(executar_selection_sort(lista))
print("\n")



#EXEMPLO 1
print("EXEMPLO 1\n")
def executar_selection_sort(lista2):
    n = len(lista2)

    for i in range(0, n):
	        print('\n---------- i = ', i)
	        index_menor = i
	        for j in range(i+1, n):

	            print(f'\nlista[{j}] {lista2[j]} x {lista2[index_menor]} lista[{index_menor}]')

	            if lista[j] < lista2[index_menor]:
	                index_menor = j
	                print('index_menor = ', index_menor)

	        lista2[i], lista2[index_menor] = lista2[index_menor], lista2[i]

	        print(f'\nLista ao final da iteração i = {i} = {lista2}')
	        return lista2


print(executar_selection_sort([10, 9, 5, 8, 11]))
print("\n")



#EXEMPLO 2
print("EXEMPLO 2\n")
def executar_selectio_sort2(lista):
    lista_ordenada = [] #CRIANDO UMA LISTA NOVA, SÓ QUE SEM INFORMAÇÃO
    while lista: #ENQUANDO TIVER INFORMAÇÃO DENTRO DA LISTA, FAÇA
        minino = min(lista) #VARIAVEL MININO RECEBENDO O MENOR VALOR DA LISTA, ENQUANTO ELA TIVER INFORMAÇÃO
        lista_ordenada.append(minino) #FAZENDO COM QUE A VARIAVEL RECEBA O VALOR ENCONTRADO EM OUTRA VARIAVEL, QUE ESTA COMO PARAMETRO, ESSA Á FUNÇÃO DO .APPEND().
        lista.remove(minino) #VAI REMOVER A MESMA INFORMAÇÃO DA LISTA ANTIGA, POIS O INTUITO É PASSAR O VALOR PARA OUTRA LISTA NOVA, DO MENOR PARA O MAIOR.
    return lista_ordenada

lista1 = [10, 9, 5, 8, 11, -1, 3]
print(executar_selectio_sort2(lista1))


print("\n")

