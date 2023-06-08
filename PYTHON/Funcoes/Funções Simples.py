def imprimir_mensagem(disciplina, curso):
    #return f'Essa é a primeira função que estamos criando no curso de {curso}, na aula de {disciplina}!'

mensagem = imprimir_mensagem('Python','Analise e desenvolvimento de sistema')

print(mensagem)

#---------------------------------------------------------------------------------------------------------------
def calcular_media(n1, n2, n3):
    media = (n1+n2+n3)/3
    return media

media_aluno = calcular_media(5.5,6.6,7.7)
print(media_aluno)

if media_aluno < 5.0:
    print("Aluno reprovado!")
else:
    print("Aluno Aprovado!!")
