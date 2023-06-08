from time import sleep
n1 = int(input('Primeiro valor: '))
n2 = int(input('Segundo valor: '))
opcao = 0

while opcao != 5:
    print('-='*20)
    print('[ 1 ] SOMAR')
    print('[ 2 ] MULTIPLICAR')
    print('[ 3 ] MAIOR')
    print('[ 4 ] NOVOS NUMEROS')
    print('[ 5 ] SAIR DO PROGRAMA')
    opcao = int(input('>>>>> Qual é a sua opção? '))


    if opcao == 1:
        soma = n1 + n2
        sleep(1)
        print('A soma entre {} + {} é: {} '.format(n1,n2,soma))
    elif opcao == 2:
        mult = n1 * n2
        sleep(1)
        print('A multiplicação entre {} x {} é: {} '.format(n1, n2, mult))
    elif opcao == 3:
        maior = max(n1,n2)
        sleep(1)
        print('O número maior entre {} e {} é: {}'.format(n1, n2, maior))
    elif opcao == 4:
        print('Informe novos números: ')
        n1 = int(input('Primeiro valor: '))
        n2 = int(input('Segundo valor: '))
    elif opcao == 5:
        print('Finalizando...')
        sleep(1)
    print('-='*20)


print('Até mais!')
