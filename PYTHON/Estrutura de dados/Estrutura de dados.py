#ESTRUTURA DE DADOS - SEQUENCIA DE CARACTERES
'''
texto = "Aprendendo Python na disciplina de linguagem de programação."

print(f"Tamanho do texto = {len(texto)}") #fazendo a contagem da quantidade de caracteres que existe dentro da frase

print(f"Hoje in texto = {'Hoje' in texto}") #saber se a palavra python está dentro do texto

print(f"Quantidade de y no texto = {texto.count('y')}") #contando quantos y tem dentro da sequencia de caracteres

print(f"As 5 primeiras letras são: {texto[0:6]}") #imprimindo os caracteres da posição 0 a 6

print(texto.upper()) #mudando a frase para letras maiusculas

print(texto.lower()) #mudando a frase para letras minusculas

print(texto.replace("i", 'XX')) #a função replace muda um caractere pelo outro, primeiro selecionamos o caractere que existe e depois colocamos para qual vamos trocar.
#--------------------------------------------------------------------------------------------------------------------------------------------------------------------------]
'''

'''
texto = "Aprendendo python na disciplina de linguagem de programação." #criando uma variavel
print(f"texto = {texto}") #imprimindo para o usuario a palavra texto e depois tudo o que está dentro da variavel texto
print(f"tamanho do texto = {len(texto)}") #mostrando o tamanho da variavel texto

palavras = texto.split() #definindo uma variavel com a outra variavel ja criada, mas agora, salvando em cada linha dela as palavras separadas por espaço no texto.
print(f"Palavra = {palavras}") #imprimindo a variavel palavra, com todas as palavras salvas dentro dela
print(f"Tamanho de palavras = {len(palavras)}") #mostrando o tamanho da variavel palavra
'''
#--------------------------------------------------------------------------------------------------------------------------------------------------------------------------]

texto = """Operadores de String
Python oferece operadores para processar texto (ou seja, valores de string).
Assim como os números, as strings podem ser comparadas usando operadores de comparação:
==, !=, <, > e assim por diante.
O operador ==, por exemplo, retorna True se as strings nos dois lados do operador tiverem o mesmo valor (Perkovic, p. 23, 2016).
"""

print(f"Tamanho do texto = {len(texto)}") #pedindo para que some a quantidade de caracterer dentro da frase
texto = texto.lower() #transformando a frase com todos os caracteres em minusculo
texto = texto.replace(",", "").replace(".", "").replace("(", "").replace(")", "").replace("\n", " ") #tirando todos os ponto, parenteses, virgulas e quebra de linha, para que o processo de split nao seja interferiudo
palavras = texto.split() #salvando dentro da variavel palavras todas as palavras separadas por um espaço em branco, pois na função anterior, tiramos todos os pontos e virgulas.
print(f"quantidade de palavras = {len(palavras)}") #imprindo agora o tamanho da variavel palavra

total = palavras.count("string") + palavras.count("strings") #somando dentro do texto, todas as palavras string e strings
print(f"A quantidade de vezes que as palavras strings e string apareceram foi = {total}") #mostrando o resultado da soma
