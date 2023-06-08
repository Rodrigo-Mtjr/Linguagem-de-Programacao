class ContaCorrente: #CLASSE PAI
    def __init__(self, nome):
        self.nome = nome
        self.email = None
        self.telefone = None
        self._saldo = 0 #ESSE ATRIBUTO SE ENCONTRA COMO PRIVADO, POIS ESTA COM PONTO E UNDERLINE NO INICIO DO SEU NOME

    def _checar_saldo(self, valor): #ESSE METODO TAMBEM SE ENCONTRA COMO PRIVADO, POIS TEM UM UNDERLINE NO INICIO DO SEU NOME
        return self._saldo >= valor #E ELE SÓ VAI FUNCIONAR SE EXISTIR SALDO MAIOR QUE O VALOR DIGITADO COMO PARAMETRO DE ENTRADA

    def depositar(self, valor):
        self._saldo += valor

    def sacar(self, valor):
        if self._checar_saldo(valor): #UMA CONDIÇÃO PARA FUNCIONAR ESSE METODO, POIS SÓ VAI CONSEGUIR SACAR, SE EXISITIR VALOR DENTRO DO METODO CHECAR SALDO
            self._saldo -= valor #SE FOR VERDADEIRO, ELE VAI RETIRAR O VALOR COMO PARAMETRO DE ENTRADA, DO SALDO EXISTENTE EM CONTA
            return True #E RETORNAR O VALOR TRUE
        else:
            return False #CASO AO CONTRARIO, ELE RETORNA O VALOR FALSE

    def obter_saldo(self):
        return self._saldo


class ContaPF(ContaCorrente): #CLASSE FILHA, QUE VAI HERDAR ATRIBUTOS E METODOS DA CLASSE PAI.
    def __init__(self, nome, cpf): #DEFININDO COM UNIT OS VALORES, QUE SÓ PODE INICIAR COM NOME E CPF PARA FUNCIONAR
        super().__init__(nome) #DIZENDO QUE O ATRIBUTO NOME, VAI SER O MESMO QUE DA VARIAVEL PAI, POIS ISSO UM SUPER() NO COMEÇO DO ATRIBUTO
        self.cpf = cpf #ATRIBUTO NOVO, SÓ EXISTENTE PARA PESSOA FISICA

    def solicitar_emprestimo(self, valor): #METODO NOVO, SÓ EXISTENTE PARA PESSOA FISICA
        return self.obter_saldo() >= 500 #


class ContaPJ(ContaCorrente):
    def __init__(self, nome, cnpj):
        super().__init__(nome)
        self.cnpj = cnpj

    def sacar_emprestimo(self, valor):
        return valor <= 5000


conta_pf1 = ContaPF("João", '111.111.111-11')
conta_pf1.depositar(1000)
print(f'Saldo atual de {conta_pf1.nome} é: ', conta_pf1.obter_saldo())
print('Receberá empréstimo = ', conta_pf1.solicitar_emprestimo(2000))

conta_pf1.sacar(800)
print(f'Saldo atual de {conta_pf1.nome} é: ', conta_pf1.obter_saldo())
print('Receberá empréstimo = ', conta_pf1.solicitar_emprestimo(2000))

conta_pj1 = ContaPJ("Empresa A", "11.111.111/1111-11")
print('Saldo atual é', conta_pj1.obter_saldo())
print('Receberá empréstimo = ', conta_pj1.sacar_emprestimo(3000))
