valor = float(input('Quanto de dinheiro você tem na carteira? R$: '))

dolar_atual = 3.27
conversao = valor / dolar_atual

print('Com o valor R${}, você pode comprar {:.2f} de dolar'.format(valor, conversao))
