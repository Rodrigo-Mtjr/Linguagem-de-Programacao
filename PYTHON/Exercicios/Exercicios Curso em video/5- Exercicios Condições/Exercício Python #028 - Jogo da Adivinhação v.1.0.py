import random
import time #importando modulos para colocar um temporizador no codigo
computador = random.randint(0,5)
print('-=-' * 20)
print('Vou pensar em um número entre 0 e 5. Tente adivinhar...')
print('-=-' * 20)
n1 = int(input('Qual numero eu escolhi?: '))
print('PROCESSANDO...')
time.sleep(2) #colocando um temporizador para o computador "pensar" na resposta

if n1 != computador:
    print('GANHEI! Eu pensei no numero {} e não no {}'.format(computador, n1))
else:
    print('PARABENS! Voce conseguiu me vencer!')



