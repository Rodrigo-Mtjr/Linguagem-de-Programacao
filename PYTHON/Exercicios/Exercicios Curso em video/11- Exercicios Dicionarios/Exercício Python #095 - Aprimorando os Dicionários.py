jogador = dict()
partidas = list()
time = list()

while True:
    jogador.clear()
    jogador['nome'] = str(input('Nome do Jogador: '))
    qtdePartidas = int(input(f'Quantas partidas o {jogador["nome"]} jogou? '))
    partidas.clear()
    for i in range(0, qtdePartidas):
        partidas.append(int(input(f'    Quantos gols na partida {i+1}: ')))
        jogador['gols'] = partidas[:]
        jogador['total de gols'] = sum(jogador['gols'])
    time.append(jogador.copy())
    while True:
        resp = str(input('Quer continuar? [S/N] ')).upper()[0]
        if resp in 'SN':
            break
        print('ERRO! Por favor, digite apenas S ou N.')
    if resp == 'N':
        break
print('-=' * 30)
print('cod ', end='')
for k in jogador.keys():
    print(f'{k:<15}', end='')
print()
print('-' * 40)
for k, v in enumerate(time):
    print(f'{k+1:>3}', end='')
    for d in v.values():
        print(f' {str(d):<15}', end='')
    print()
print('-' * 40)
while True:
    busca = int(input('Mostrar dados de qual jogador? (999 para parar)'))
    if busca == 999:
        break
    if busca >= len(time):
        print(f'ERRO! Não existe jogador com código {busca}')
    else:
        print(f' -- LEVANTAMENTO DO JOGADOR {time[busca]["nome"].upper()} --')
        for i, g in enumerate(time[busca]['gols']):
            print(f'   No jogo {i+1}° fez {g} gols')
    print('-' * 40)
print('<< ENCERRANDO >>')


