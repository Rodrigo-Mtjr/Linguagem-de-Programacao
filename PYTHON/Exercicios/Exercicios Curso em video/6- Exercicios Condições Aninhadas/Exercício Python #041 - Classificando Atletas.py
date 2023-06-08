from datetime import date

ano = int(input('Ano de Nascimento: '))
idade = date.today().year - ano

print('O atleta tem {} anos de idade!'.format(idade))

if idade <= 9:
    print('CLASSIFICAÇÃO: MIRIM')
elif idade >9 and idade <= 14:
    print('CLASSIFICAÇÃO: JUNIOR')
elif idade >14 and idade <= 25:
    print('CLASSIFICAÇÃO: SENIOR')
else:
    print('CLASSIFICAÇÃO: MASTER')