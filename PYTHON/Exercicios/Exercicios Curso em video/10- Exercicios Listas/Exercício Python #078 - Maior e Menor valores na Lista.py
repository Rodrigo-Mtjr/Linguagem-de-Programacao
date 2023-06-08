valores = []

maior = 0
menor = 0

for i in range(5):
    valores.append(int(input(f'Digite um valor para a posição {i}: ')))
    if i == 0:
        menor = maior = valores[i]
    else:
        if valores[i] > maior:
            maior = valores[i]
        if valores[i] < menor:
            menor = valores[i]

print(f'Os valores digitados foram: {valores}')
print(f'O maior valor digitado foi {maior} na posição ', end='')
for p, v in enumerate(valores):
    if v == maior:
        print(f'{p}...')
print()
print(f'O menor valor digitado foi {menor} na posição ', end='')
for p, v in enumerate(valores):
    if v == menor:
        print(f'{p}...')
