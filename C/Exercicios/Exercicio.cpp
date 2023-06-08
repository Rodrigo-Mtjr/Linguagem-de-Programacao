#include<stdio.h>

float calcularInvestimento(float valor, char plano, int meses){
	if((plano =='A' || plano =='a') && meses >= 24){
		return valor * 0.02 * meses;
	}else{
		printf("\n Dados invalidos!");
		return 0;
	}
	if((plano =='B' || plano =='b') && meses >=12) {
		return valor * 0.008 * meses;
	}else{
		printf("\n Dados invalidos!");
		return 0;
	}
}

int main(){
	float valorInv = 0;
	float rendimento = 0;
	char plano;
	int tempo = 0;
	
	printf("\n Digite o plano: ");
	scanf("%c",&plano);
 	printf("\n Digite o valor a ser inves tido: ");
 	scanf("%f",&valorInv);
	printf("\n Digite o tempo para resgate: ");
	scanf("%d",&tempo);
 	rendimento = calcularInvestimento(valorInv, plano, tempo);
 	printf("\n Seu rendimento sera = %.2f",rendimento);
 return 0;
}
