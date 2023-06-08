import datetime
ano = int(input('Digite o ano de nascimento: '))

idade = datetime.date.today().year - ano
data_atual = datetime.date.today()

print('Quem nasceu em {} tem {} anos de idade em {}.'.format(ano, idade, datetime.date.today().year))

if idade == 18 and data_atual < datetime.date(2023,5,31):
    print('Esse ano voce TEM que se alistar, ainda está no prazo!')
elif idade == 18 and data_atual > datetime.date(2023,5,31):
    print('Esse ano você TINHA que se alistar, mas passou do prazo!')
elif idade > 18:
    prazo = idade - 18
    ano_alistamento = datetime.date.today().year - prazo
    print('Você já deveria ter se alistado há {} anos!! \nSeu alistamento foi em {}!!'.format(prazo, ano_alistamento))
else:
    prazo = 18 - idade
    ano_alistamento = prazo + datetime.date.today().year
    print('Ainda faltam {} anos para o alistamnento! \nSeu alistamento será em {}!!'.format(prazo, ano_alistamento))


