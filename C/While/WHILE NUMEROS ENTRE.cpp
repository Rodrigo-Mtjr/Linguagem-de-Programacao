#include <stdio.h>

int main(void){
	
	char PARAR;
	int NUM;
	
		printf("\n Digite um numero: ");
		scanf("%d", &NUM);
	
	while ((getchar() != '\n') && (!EOF)); 
	
	if (NUM >= 10 && NUM <= 50){
		printf("O numero esta entre 10 e 50. \n");
	}
	else {
		printf("O numero nao esta entre 10 e 50. \n");
	}
	printf("\n");
	printf("Aperte <Enter> para parar... ");
	PARAR = getchar();
	
	return 0;
}
