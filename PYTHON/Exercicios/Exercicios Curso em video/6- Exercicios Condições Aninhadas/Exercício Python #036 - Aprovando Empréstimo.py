casa = float(input('Digite o valor da casa: '))
salario = float(input('Digite o salario do comprador: '))
anos = int(input('Quantos anos de financiamento: '))

prestacao = casa / (anos * 12)

if prestacao >= (salario*30/100):
    print('A prestação ficou {:.2f} \nEmpréstimo NEGADO'.format(prestacao))

elif prestacao <= (salario*30/100):
    print('A prestação ficou {:.2f} por mês! \nEmprestimo APROVADO'.format(prestacao))
