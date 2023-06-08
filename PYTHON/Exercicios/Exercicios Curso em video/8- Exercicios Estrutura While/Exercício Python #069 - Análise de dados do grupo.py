from time import sleep
tot18 = 0
cont = 0
homens = 0
mulheres = 0

while True:
    print('-'* 25)
    print('   CADASTRE UMA PESSOA')
    print('-' * 25)
    idade = int(input('Idade: '))
    sexo = ' '
    while sexo not in 'MF':
        sexo = str(input('Sexo: [M/F] ')).strip().upper()[0]
    cont = cont + 1
    if idade >= 18:
        tot18 = tot18 + 1
    if sexo == 'M':
        homens = homens + 1
    if sexo == 'F' and idade < 20:
        mulheres = mulheres + 1
    escolha = ' '
    while escolha not in 'SN':
        escolha = str(input('Quer continuar? [S/N]: ')).upper().strip()
    if escolha == 'N':
        break

print('-'* 25)
print('ANALISANDO O CADASTRO...')
sleep(1)
print('-'* 25)

print(f'Foi cadastrada {cont} pessoa!' if cont <= 1 else f'Foram cadastradas {cont} pessoas!')
print(f'Dentre os registros analisados, {tot18} pessoas são maiores de 18 anos.' if tot18 > 1 else f'No registro analisado, apenas {tot18} pessoa tem mais de 18 anos.')
print(f'Foram cadastrados {homens} homens!' if homens > 1 else f'Foi cadastrado apenas {homens} homem!')
print(f'Foram cadastrada {mulheres} mulheres com menos de 20 anos.' if mulheres > 1 else f'Foi cadastrado apenas {mulheres} mulher com menos de 20 anos.')



