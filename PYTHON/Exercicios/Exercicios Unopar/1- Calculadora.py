print("-----------------------------")
print("        Calculadora")
print("-----------------------------")
print("  ")

x1 = int(input("Digite o primeiro numero: "))
x2 = int(input("Digite o segundo numero: "))

print("1 - ADIÇÃO -- 2 - SUBTRAÇÃO -- 3 - DIVISÃO -- 4 - MULTIPLICAÇÃO")
operacao = int(input("Escolha a operação desejada: "))

if operacao == 1:
    r = x1 + x2
    print(f"O resultado da operação foi: {r}")
elif operacao == 2:
    r = x1 - x2
    print(f"O resultado da operação foi: {r}")
elif operacao == 3:
    r = x1/x2
    print(f"O resultado da operação foi: {r}")
else:
    r = x1 * x2
    print(f"O resultado da operaçaõ foi: {r}")