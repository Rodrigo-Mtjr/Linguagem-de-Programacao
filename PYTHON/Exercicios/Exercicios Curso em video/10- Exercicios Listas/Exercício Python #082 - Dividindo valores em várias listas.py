listacomp = list()
listapar = list()
listaimpar = list()

while True:
    n = int(input('Digite um valor: '))
    listacomp.append(n)
    if n % 2 == 0:
        listapar.append(n)
    else:
        listaimpar.append(n)
    resp = str(input('Deseja continuar? [S/N]: '))
    if resp in 'Nn':
        break

print(f'A lista completa é {listacomp}')
print(f'A lista de pares é {listapar}')
print(f'A lista de impares é {listaimpar}')