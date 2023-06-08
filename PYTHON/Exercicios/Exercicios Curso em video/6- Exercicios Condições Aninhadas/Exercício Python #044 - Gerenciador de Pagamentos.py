import time

print('==*=='* 10)
print('               LOJA DAS CASINHAS')
print('==*=='* 10)

valor = float(input('Qual o valor da sua compra?: '))
print('\nCOMO DESEJA PAGAR?:')
print('''[ 1 ] A VISTA NO DINHEIRO/CHEQUE
[ 2 ] A VISTA NO CARTAO
[ 3 ] EM ATÉ 2x NO CARTÃO
[ 4 ] 3x OU MAIS NO CARTÃO''')

escolha = int(input('Escolha uma das opções: '))
print('PROCESSANDO O VALOR...')

time.sleep(3)

if escolha == 1:
    valor_final = valor - (valor * 10/100)
    print('Sua compra de R${:.2f} vai custar R${:.2f} no final.'.format(valor, valor_final))
elif escolha == 2:
    valor_final = valor - (valor * 5/100)
    print('Sua compra de R${:.2f} vai custar R${:.2f} no final.'.format(valor, valor_final))
elif escolha == 3:
    valor_final = valor / 2
    print('Sua compra de R${:.2f} foi parcelada em 2x, e ficara com parcelas de R${:.2f} por mês.'.format(valor,valor_final))
elif escolha == 4:
    total = valor + (valor * 20/100)
    totparc = int(input('Quantas parcelas?: '))
    parcela = total / totparc
    print('Sua compra será parcelada em {}x de R${:.2f} COM JUROS!'.format(totparc, parcela))
    print('Sua compra de R${:.2f} vai custar R${:.2f} no final'.format(valor, total))
else:
    total = valor
    print('Opção invalidade de pagamento. Tente novamente!')
    print('Sua compra de R${:.2f} vai custar R${:.2f} no final.'.format(valor, total))