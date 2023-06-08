#include <stdio.h>


int main() {
	float valor_bruto = 0;
	float valor_liquido = 0;
	float desconto = 0;
	int qtd_pessoas=0;
	
	
	printf("\n Digite o valor total da conta: ");
	scanf("%f", &valor_bruto);
	printf("\n Digite a quantidade de pessoas: ");
	scanf("%d", &qtd_pessoas);
	printf("\n Digite o valor do desconto: ");
	scanf("%f", &desconto);
	
	valor_liquido = valor_bruto - (valor_bruto * desconto/100);
	
	
	printf("\n valor da conta com desconto = %f",valor_liquido);
	printf("\n valor a ser pago por pessoa = %f",valor_liquido/qtd_pessoas);	
	
}
