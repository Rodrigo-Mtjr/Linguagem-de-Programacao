velocidade = float(input('Qual a velocidade atual do veiculo?: '))
if velocidade > 80:
    print('MULTADO! Voce excedeu o limite permitido que é de 80Km/h')
    multa = (velocidade-80) * 7
    print('Você deve pagar uma multa de R${:.2f}'.format(multa))
print('Tenhna um bom dia! Dirija com segurança!')


