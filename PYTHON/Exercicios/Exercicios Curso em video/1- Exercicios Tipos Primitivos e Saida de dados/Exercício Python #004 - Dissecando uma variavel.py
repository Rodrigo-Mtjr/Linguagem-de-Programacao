a = input('Digite algo: ')
print('O tipo primitivo desse valor é ', type(a))
print('Só tem espaços?', a.isspace())
print('É um numero?', a.isnumeric())
print('É alfabético?', a.isalpha())
print('É alfanumerico?', a.isalnum())
print('Esta em maisculas?', a.upper())
print('Esta em minusculas?', a.lower())
print('Esta capitalizada?', a.istitle())