n1 = int(input('Digite um numero inteiro: '))
print('Escolha uma das bases para conversão: ')
print('[ 1 ] CONVERTER PARA BINÁRIO')
print('[ 2 ] CONVERTER PARA OCTAL')
print('[ 3 ] CONVERTER PARA HEXADECIMAL')
escolha = int(input('Sua opção: '))

if escolha == 1:
    print('{} convertido para BINARIO é igual a {}'.format(n1, bin(n1) [2:]))
elif escolha == 2:
    print ('{} convertido para OCTAL é igual a {}'.format(n1, oct(n1)[2:]))
elif escolha == 3:
    print('{} convertido para HEXADECIMAL é igual a {}'.format(n1, hex(n1)[2:]))
else:
    print('Opção Invalida!!')