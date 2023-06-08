#DELETE

import sqlite3 #importando o modulo

conn = sqlite3.connect('aulaDB.db') #criando um objeto conn com a classe connect
cursor = conn.cursor() #conectando o python com o sqlite3

cursor.execute("DELETE FROM fornecedor WHERE id_fornecedor = 2") #executando o delete dentro da tabela fornecedor
conn.commit() #utilizando o commit para salvar as alterações feitas

cursor.execute("SELECT * FROM fornecedor") #executando o select para visualizar as alterações
for linha in cursor.fetchall(): #para cada linha em cursor, salve ela dentro da variavel linha
    print(linha) #printando as linhas existentes dentro da tabela

cursor.close()
conn.close()