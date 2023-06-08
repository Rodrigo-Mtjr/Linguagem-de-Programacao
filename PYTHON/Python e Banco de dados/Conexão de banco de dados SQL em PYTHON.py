import sqlite3 #importando o modulo SQLITE3

conn = sqlite3.connect('aulaDB.db') #instanciando a variavel conn, dizendo que ela é um objeto da classe connection
print(type(conn))

