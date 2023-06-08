def area(larg, comp):
    area = larg * comp
    print(f'A area de um terreno {larg}x{comp} é de {area}m²')


print(' Controle de Terrenos')
print('-' * 20)
l = float(input('LARGURA (M): '))
c = float(input('COMPRIMENTO (M): '))
area(l, c)
