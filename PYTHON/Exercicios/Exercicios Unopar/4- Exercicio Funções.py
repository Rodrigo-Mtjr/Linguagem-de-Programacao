#FUNÇÃO PARA CONVERTER DATA ABREVIADA EM MES POR EXTENSO.

def converter_mes(data): #criando a função com o nome e o parametro de entrada.
    mes = '''janeiro fevereiro março abril maio junho julho agosto setembro outubro novembro dezembro'''.split() #declarando uma variavel dentro da função chamada mes, que vai receber todos os meses do ano e que vai salvar conforme os espaços entre as palavras, usando a função SPLIT
    d, m, a = data.split('/') #declarando mais 3 variaves locais, aonde elas vao receber a data que o usuario digitar, dividindo as informaçoes usando a split(/), que vai salvar tudo a cada barra que ele encontrar
    mes_extenso = mes[int(m) - 1] #a função mes em extenso vai chamar dentro da variavel mes o mes com o nome, pra isso, usamos o vetor int[m - 1], ele vai buscar o mes menos um, pois começa no 0.
    return f'{d} de {mes_extenso} de {a}' #depois ele vai retornar a função como foi declarado para ser

print(converter_mes('28/12/2023'))