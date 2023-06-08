#CRIAÇÃO DO BANCO DE DADOS COM METODOS PARA DDL

import sqlite3 #importando o modulo

class DDLSQLite: #criando uma classe com metodos para conectar um banco de dados
    def _conectar(self,nome_banco): #definindo os parametros de entrada para ela ser valida
        nome_banco = nome_banco + '.db' #concatentando o nome do banco no parametro com a sigla db
        conn = sqlite3.connect(nome_banco) #instanciando a variavel conn, dizendo que ela é um objeto do tipo connect
        return conn #retornando o resultado

        #O metodo de cima foi para conectar o python com o banco de dados

    def criar_banco_de_dados(self, nome_banco): #criando um metodo com parametros
        nome_banco += '.db' #concatenando o nome do banco com a sigla db
        sqlite3.connect(nome_banco).close() #fechando o procedimento depois de criado, com a função close
        print('O banco de dados {} foi criado com sucesso'.format(nome_banco)) #printando na tela para ver se deu certo
        return None

        #o metodo de cima foi feito para criarmos um banco de dados

    def criar_tabela(self, nome_banco, ddl_create): #criando um metodo para criar uma tabela, com parametros de entrada nome do banco e a ddl
        conn = self._conectar(nome_banco) #instanciando a variavel conn, dizendo que ela vai receber o parametro de entrada do metodo conectar e só vai funcionar se ele existir
        cursor = conn.cursor() #fazendo a ponte entre tabela e python com um cursor
        cursor.execute(ddl_create) #pedindo para executar a ddl_create, que é o comando para criar uma tabela
        cursor.close() #finalizando esse cursor
        conn.close() #finalizando a conexão
        print("Tabela criada com sucesso!")
        return None

        #o metodo de cima foi feito para criarmos uma tabela

    def apagar_tabela(self, nome_banco, tabela):
        conn = self._conectar(nome_banco) #server para conectar no banco que existe a tabela para a exclusão
        cursor = conn.cursor() #criando um cursor, uma ponte
        cursor.execute('DROP TABLE {}'.format(tabela)) #executando o metodo execute para que ele faça um DROP TABLE usando o parametro de entrada tabela
        cursor.close() #finalizando o cursor
        conn.close() #finalizando a conexão
        print("A tabela {} foi excluída com sucesso!".format(tabela))
        return None

        #o metodo de cima foi feito para apagar uma tabela



#CRIAÇÃO DE CLASSES PARA CRUD

class CrudSQlite:
    def __init__(self, nome_banco): #criando um metodo construtor para usar em outros metodos
        self.nome_banco = nome_banco + '.db'

    def _conectar(self): #metodo para conectar o banco
        conn = sqlite3.connect(self.nome_banco) #conn recebe a função connect com paramentro de entrada nome do banco, usada no metodo construtor
        return conn

    def inserir_registro(self, tabela, registro): #criando metodo para inserir dados na tabela utilizando parametros como a propria tabela e o registro
        colunas = tuple(registro.keys()) #a variavel coluna vai receber linhas de chaves
        valores = tuple(registro.values()) #a variavel valores vai receber em linhas os valores digitados

        conn = self._conectar() #instanciando a variavel com com o metodo conectar, pois só vai fazer a inserção de dados, se exister a tabela
        cursor = conn.cursor() #conectando o banco com o python
        query = 'INSERT INTO {} {} VALUES {}'.format(tabela, colunas, valores) #criando uma query para realizar os comandos de INSERT INTO utilizando os parametros de entrada na função
        cursor.execute(query) #executando a função dentro do metodo
        cursor.close() #Fechando a função depois de ser executada
        conn.close() #fechando a conexão
        print("Dados inseridos com sucesso!")
        return None

    def ler_registros(self, tabela): #criando um metodo para ler os registros
        conn = self._conectar() #conectando ele ao metodo conectar
        cursor = conn.cursor() #ponte entre banco e python
        query = f"""SELECT * FROM {tabela}""" #query para realizar o SELECT FROM
        cursor.execute(query) #executando a query
        resultado = cursor.fetchall() #colocando o resultado da query dentro de uma variavel, utilizando a função fetchall() de cursor. Pois como queremos mostrar algo, temos que salvar em algum lugar
        cursor.close()
        conn.close()
        return resultado

    def atualizar_registro(self, tabela, dado, condicao): #criando um metodo para fazer um updta(atualizar)
        campo_alterar = list(dado.key())[0] #a variavel campo_alterar vai receber uma lista de dados como parametro, que serao chaves
        valor_alterar = dado.get(campo_alterar) #a variavel valor alterar vai utilizar os valores salvos dentro da variavel campo_alterar, para saber qual ela tem que trocar
        campo_condicao = list(condicao.keys())[0] #a variavel campo_condição vai receber a lista salva no parametro condição
        valor_condicao = condicao.get(campo_condicao) #vai utilizar como parametro os valores dentro de campo_condição para saber qual alterar na função

        conn = self._conectar() #instanciando com o metodo conectar
        cursor = conn.cursor() #ponte de banco para python
        query = f"""UPDATE {tabela} SET {campo_alterar} = '{valor_alterar}' WHERE {campo_condicao} = {valor_condicao}""" #query para UPDATE
        conn.commit() #como a tabela sofreu alteração, temos que dar um commit para salvar essas alterações
        cursor.close() #fechando a ponte
        conn.close() #fechando a conexão
        print("Dado atualizado com sucesso!")
        return None

    def apagar_registro(self, tabela, condicao): #criando um metodo
        campo_condicao = list(condicao.keys())[0] #criando uma variavel para receber a lista como parametro condição
        valor_condicao = condicao.get(campo_condicao) #criando uma variavel para identificar qual sera o valor a ser modificado ou apagado
        conn = self._conectar() #conectando ao metodo conectar
        cursor = conn.cursor() #fazendo a ponte
        query = f"""DELETE FROM {tabela} WHERE {campo_condicao} = {valor_condicao}""" #criando a quere DELETE
        cursor.execute(query)
        conn.commit()
        cursor.close()
        conn.close()
        print("Dado excluído com sucesso!")
        return None


''''# instancia um objeto
objeto_ddl = DDLSQLite()

# Cria um banco de dados
objeto_ddl.criar_banco_de_dados('desafio')

# Cria uma tabela chamada cliente
ddl_create = """
CREATE TABLE cliente (
    id_cliente INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    nome_cliente TEXT NOT NULL,
    cpf VARCHAR(14) NOT NULL,
    email TEXT NOT NULL,
    telefone VARCHAR(15),
    cidade TEXT, 
    estado VARCHAR(2) NOT NULL,
    data_cadastro DATE NOT NULL
);
"""
objeto_ddl.criar_tabela(nome_banco='desafio', ddl_create=ddl_create)

# Caso precise excluir a tabela, o comando a seguir deverá ser usado
# objeto_ddl.apagar_tabela(nome_banco='desafio', tabela='cliente')'''



#Vamos fazer os testes do CRUD em duas etapas. Na primeira, vamos inserir registros e consultarmos para checar se a inserção deu certo.

objeto_dml = CrudSQlite(nome_banco='desafio')

#INSERIR REGISTROS
dados = [
    {
        'nome_cliente': 'João',
        'cpf': '111.111.111-11',
        'email': 'joao@servidor',
        'cidade': 'São Paulo',
        'estado': 'SP',
        'data_cadastro': '2020-01-01'
    },

    {
        'nome_cliente': 'Maria',
        'cpf': '222.222.222-22',
        'email': 'maria@servidor',
        'cidade': 'São Paulo',
        'estado': 'SP',
        'data_cadastro': '2020-01-01'
    },
]

# Para cada dicionário na lista de dados, invoca o método de inserção

'''for valor in dados:
    objeto_dml.inserir_registro(tabela='cliente', registro=valor)

# Carrega dados salvos

dados_carregador = objeto_dml.ler_registro(tabela='cliente')
for dados in dados_carregador:
    print(dados)'''

# Atualiza registro
dado_atualizar = {'telefone': '(11)1.1111-1111'}
condicao = {'id_cliente': 1}

objeto_dml.atualizar_registro(tabela='cliente', dado=dado_atualizar, condicao=condicao)

dados_carregados = objeto_dml.ler_registros(tabela='cliente')
for dado in dados_carregados:
    print(dado)

# Apaga registro
condicao = {'id_cliente': 1}

objeto_dml.apagar_registro(tabela='cliente', condicao=condicao)
