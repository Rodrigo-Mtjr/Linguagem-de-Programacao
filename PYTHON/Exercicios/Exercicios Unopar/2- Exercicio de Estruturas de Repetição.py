#EXERCICIO DE ESTRUTURAS DE REPETIÇÃO


texto = """A inserção de comentários no código do programa é uma prática normal.
Em função disso, toda linguagem de programação tem alguma maneira de permitir que comentários sejam inseridos nos programas.
O objetivo é adicionar descrições em partes do código, seja para documentá-lo ou para adicionar uma descrição do algoritmo implementado (BANIN, p. 45, 2018)."""

x = 0
y = 0

for i, c in enumerate(texto):
    if c == 'a':
        x += 1
        print(f"Vogal {c} encontrada na posição {i}. Total de vogal encontrada {x}")

    elif c == 'e':
        y = y + 1
        print(f"Vogal {c} encontrada na posição {i}. Total de vogal encontrada {y}")
    else:
        continue



