dias = int(input('Quantos dias o carro ficou alugado?: '))
km = float(input('Qual a quantidade de KM percorrida?: '))

preco_dias = dias * 60
preco_km = km * 0.15
preco_total = preco_km + preco_dias

print('O total a pagar é de R${:.2f}'.format(preco_total))