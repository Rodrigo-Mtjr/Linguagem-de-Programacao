from random import randint
from time import sleep

print('-='*30)
print('         JOGOS DA MEGA SENA!!')
print('-='*30)

lista = list()
quant = int(input('Quantos jogos voce quer que eu sorteie? '))
tot = 1
jogos = list()

while tot <= quant:
    cont = 0
    while True:
        num = randint(1, 60)
        if num not in lista:
            lista.append(num)
            cont = cont + 1
        if cont >= 6:
            break
    jogos.append(lista[:])
    lista.clear()
    tot = tot + 1

print('-' *3, f'SORTEANDO {quant} JOGOS','-' *3)
sleep(1)
for i, j in enumerate(jogos):
    sleep(1)
    print(f'Jogo {i+1}: {j}')
print('BOA SORTE!!')