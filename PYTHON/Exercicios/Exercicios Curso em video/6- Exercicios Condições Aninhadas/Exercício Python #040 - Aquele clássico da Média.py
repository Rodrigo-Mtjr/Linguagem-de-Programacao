n1 = float(input('Digite a primeira nota: '))
n2 = float(input('Digite a segunda nota: '))

media = (n1+n2)/2

if media < 5.0:
    print('As notas {} e {} deram uma média de {}! \nO aluno está REPROVADO!!'.format(n1,n2,media))
elif media >= 5.0 and media <= 6.9:
    print('As notas {} e {} deram uma média de {}! \nO aluno está de RECUPERAÇÃO!!'.format(n1,n2,media))
else:
    print('As notas {} e {} deram uma média de {}! \nO Aluno está APROVADO!! \nPARABÉNS!!!'.format(n1,n2,media))

