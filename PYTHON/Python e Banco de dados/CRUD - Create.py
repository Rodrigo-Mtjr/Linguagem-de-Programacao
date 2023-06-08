#CREATE

'''Vamos começar inserindo registros na tabela fornecedor. Observe o código a seguir.'''

import sqlite3 #importando o modulo sqlite3

conn = sqlite3.connect('aulaDB.db') #instanciando a variavel conn, dizendo que ela é um objeto da classe connection
cursor = conn.cursor() #conectando o python com o banco de dados

#execuntando o metodod execute, para dar um insert into dentro da tabela para cada informação
cursor.execute(""" 
INSERT INTO fornecedor (nome_fornecedor, cnpj, cidade, estado, cep, data_cadastro)
VALUES ('Empresa A', '11.111.111/1111-11', 'São Paulo', 'SP', '11111-111', '2020-01-01')
""")

cursor.execute("""
INSERT INTO fornecedor (nome_fornecedor, cnpj, cidade, estado, cep, data_cadastro)
VALUES ('Empresa B', '22.222.222/2222-22', 'Rio de Janeiro', 'RJ', '22222-222', '2020-01-01')
""")

cursor.execute("""
INSERT INTO fornecedor (nome_fornecedor, cnpj, cidade, estado, cep, data_cadastro)
VALUES ('Empresa C', '33.333.333/3333-33', 'Curitiba', 'PR', '33333-333', '2020-01-01')
""")

conn.commit() #dando um commite para salvar as informações alteradas dentro do banco de dados



'''Uma maneira mais prática de inserir vários registros é passar uma lista de tuplas, na qual cada uma destas contém os dados a serem inseridos em uma linha. 
Nesse caso, teremos que usar o método executemany()  do cursor. Observe o código a seguir.'''


dados = [ #criando uma lista com 3 tuplas para fazer uma inserção mais pratica, que tambem da certo
    ('Empresa D', '44.444.444/4444-44', 'São Paulo', 'SP', '44444-444', '2020-01-01'),
    ('Empresa E', '55.555.555/5555-55', 'São Paulo', 'SP', '55555-555', '2020-01-01'),
    ('Empresa F', '66.666.666/6666-66', 'São Paulo', 'SP', '66666-666', '2020-01-01')
]
#para salvar as informações de cima, basta agora colocar dentro de cada coluna da tabela. Com o comando cursor.executemany
cursor.executemany("""
    INSERT INTO fornecedor (nome_fornecedor, cnpj, cidade, estado, cep, data_cadastro)
    VALUES (?, ?, ?, ?, ?, ?)""", dados) #lembre-se de colocar os ponto de interrogação, conforme a quantidade de colunas existentes dentro da tabela e depois, separado por uma virgula, dizer da onde vai tirar informação.


conn.commit() #salvando as alterações feitas dentro do banco de dados

print("Dados inseridos!")
print("Descrição do cursor: ", cursor.description)
print("Linhas afetadas: ", cursor.rowcount)
cursor.close()
conn.close()

