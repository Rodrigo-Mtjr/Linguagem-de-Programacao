print('='*22)
print('  10 TERMOS DE UMA PA')
print('='*22)

primeiro = int(input('Primeiro termo: '))
razao = int(input('Razão: '))
decimo = primeiro + (10 - 1) * razao
for c in range(primeiro, decimo, razao):
    print('{}'.format(c), end=' -> ')
