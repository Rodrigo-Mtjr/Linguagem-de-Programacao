#include <stdio.h>

int main() {
	
	float orcamento;
	
	
	printf ("Digite o valor do orcamento para viagem \n");
	scanf("%f", &orcamento);
	
	if (orcamento >= 10000){
		
		printf("\n Joao e Maria possuem orcamento para uma viagem internacional, pois seu orcamento e de %f", orcamento);		
	}
	else {
		printf("\n Joao e maria irao optar por uma viagem nacional, seu orcamento ficou em %f", orcamento);				
		
	}
	
	return 0;
	
}
