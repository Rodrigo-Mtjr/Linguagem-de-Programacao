#READ

import sqlite3 #importando o modulo sqlite3

conn = sqlite3.connect('aulaDB.db') #instanciando a variavel conn, dizendo que ela vai ser uma objeto da classe connect
cursor = conn.cursor() #criando uma ponte entre banco de dados e python com um cursor

cursor.execute('SELECT * FROM fornecedor') #executando o metodo execute() dentro do cursor para que ele puxe todas as inforamções da tabela fornecedor
resultado = cursor.fetchall()#guardando o resultado da função acima, dentro de uma variavel, com o metodo fetchall()

print('Descrição do cursor: ', cursor.description)
print('Linhas afetadas: ', cursor.rowcount)

resultado[:2]

for linha in resultado:
    print(linha)


print('\nSELECT COM WHERE')
cursor.execute('SELECT * FROM fornecedor WHERE id_fornecedor = 5') #utilizando o metedo e colocando uma função WHERE para informações mais filtradas
resultado = cursor.fetchall() #guardando o resultado do execute() dentro da variavel resultado
print(resultado) #imprimindo na tela

cursor.close() #fechando o cursor
conn.close() #fechando a conexão