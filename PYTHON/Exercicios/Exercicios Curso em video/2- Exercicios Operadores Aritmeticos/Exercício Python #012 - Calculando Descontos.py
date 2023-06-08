preco = float(input('Qual o preço do produto? R$: '))
valor_desconto = float(input('Qual sera o valor de desconto?: '))

porcentagem = preco*(valor_desconto/100)
preco_final = preco - porcentagem

print('O produto que custava {}, na promoção com desconto de {}%, vai custar {:.2f}'.format(preco, valor_desconto, preco_final))


