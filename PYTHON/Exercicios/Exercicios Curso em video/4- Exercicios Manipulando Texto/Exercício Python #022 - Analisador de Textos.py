nome = str(input('Digite seu nome completo: ')).strip()
print('Analisando seu nome...')
lista_nome = nome.split()

print('Seu nome em maiúsculas é {}'.format(nome.upper()))
print('Seu nome em minúsculas é {}'.format(nome.lower()))
print('Seu nome tem ao todo {} letras'.format(len(nome) - nome.count(' ')))
print('Seu primeiro nome é {} e ele tem {} letras'.format(lista_nome[0], len(lista_nome[0])))
