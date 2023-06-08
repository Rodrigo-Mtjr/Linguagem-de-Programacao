#include <stdio.h>

int numero;
char nome[200];
char rua[200];

int main(void){
	
	printf("Digite o seu nome: \n");
	scanf("%s", &nome);
	
	printf("Digite a sua rua: \n");
	scanf("%s", &rua);
	
	printf("Digite o numero da casa: \n");
	scanf("%d", &numero);
	
	printf("\n NOME: %s \n", nome);
	printf("\n RUA: %s \n", rua);
	printf("\n NUMERO DA CASA: %d \n", numero);
}
