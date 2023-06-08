valores = list()

while True:
    n = int(input('Digite um valor: '))
    if n not in valores:
        valores.append(n)
        print('Valor adicionado com sucesso!')
    else:
        print('valor duplicado! Não vou adicionar...')

    resp = str(input('Quer continuar [S/N]: '))
    if resp in 'Nn':
        break

valores.sort()
print(f'Você digitou os valores {valores}')