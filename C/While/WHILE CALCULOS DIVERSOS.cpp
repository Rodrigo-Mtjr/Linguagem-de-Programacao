#include <stdio.h>
#include <stdlib.h>

int main() {
	char  materila[60];
	float n, m, a;
	float raio, area, perimetro, pi;
	int opcao;
	do {
		
		printf("\t\n OPCOES DE CALCULOS");
		printf("\n 0. SAIR DO MENU");
		printf("\n 1. CALCULAR A FORCA");
		printf("\n 2. CALCULAR AREA E PERIMETRO DO CIRCULO");
		printf("\n 3. RETORNAR AO MENU");
		printf("\n OPCAO: ");
		scanf("%d", &opcao);
		switch(opcao){
			
			case 0: 
				printf("SAIR...\n");
				break;
				
			case 1:
				printf("\n DIGITE A MASSA DO OBJETO: ");
				scanf("%f", &m);
				printf("\n DIGITE A ACELERACAO: ");
				scanf("%f", &a);
				n = (m*a);
				printf("\n O CALCULO DA FORCA E :%.2F \n", n);
				break;
				
			case 2:
				printf("DIGITE O RAIO: ");
				scanf("%f", &raio);
				pi = 3.141592;
				area = pi * (raio * raio);
				perimetro = 2.0 * pi * raio;
				
				printf("\n RAIO: %.2f \n", raio);
				printf("\n AREA: %.2f \n", area);
				printf("\n PERIMETRO: %.2f \n", perimetro);
				break;
			
			case 3: system("cls");
				break;
			
			default:
				printf("\n OPCAO INVALIDA");		
		}
		
		
	} while(opcao);
	return 0;
	
}
