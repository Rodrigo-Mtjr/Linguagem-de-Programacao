import sqlite3

conn = sqlite3.connect('aulaDB.db')
print(type(conn))

ddl_create = """
CREATE TABLE fornecedor (
    id_fornecedor INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome_fornecedor TEXT NOT NULL,
    cnpj VARCHAR(18) NOT NULL,
    cidade TEXT, 
    estado VARCHAR(2) NOT NULL,
    cep VARCHAR(9) NOT NULL,
    data_cadastro DATE NOT NULL
);
"""

cursor = conn.cursor() #criando um objeto cursor, que vai ser a ponte para a conexão do python e o banco de dados
cursor.execute(ddl_create) #invocando o metodo execute() no cursor para criar uma tabela dentro da variavel ddl_create, utilizando ela de parametro
print(type(cursor))

print("Tabela criada!")
print("Descrição do cursor: ", cursor.description)#informações sobre a execução
print("Linhas afetadas: ", cursor.rowcount) #quantas linhas foram afetadas
#todo cursor e toda conexão, após executarem suas tarefas, precisam ser fechadas pelo metodo close()
cursor.close()
conn.close()