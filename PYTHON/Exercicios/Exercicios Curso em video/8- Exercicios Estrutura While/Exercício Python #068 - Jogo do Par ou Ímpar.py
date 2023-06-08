from random import randint
v = 0

print('-=' * 15)
print('VAMOS JOGAR PAR OU IMPAR')
print('-=' * 15)

while True:
    n = int(input('Diga um valor: '))
    computador = randint(0, 10)
    soma = n + computador
    escolha = ' '
    while escolha not in 'PI':
       escolha = str(input('Par ou Impar? [P/I]: ')).upper().strip()[0]
    print('-=' * 15)
    print(f'Você jogou {n} e o computador {computador}. Total de {soma} ', end='')
    print('DEU PAR!' if soma % 2 == 0 else 'DEU IMPAR!')
    if escolha == 'P':
        if soma % 2 == 0:
            print('Você VENCEU!')
            v = v + 1
        else:
            print ('Você PERDEU!')
            break
    elif escolha == 'I':
        if soma % 2 == 1:
            print('Você VENCEU!')
            v = v + 1
        else:
            print('Você PERDEU!')
            break
    print('Vamos jogar novamente...')
    print('-=' * 15)
print(f'GAME OVER! Você venceu {v} vezes.')








