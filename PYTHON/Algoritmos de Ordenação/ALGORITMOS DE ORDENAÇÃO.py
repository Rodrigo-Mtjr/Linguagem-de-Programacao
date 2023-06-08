lista = [10, 4, 1, 15, -3] #CRIAMOS UMA LISTA

lista_ordenada1 = sorted(lista) #USANDO A FUNÇÃO SORTED() COM A LISTA EM PARAMETRO, PARA ORDENAR A MESMA., TEMPORARIAMENTE.

print('lista sem ordem', lista, '\n') #IMPRIMINDO A LISTA PARA MOSTRAR QUE NADA ACONTECEU A LISTA PADRAO

lista_ordenada2 = lista.sort() #ORDENANDO A LISTA DEFINITIVAMENTE DEPOIS DE CRIADA.

print('lista = ', lista, '\n') #IMPRIMINDO A LISTA DEPOIS DE USAR A FUNÇÃO DEFINITIVA PARA ORDENAR OS NUMEROS

print('lista_ordenada1 = ', lista_ordenada1) #IMPRIMINDO O RESULTADO A PRIMEIRA ALTERAÇÃO
print('\n')


'''Como "programadores usuários", temos essas duas opções para ordenar uma lista em Python, certo? E como profissionais de tecnologia que entendem o algoritmo que está por trás de uma função?
Para alcançarmos esse mérito, vamos então conhecer cinco algoritmos de ordenação. A essência dos algoritmos de ordenação consiste em comparar dois valores, verificar qual é menor e colocar 
na posição correta. O que vai mudar, neste caso, é como e quando a comparação é feita. Para que possamos começar a entender a essência dos algoritmos de ordenação, observemos o código a seguir.'''

#EXEMPLO 1
print("EXEMPLO 1 \n")

lista1 = [7,4] #DECLARANDO UMA LISTA

if lista1[0] > lista1[1]: #CONDIÇÃO EM QUE VAI COMPARAR SE O VALOR NA POSIÇÃO 0 DA LISTA, VAI SER MAIOR QUE O VALOR NA POSIÇÃO 1.
    auxiliar = lista1[1] #SE FOR VERDADEIRO, CRIAMOS UMA VARIAVEL AUXILIAR, PARA RECEBER O VALOR DA POSIÇÃO
    lista1[1] = lista1[0] #DEPOIS SALVAMOS DENTRO DA POSIÇÃO 1 O VALOR DA POSIÇÃO 0
    lista1[0] = auxiliar #E NO FINAL FAZEMOS A TROCA COM A VARIAVEL AUXILIAR, COLOCANDO O VALOR DENTRO DA POSIÇÃO 0

print(lista1,'\n') #PRINTANDO A LISTA, QUE AGORA ESTA ORDENADA

#EXEMPLO 2
print("EXEMPLO 2 \n")

lista2 = [5, -1] #DECLRANDO A LISTA E OS VALORES

if lista2[0] > lista2[1]: #CONDIÇÃO EM QUE VAI COMPARAR SE O VALOR NA POSIÇÃO 0 DA LISTA, VAI SER MAIOR QUE O VALOR NA POSIÇÃO 1.
    lista2[0], lista2[1] = lista2[1], lista2[0] #MAGICA DO PYTHON, PODEMOS JA FAZER A TROCA EM UMA UNICA EXPRESSÃO

print(lista2)