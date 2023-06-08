           #estrutura simples de condição
a = 5
b = 10

if a < b: #colocar dois pontos para abrir as condições
    print("A é menor do que B")
    r = a + b
    print(f"E a soma de A e B é de: {r}") #F ANTES DAS ASPAS PARA PUXAR A VARIAVEL DEPOIS ENTRE COLCHETES


           #estrura composta de condição

a = 10
b = 5

if a < b:
    print("a é menor do que b")
    r = a + b
    print(f"e a soma de A e B é de: {r}")
else:
    print("a é maior do que b")
    r = a - b
    print(f"e a subtração de A e B é de: {r}")

          #estruturas encadeadas

#dentro do python, não existe a função SWTIH..CASE, apenas a ELIF

codigo_compra = 5111

if codigo_compra == 5222:
    print("Compra à vista")
elif codigo_compra == 5333:
    print("Compra à prazo no boleto: ")
elif codigo_compra == 5444:
    print("Compra a prazo no cartão")
else:
    print("Codigo não cadastrado")