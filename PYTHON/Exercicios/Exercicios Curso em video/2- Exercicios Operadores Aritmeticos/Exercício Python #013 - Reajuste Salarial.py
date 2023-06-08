salario = float(input('Qual é o salário do Funcionário? R$: '))
valor_aumento = float(input('Digite a porcentagem de aumento: '))

salario_reajuste = salario+((valor_aumento/100)*salario)

print('Um funcionário que ganhava R${}, com {}% de aumento, passa a receber R${:.2f}'.format(salario, valor_aumento, salario_reajuste))
