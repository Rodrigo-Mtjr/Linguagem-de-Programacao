#include <stdio.h>
int main(){
	
	int numero;
	int i;
	int posicao=0;
	int vetor[10];
	printf("Entre com o numero de ate 3 casas diferentes de zero, a ser procurado em um vetor de 10 posicoes: ");
	scanf("%d", &numero);
	
	for (i=0; i<10; i++){
		printf("\n Entre com o numero para a posicao %02d: ", i+1);
		scanf("%d", &vetor[i]);	
	}
	
	while (vetor[posicao] != numero){
		posicao++;
	}
	for (i=0; i<10; i++){
		printf("%03d", vetor[i]);
	}
	
	printf("\n ");
	for (i=0; i<posicao; i++){
		printf(" ");
	}
	printf("x");
	return 0;
}
