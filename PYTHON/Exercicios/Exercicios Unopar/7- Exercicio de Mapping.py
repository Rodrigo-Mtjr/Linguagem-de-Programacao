cadastro = {
            'nome' : ['João', 'Ana', 'Pedro', 'Marcela'],
            'cidade': ['São Paulo', 'São Paulo', 'Rio de Janeiro', 'Curitiba'],
            'idade' : [25, 33, 37, 18]
}
#DEFINIMOS UM DICIONARIO, COM AS CHAVES : NOME, CIDADE E IDADE, E SEUS VALORES DENTRO DELAS, EM COLCHETES


print("len(Cadastro)", len(cadastro)) #PEDIMOS PARA QUE CONTASSE A VARIAVEL CADASTRO, QUE TEM QUE DAR 3, POIS ELE CONTA AS CHAVES

print("\n cadastro.keys() = \n", cadastro.keys()) #AQUI ELE MOSTRA QUAIS SAO AS CHAVES EXISTENTES
print("\n cadastro.values() = \n", cadastro.values()) #AQUI MOSTRA OS VALORES DENTRO DE CADA CHAVE, SEPARANDO ELAS POR COLCHETES
print("\n cadastro.items() = \n", cadastro.items()) #E AQUI MOSTRA CADA ITEM DENTRO DE CADA CHAVE

print("\n cadastro['nome'] = ", cadastro['nome']) #AQUI ESTA PEDINDO PARA IMPRIMIR OS VALORES NOME
print("\n cadastro['nome'][2] = ", cadastro['nome'][2]) #AQUI ESTA PEDINDO PARA IMPRIMIR O VALOR NOME NA POSIÇAO 2, LEMBRANDO QUE COMEÇA POR 0
print("\n cadastro['idade'][2:] = ", cadastro['idade'][2:]) #AQUI ESTA PEDINDO PARA IMPRIMIR OS VALORES DA IDADE DA POSIÇÃO 2 EM DIANTE

#CONTANDO A QUANTIDADE DE ELEMENTOS EM CADA CHAVE
print(len(cadastro['nome']))
print(len(cadastro['cidade']))
print(len(cadastro['idade']))

qtde_itens = sum([len(cadastro[chave]) for chave in cadastro])

print(f"\n\nQuantidade de elementos no dicionário = {qtde_itens}")