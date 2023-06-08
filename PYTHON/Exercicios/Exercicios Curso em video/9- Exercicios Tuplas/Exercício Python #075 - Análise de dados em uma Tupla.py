numeros = (int(input('Digige um numero: ')),
           int(input('Digite outro numero: ')),
           int(input('Digite mais um numero: ')),
           int(input('Digite o ultimo numero: ')))
print(f'Você Digitou os valores: {numeros}')
print(f'O numero 9 apareceu {numeros.count(9)} vezes.')
if 3 in numeros:
    print(f'o numeor 3 apareceu na {numeros.index(3)+1}° posição.')
else:
    print('O valor 3 não foi digitado.')
print('Os valores pares digitados foram: ', end='')

for n in numeros:
    if n % 2 == 0:
        print(n, end=' ')