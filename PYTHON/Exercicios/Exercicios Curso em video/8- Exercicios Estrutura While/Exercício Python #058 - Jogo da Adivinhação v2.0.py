from random import randint
computador = randint(0,10)
tentativas = 1

print('''Sou seu computador...
Acabei de pensar em um número entre 0 e 10.
Será que você consegue adivinhar qual foi?''')
palpite = int(input('Qual o seu palpite? '))

while palpite != computador:
    if palpite < computador:
        print('Mais... Tente mais uma vez!')
        palpite = int(input('Qual é o seu palpite? '))
        tentativas = tentativas + 1
    elif palpite > computador:
        print('Menos... Tente mais uma vez!')
        palpite = int(input('Qual é o seu palpite? '))
        tentativas = tentativas + 1
print('BOA, VOCÊ ACERTOU COM {} TENTATIVAS, O NÚMERO ESCOLHIDO POR MIM FOI: {}'.format(tentativas,computador))