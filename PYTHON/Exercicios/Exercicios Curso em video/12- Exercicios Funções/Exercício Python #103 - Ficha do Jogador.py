def ficha(nome='<desconhecido', gol=0):
    print(f'Jogador {nome} fez {gol} gol(s) no campeonato.')



n = str(input('Nome do Jogador: '))
g = str(input('Numero de Gols: '))

if g.isnumeric():
    g = int(g)
else:
    g = 0
if n.strip() == '':
    ficha(gol=g)
else:
    ficha(n, g)