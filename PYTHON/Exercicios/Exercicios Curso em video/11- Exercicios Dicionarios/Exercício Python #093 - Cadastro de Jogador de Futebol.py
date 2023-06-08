jogador = dict()
partidas = list()
jogador['nome'] = str(input('Nome do Jogador: '))
qtdePartidas = int(input(f'Quantas partidas o {jogador["nome"]} jogou? '))
for i in range(0, qtdePartidas):
    partidas.append(int(input(f'    Quantos gols na partida {i+1}: ')))
    jogador['gols'] = partidas[:]
    jogador['total de gols'] = sum(jogador['gols'])
print('-=' * 30)
print(jogador)
print('-=' * 30)

for k, v in jogador.items():
    print(f'O campo {k} tem o valor {v}.')
print('-='*30)
print(f'O jogador {jogador["nome"]} jogou {len(jogador["gols"])} partidas.')
for i, v in enumerate(jogador['gols']):
    print(f'   => Na partida {i+1}, fez {v} gols.')
print(f'Total de {jogador["total de gols"]} gols.')


