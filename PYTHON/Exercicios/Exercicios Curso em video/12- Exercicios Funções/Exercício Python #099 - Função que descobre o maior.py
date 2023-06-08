from time import sleep
def analisa(*num):
    cont = maior = 0
    print('-='*20)
    print('Analisando os valores passados...')
    for valor in num:
        print(f'{valor} ', end='')
        sleep(0.3)
        if cont == 0:
            maior = valor
        else:
            if valor > maior:
                maior = valor
        cont = cont + 1
    print(f'Foram analisados {cont} valores ao todo')
    print(f'O maior valor passado foi {maior}')



analisa(2, 9, 4, 5, 7, 1)
analisa(4, 7, 0)
analisa(1, 2)
analisa(6)
analisa()