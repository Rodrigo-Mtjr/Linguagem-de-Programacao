lista = []
cont = 0

while True:
    lista.append(int(input('Digite um valor: ')))
    cont = cont + 1
    resp = ' '
    while resp not in 'NS':
        resp = str(input('Quer continuar? [S/N]: ')).strip().upper()[0]
    if resp == 'N':
        break


print('-=' * 30)
print(f'Você digitou {cont} elementos.')
lista.sort(reverse=True)
print(f'Os valores em ordem descrescente são {lista}')

if 5 in lista:
    print('O valor 5 faz parte da lista!')
else:
    print('O valor 5 não foi encontrado!')