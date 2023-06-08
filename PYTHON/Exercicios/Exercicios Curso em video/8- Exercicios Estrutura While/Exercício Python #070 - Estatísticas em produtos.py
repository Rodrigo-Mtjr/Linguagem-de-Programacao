tot = totmil = menor = cont = itens = 0
barato = ' '


print('{:-^40}'.format(' LOJA SUPER BARATÃO '))
while True:
    produto = str(input('Nome do produto: '))
    preco = float(input('Preço: R$ '))
    cont = cont + 1
    itens = itens + 1
    tot = tot + preco
    if preco > 1000:
        totmil = totmil + 1
    if cont == 1:
        menor = preco
        barato = produto
    else:
        if preco < menor:
            menor = preco
            barato = produto

    resp = ' '
    while resp not in 'SN':
        resp = str(input('Quer continuar? [S/N] ')).upper().strip()
    if resp == 'N':
        break

print('{:-^40}'.format(' FIM DO PROGRAMA '))
print(f'O total da compra foi de R${tot:.2f} com a quantidade de {itens} itens no carrinho.')
print(f'Temos {totmil} produtos custando mais de R$1.000,00.' if totmil > 1 else f'Temos apenas {totmil} produto custando mais de R$1.000,00.')
print(f'O produto mais barato foi {produto} que custa R${menor:.2f}')