salario = float(input('Qual o salário do funcionário? '))

if salario <= 1250:
    salario_novo = salario+(salario*15/100)
else:
    salario_novo = salario+(salario*10/100)

print('Quem ganhava R${:.2f} passar a ganhar R${:.2f} agora.'.format(salario, salario_novo))