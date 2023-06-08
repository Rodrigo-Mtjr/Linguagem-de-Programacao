galera = list()
princ = list()
total = 0
maior = 0
menor = 0


while True:
    galera.append(str(input('Nome: ')))
    galera.append(float(input('Peso: ')))
    if len(princ) == 0:
        maior = menor = galera[1]
    else:
        if galera[1] > maior:
            maior = galera[1]
        if galera[1] < menor:
            menor = galera[1]

    princ.append(galera[:])
    total = total + 1
    galera.clear()
    resp = ' '

    while resp not in 'NS':
        resp = str(input('Quer continuar? [S/N] ')).upper().strip()[0]
    if resp == 'N':
        break

print('-=' * 30)
print(f'Ao todo você cadastrou {total} pessoas.')
print(f'O maior peso foi de {maior}Kg. Peso de ', end='')
for p in princ:
    if p[1] == maior:
        print(f'{p[0]} ', end='')
print()
print(f'O menor peso foi de {menor}Kg. Peso de ', end='')
for p in princ:
    if p[1] == menor:
        print(f'{p[0]} ', end='')
print()