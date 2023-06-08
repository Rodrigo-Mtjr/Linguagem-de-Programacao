lista = list()

for c in range (0,4):
    n = int(input('Digite um valor: '))
    if c == 0 or n > lista[-1]: #fazendo a verificação se o valor na posição C vai ser igual a zero ou se o valor digitado vai ser maior que o ultimo numero da lista
        lista.append(n) #acrescentando o numero que ele digitou na lista, caso a verificação for verdadeira
        print('Adicionado ao final da lista...')
    else:
        pos = 0 #criando uma variavel pos para verificar a posição dentro da lista
        while pos < len(lista): #enquanto a posição for menor que o tamanho da lista, faça
            if n <= lista[pos]: #se o numero digitado pelo usuario for menor ou igual a posição
                lista.insert(pos, n) #ele vai inserir na posição que ele esta o numero que ele digitou
                print(f'Adicionado na posição {pos} da lista...') #mostrando aonde ele digitou o valor
                break #finalizando
            pos = pos + 1 #pulando de posição em posição

lista.sort()
print(f'Os valores digitados em ordem foram {lista}')