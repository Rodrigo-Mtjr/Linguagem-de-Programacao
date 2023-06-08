def calcular_valor(valor_prdt, qtde, moeda=None,desconto=None, acrescimo=None):
    v_bruto = valor_prdt * qtde

    if desconto:
        v_liquido = v_bruto - (v_bruto * (desconto/100))
    elif acrescimo:
        v_liquido = v_bruto + (v_bruto * (acrescimo/100))
    else:
        v_liquido = v_bruto

    if moeda == 'real':
        return v_liquido
    elif moeda == 'dolar':
        return v_liquido * 5
    elif moeda == 'euro':
        return v_liquido * 5.7
    else:
        print("Moeda não cadastrada!")
        return 0
#fim da função


valor_a_pagar = calcular_valor(valor_prdt=32, moeda= "real",qtde= 5, acrescimo=10)
print(f"O valor final da conta é {valor_a_pagar}")

#outro exemplo para a mesma função, usando o kwargs

def calcular_valor(valor_prod, qtde, moeda="real", **kwargs):
    v_bruto = valor_prod * qtde

    if 'desconto' in kwargs:
        desconto = kwargs['desconto']
        v_liquido = v_bruto - (v_bruto * (desconto / 100))
    elif 'acrescimo' in kwargs:
        acrescimo = kwargs['acrescimo']
        v_liquido = v_bruto + (v_bruto * (acrescimo / 100))
    else:
        v_liquido = v_bruto

    if moeda == 'real':
        return v_liquido
    elif moeda == 'dolar':
        return v_liquido * 5
    elif moeda == 'euro':
        return v_liquido * 5.7
    else:
        print("Moeda não cadastrada!")
        return 0


valor_a_pagar = calcular_valor(valor_prod=32, qtde=5, desconto=5)
print(f"O valor final da conta é {valor_a_pagar}")