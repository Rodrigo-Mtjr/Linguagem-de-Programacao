def voto(anoNasc):
    from datetime import date
    idade = date.today().year - anoNasc
    if idade < 16:
        return f'Com {idade} anos: NÃO VOTA'
    elif 16 <= idade < 18 or idade > 65:
        return  f'Com {idade} anos: VOTO OPCIONAL'
    else:
        return f'Com {idade} anos: VOTO OBRIGATORIO'


ano = int(input('Digite o ano de nascimento: '))
print(voto(ano))