from time import sleep
def contador(i, f, p):
    if p < 0:
        p = p * -1
    if p == 0:
        p = 1
    print('--- COMEÇANDO ---')
    print(f'Contagem de {i} até {f} de {p} em {p}')


    cont = i
    if i <= f:
        while cont <= f:
            sleep(0.5)
            print(f'{cont} ', end='')
            cont = cont + p
        print('FIM')

    else:
        cont = i
        while cont >= f:
            sleep(0.5)
            print(f'{cont} ', end='')
            cont = cont - p
        print('FIM')


contador(1,10,1)
contador(10, 0, 2)
print('Agora é a sua vez de personalizar a contagem!')
ini = int(input('Inicio: '))
fim = int(input('Fim: '))
passo = int(input('Passo: '))
contador(ini, fim, passo)