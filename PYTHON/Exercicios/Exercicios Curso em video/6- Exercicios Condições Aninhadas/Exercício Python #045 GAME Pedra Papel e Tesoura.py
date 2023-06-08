from random import randint
from time import sleep

itens = ('Pedra', 'Papel', 'Tesoura')
computador = randint(0,2)
print(''' Suas opções: 
[ 0 ] PEDRA
[ 1 ] PAPEL
[ 2 ] TESOURA''')
jogador = int(input('Qual é a sua jogada?: '))
print('JO')
sleep(1)
print('KEN')
sleep(1)
print('PO!!!')

print('-=' *12)
print('COMPUTADOR JOGOU: {}'.format(itens[computador]))
print('JOGADOR JOGOU: {}.'.format(itens[jogador]))
print('-=' *12)

if computador == 0: #PEDRA
    if jogador == 0:
        print('O JOGO EMPATOU!!')
    elif jogador == 1:
        print('O JOGADOR VENCEU!!')
    elif jogador == 2:
        print('O COMPUTADOR VENCEU!!')
    else:
        print('JOGADA INVALIDA!!')

elif computador == 1: #PAPEL
    if jogador == 0:
        print('O COMPUTADOR VENCEU!!')
    elif jogador == 1:
        print('O JOGO EMPATOU!!')
    elif jogador == 2:
        print('O JOGADOR VENCEU!!')
    else:
        print('JOGADA INVALIDA!!')

elif computador == 2: #TESOURA
    if jogador == 0:
        print('O JOGADOR VENCEU!!')
    elif jogador == 1:
        print('O COMPUTADOR VENCEU!!')
    elif jogador == 2:
        print('O JOGO EMPATOU!!')
    else:
        print('JOGADA INVALIDA')
else:
    print('JOGADA INVALIDA')