soma = 0
cont = 0
for c in range(1, 501, 2):
    if c % 3 == 0:
        cont = cont + 1
        soma = soma + c
print('A soma total dos numeros foi {}'.format(soma))
print('A quantidade de numeros somados: {}'.format(cont))