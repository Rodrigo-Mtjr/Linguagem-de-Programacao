def calular_valores(valor1=0, valor2=0, operacao=None):
    escolha_usuario = operacao

    if escolha_usuario == 'adição':
        resultado = valor1 + valor2
        return f'\nO resultado da adição foi {resultado}'
    elif escolha_usuario == 'subtração':
        resultado = valor1 - valor2
        return f'\nO resultado da subtração foi {resultado}'
    elif escolha_usuario == 'divisão':
        resultado = valor1 / valor2
        return f'\nO resultado da divisão foi {resultado}'
    elif escolha_usuario == 'multiplicação':
        resultado = valor1 * valor2
        return f'\nO resultado da multiplicação foi {resultado}'
    else:
        return '''\nOperação NÃO SELECIONADA!
        
POR FAVOR, INSIRA UMA OPERAÇÃO: ADIÇÃO, SUBTRAÇÃO, DIVISÃO OU MULTIPLICAÇÃO'''


print("CALCULADORA")

x1= (int(input("Digite o primeiro valor a ser calculado: ")))
x2= (int(input("Digite o segundo valor a ser calculado: ")))
operacao = input("POR FAVOR, DIGITE a operação que deseja fazer: adição, subtração, divisão, multiplicação: ")


print("\nCALCULANDO........")
print(calular_valores(valor1= x1, valor2=x2, operacao=operacao))





