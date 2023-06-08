'''num = [2,5,6,7]
num[2] = 3
num.append(8)
num.sort()
num.sort(reverse= True)
num.insert(2, 2)
if 4 in num:
    num.remove(3)
else:
    print('Não achei o numero 5')
num.remove(2)
print(num)
print(f'Essa lista tem {len(num)}')'''


'''valores.append(5)
valores.append(9)
valores.append(4)'''

valores = list(int(input('Digite um valor: ')) for c in range(5))
for c, v in enumerate(valores):
    print(f'Na posição {c} encontrei o valor {v}')
print('Cheguei ao final da lista')