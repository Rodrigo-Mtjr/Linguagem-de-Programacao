#Exercicios para calculo de imposto de renda sobra a folha

r = 's'
while r == 's':
 print("---------------------------------------------------------------------------------------")
 print("                                       BEM VINDO!")
 print("---------------------------------------------------------------------------------------")
 print("")
 print("AQUI VOCÊ PODERA CALCULAR O IMPOSTO DE RENDA E CALCULO DO INSS SOBRE FOLHA DE PAGAMENTO")
 print("")




 salariobruto = float(input("DIGITE O SALARIO BRUTO R$: "))
 salarioliquido = 0
 impostoIr = 0
 impostoInss = 0


 print("""         1 - CALCULO IMPOSTO DE RENDA
         2 - CALCULO DESCONTO INSS    """)
 escolhaCalculo = int(input("ESCOLHA QUAL DAS OPERAÇÕES ACIMA VOCÊ DESEJA FAZER: "))



 if escolhaCalculo == 1:

                         if salariobruto < 1903.98:
                             print("O funcionário está isento de imposto de renda!")

                         elif salariobruto <= 2826.65:
                             impostoIr = 142.80
                             salarioliquido = salariobruto - impostoIr
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoIr} de imposto de renda!")
                             print("A taxa para base de calculo foi 7,5%")

                         elif salariobruto <= 3751.05:
                             impostoIr = 354.80
                             salarioliquido = salariobruto - impostoIr
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoIr} de imposto de renda!")
                             print("A taxa para base de calculo foi 15%")

                         elif salariobruto <= 4664.68:
                             impostoIr = 636.13
                             salarioliquido = salariobruto - impostoIr
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoIr} de imposto de renda!")
                             print("A taxa para base de calculo foi 22%")

                         else:
                             impostoIr = (salariobruto * (27.5/100))
                             salarioliquido = 869.36
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoIr} de imposto de renda!")
                             print("A taxa para base de calculo foi 22%")


 elif escolhaCalculo == 2:
                            if salariobruto < 1302.00:
                             impostoInss = (salariobruto * (7.5/100))
                             salarioliquido = salariobruto - impostoInss
                             print("")
                             print( f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoInss} de INSS!")
                             print("A taxa para base de calculo foi 7%")

                            elif salariobruto < 2571.29:
                             impostoInss = (salariobruto * (9.0/100))
                             salarioliquido = salariobruto - impostoInss
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoInss} de INSS!")
                             print("A taxa para base de calculo foi 9%")

                            elif salariobruto < 3856.94:
                             impostoInss = (salariobruto * (12.0/100))
                             salarioliquido = salariobruto - impostoInss
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoInss} de INSS!")
                             print("A taxa para base de calculo foi 12%")

                            elif salariobruto < 7507.49:
                             impostoInss = (salariobruto * (14.0/100))
                             salarioliquido = salariobruto - impostoInss
                             print("")
                             print(f"O funcionário terá um salário liquido de R${salarioliquido}, e pagará o valor de R${impostoInss} de INSS!")
                             print("A taxa para base de calculo foi 14%")


 elif escolhaCalculo != 1 and escolhaCalculo != 2:
    print("FUNÇÃO NÃO CADASTRADA!!")
 print("")
 r = str(input("Deseja voltar ao menu? [S/N]"))
print("")
print("TENHA UM OTIMO DIA, ATÉ MAIS!!")