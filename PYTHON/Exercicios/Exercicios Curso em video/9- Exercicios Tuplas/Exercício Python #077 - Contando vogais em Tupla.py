palavras = tuple(input(f'Digite a {i+1}° palavra: ') for i in range(4))

for p in palavras:
    print(f'Dentro da palavra {p.upper()} temos: ', end='')
    for letra in p:
        if letra.lower() in 'aeiou':
            print(f'{letra}')



