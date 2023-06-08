import time

km = int(input('Qual é a distância da sua viagem?: '))
print('Você está preste a começar uma viagem de {:.1f}KM'.format(km))

if km <= 200:
    preco_viagem = km * 0.50

else:
    preco_viagem = km * 0.45

print('PROCESSANDO...')
time.sleep(3)
print('E o preço da sua passagem será de R${:.2f}! \nBOA VIAGEM!!'.format(preco_viagem))
