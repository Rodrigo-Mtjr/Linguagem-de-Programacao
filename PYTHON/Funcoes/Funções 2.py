#Parâmetro posicional, obrigatório, sem valor default (padrão).

def somar(a, b):
    return a + b

r = somar(2)
print(r)
#SE TENTARMOS EXECUTAR O CODIGO ACIMA, VAI DAR UM ERRO, O CORRETO SERIA COLOCAR DOIS PARAMETROS DE ENTRADA, COMO FOI DEFINIDO NA CRIAÇÃO DA FUNÇÃO

def somar(a, b):
    return a + b

r = somar(2,3)
print(r)
#JEITO CORRETO!

#----------------------------------------------------------------------------------------------------------------------------------------------------

#Parâmetro posicional, obrigatório, com valor default (padrão).

def calcular_desconto(valor, desconto=0): #o desconto possui como valor um zero, valor default, nao apresenta erro se executarmos.
    valor_com_desconto = valor - (valor * desconto)
    return  valor_com_desconto

valor1 = calcular_desconto(100) #valor sem desconto nenhum.
valor2 = calcular_desconto(100, 0.25) #aplicar desconto de 25%

print(f"\nPrimeiro valor a ser pago {valor1}") #vai mostrar o valor de 100
print(f"\nSegundo valor a ser pago {valor2}") #vai mostrar o valor de 75.0
#----------------------------------------------------------------------------------------------------------------------------------------------------

#Parâmetro nominal, obrigatório, sem valor default (padrão).

def converter_maiuscula(texto, flag_maiuscula):
    if flag_maiuscula:
        return texto.upper()
    else:
        return texto.lower()

texto = converter_maiuscula(flag_maiuscula= True, texto= 'Rodrigo')
print(texto)
#Nesse modo de função, a questão posicional nao interfere na hora de invocar a função, pois quando vamos atribuir os valores nos parametros de entrada, estamos relacinando junto ao nome das variaveis locais.
#----------------------------------------------------------------------------------------------------------------------------------------------------

#Parâmetro nominal, obrigatório, com valor default (padrão).

def converter_minuscula(texto, flag_minuscula= True): #valor true como valor default, entao se ele for invocado ou nao, ele vai executar do mesmo jeito, ao menos que se altere o valor dele
    if flag_minuscula:
        texto.lower()
    else:
        texto.upper()

texto1 = converter_minuscula(flag_minuscula=True, texto="LINGUAGEM de programção")
texto2 = converter_minuscula(texto = "LINGUAGEM de programação")

print(f"\nTexto 1 = {texto1}")
print(f"\nTexto 2 = {texto2}")

#Parâmetro posicional e não obrigatório (args).
#esse seria basicamente para quando não sabemos quais as quantidades de parametros que vamos utilizar

def imprimir_parametros(*args): #usamos o *args quando nao sabemos a quantidade de parametros de entrada
    qtde_parametros = len(args) #aqui definimos uma variavel local para receber a contagem desses parametros com a função LEN
    print(f"Quantidade de parametros = {qtde_parametros}") #estamos pedindo para imprimir essa contagem feita

    for i, valor in enumerate(args): #com a função enumarete() vamos pegar a posição de cada um desses parametros e enumerar, linha por linha, dentro da variavel I e depois mostrar o valor na variavel VALOR
        print(f"Posição = {i}, valor = {valor}") #aqui estamos mostrando o valor de cada parametro

print("\nCHAMADA 1")
imprimir_parametros("São Paulo", 10, 23.78, "João") #invocando a função e colocando os parametros de entrada

print("\nCHAMADA 2")
imprimir_parametros(10, "São Paulo") #invocando a função e colocando os parametros de entrada


#Parâmetro nominal e não obrigatório (kwargs).
#Da para colocarmos qualquer tipo de variavel dentro dos parametros, tendo que apenas colocar cada conteudo dentro dela

def imprimir_parametros(**kwargs):
    print(f"Tipo de objeto recebido = {type(kwargs)}\n")
    qtde_parametros = len(kwargs)
    print(f"Quantidade de parametros = {qtde_parametros}")

    for chave, valor in kwargs.items():
        print(f"Variavel = {chave}, valor = {valor}")

print("\nChamada 1")
imprimir_parametros(cidade="São Paulo", idade= 33, nome="João")

print("\nChamada 2")
imprimir_parametros(desconto = 10, valor = 100)
