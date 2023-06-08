def fatorial(n, show = False):
    '''
    -> CALCULA O FATORIAL DE UM NUMERO.
    :param n: O NUMERO A SER CALCULADO.
    :param show: MOSTRAR OU NAO A CONTA.
    :return: O VALOR DO FATORIAL DE UM NUMERO N
    '''
    f = 1
    for c in range(n, 0, -1):
        if show:
            print(c, end='')
            if c > 1:
                print(' x ', end='')
            else:
                print(' = ', end='')
        f = f * c
    return f

print(fatorial(5, show=True))