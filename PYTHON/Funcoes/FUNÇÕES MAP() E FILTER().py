# Exemplo 1
print("Exemplo 1")
linguagens = '''Python Java JavaScript C C# C++ Swift Go Kotlin'''.split() #DECLARANDO A LISTA

nova_lista = map(lambda x: x.lower(), linguagens) #DECLARANDO UMA NOVA LISTA, FAZENDO COM QUE ELA RECEBA AS INFORMAÇÕES DA PRIMEIRA COM ALGUNS CARACTERES TROCADOS PARA MINUSCULOS
                                                  #USANDO A FUNÇÃO MAP PARA ISSO, E DEPOIS, COM UMA FUNÇÃO LAMBDA, TROCAS AS LETRAS DA LISTA INTEIRA
print(f"A nova lista é = {nova_lista}\n") #PRINTANDO A NOVA LISTA, MAS APENAS O OBJETO ITERAVEL
                                          #PARA IMPRIMIR ELA COM AS PALAVRAS DENTRO, DEVEMOS CONVERTER ELA PARA LISTA.
nova_lista = list(nova_lista) #CONVERTENDO A LISTA NOVA LISTA PARA UMA LISTA PADRAO.
print(f"Agora sim, a nova lista é = {nova_lista}") #AGORA SIM CONSEGUIMOS IMPRIMIR A LISTA COM OS SEUS CARACTERES

# Exemplo 2
print("\n\nExemplo 2")
numeros = [0, 1, 2, 3, 4, 5] #DECLARANDO UMA NOVA LISTA E SEUS CARACTERES

quadrados = list(map(lambda x: x*x, numeros)) #DEFININDO UMA NOVA LISTA, JA CONVERTENDO O CONTEUDO QUE ELA VAI RECEBER, PARA DEPOIS CONSEGUIR IMPRIMIR ELA PARA O USUARIO
                                              #A FUNÇÃO DELA É MOSTRAR COM A FUNÇÃO LAMBDA, OS NUMEROS DA LISTA NUMEROS, ELEVADOS A ELE MESMO
print(f"Lista com o número elevado a ele mesmo = {quadrados}\n") #IMPRIMINDO O RESULTADO


# Exemplo 3
print("\n\nExemplo 3")
numeros  = list(range(0, 21)) #A VARIAVEL NUMEROS VAI RECEBER UMA LISTA, COM A FUNÇÃO RANGE, LISTANDO DO ZERO AO VINTE
                              #LEMBRE-SE, A FUNÇÃO RANGE CRIA SEQUENCIAS NUMERICAS, BASTA COLOCAR COMO PARAMETRO DE ENTRADA DA ONDE ATÉ QUANTO
                              #NO EXEMPLO VAI DE 0 A 20, POIS O NUMERO SUPERIOR NAO FOI DEFINIDO
numeros_pares = list(filter(lambda x: x % 2 == 0, numeros)) #CRIAMOS UMA VARIAVEL PARA RECEBER NUMEROS PARES, SÓ QUE EM FORMATO DE LISTA
                                                            #O FILTER SERVER PARA FILTRARMOS QUALQUER INFORMAÇÃO DENTRO DE UMA VARIAL, QUE COM A UTILIZAÇÃO DA FUNÇÃO LAMBDA,
                                                            #DECRETAMOS QUE ELA MOSTRE OS NUMEROS PARES DA LISTA NUMEROS

print(numeros_pares)