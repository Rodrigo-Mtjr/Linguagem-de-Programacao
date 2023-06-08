print('\033[4;30;45mOlá, Mundo!\033[m')
print('\033[7;30mOlá, Mundo!\033[m')
print('\033[0;33;44mOlá, Mundo!\033[m')
print('\033[7;33;44mOlá, Mundo!\033[m')

a = 3
b = 5
print('Os valores são \033[32m{}\033[m e \033[31m{}\033[m'.format(a,b))
print('Os valores são \033[32;45m{}\033[m e \033[31;45m{}\033[m'.format(a,b))

nome = 'Rodrigo'
print('Olá! Muito prazer em te conhecer, {}{}{}!!!'.format('\033[4;34m',nome, '\033[m'))