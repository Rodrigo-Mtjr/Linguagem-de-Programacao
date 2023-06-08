n = int(input('Digite um numero para ver a sua tabuada: '))

for c in range (0,11):
    resultado = n * c
    print('{} x {} = {}'.format(n, c, resultado))