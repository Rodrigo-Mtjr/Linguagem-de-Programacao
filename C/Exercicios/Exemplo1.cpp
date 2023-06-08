#include <stdio.h>
void inserir(int a[]){
	int i= 0;
	for(i=0; i<3; i++){
		printf("Digite o valor %d: ", i);
		scanf("%d", &a[i]);
	}
}

void imprimir(int b[]){
	int i = 0;
	for(i=0; i<3; i++){
		printf("\n numeros[%d] = %d", i,2*b[i]);
	}
}

int main(){
	int numeros[3];
	printf("\n Preenchendo o vetor... \n");
	inserir(numeros);
	printf("\n Dobro dos valores informados: ");
	imprimir(numeros);
	return 0
}
