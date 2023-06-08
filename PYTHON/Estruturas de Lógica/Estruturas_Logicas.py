
qtde_faltas = int(input("Digite a quantidade de faltas: "))
media_final = float(input("Digite a media final: "))

#em vez de abrirmos outra variavel para modificar ela para int ou float,
#colocamos essa modificação dentro da propria variavel junto com o input
#input faz com que o usuario escreva o que esta sendo pedido e faz com que
#o sistema armazene dentro da variavel, mas pra isso, precisamos alterar o estilo
#dessa varivael, pois a mesma vai ser salva como STRING.

if qtde_faltas <= 5 and media_final >= 7:
    print("Aluno aprovado!")
else:
    print("Aluno Reprovado!")

exemplos

A = 15
B = 9
C = 9

print (B == C or A < B and A < C)
print ((B == C or A < B) and A < C)

