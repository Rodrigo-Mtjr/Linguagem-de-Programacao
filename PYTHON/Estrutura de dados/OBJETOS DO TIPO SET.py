''''Um objeto do tipo set habilita operações matemáticas de conjuntos, tais como: união, intersecção, diferenteça, etc.'''
'''Esse tipo de estrutura pode ser usado, portanto, em testes de associação e remoção de valores duplicados de uma sequência '''

'''Em Python, os objetos do tipo set podem ser construídos destas maneiras:

Usando um par de chaves e elementos separados por vírgulas: set1 = {'a', 'b', 'c'}
Usando o construtor de tipo: set(iterable)'''

# EXEMPLOS1
vogais_1 = {'aeiou'} # sem uso do construtor
print(type(vogais_1), vogais_1) #PRINTANDO DOIS TIPOS DE INFORMAÇÃO NA MESMA LINHA, O TIPO E O QUE ESTÁ DENTRO DA VARIAVEL

vogais_2 = set('aeiouaaaaaa') #CONSTRUTOR COM STRING, ELE ELIMINA OS VALORES DUPLICADOS
print(type(vogais_2), vogais_2)

vogais_3 = set(['a', 'e', 'i', 'o', 'u']) #CONSTRUTOR COM LISTA
print(type(vogais_3), vogais_3)

vogais_4 = set(('a', 'e', 'i', 'o', 'u')) #CONSTRUTOR COM TUPLA
print(type(vogais_4), vogais_4)

print(set('banana')) #REMOVE OS VALORES DUPLICADOS