#include <stdio.h>

int main() {
	
	float metragem1, metragem2, metragem3, resultado;
	int resp;
	
	metragem1 = 0;
	metragem2 = 0;
	metragem3 = 0;
	do
	{
		printf ("C A L C U L O   D E   M E T R O S   Q U A D R A D O S \n");
		
		printf ("\n Digite a primeira metragem do terreno: ");
		scanf("%f", &metragem1);
		
		printf ("\n Digite a segunda metragem do terreno: ");
		scanf("%f", &metragem2);
		
		resultado = (metragem1 * metragem2);
		printf("\n o terreno tem = %.2f M2 ", resultado);
		printf("\n Digite 1 para continuar ou 2 para sair \n");
		scanf("%d", &resp);
	}
	while (resp==1);
	return 0;
}
