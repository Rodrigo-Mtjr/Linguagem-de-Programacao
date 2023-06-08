#include <stdio.h>

float calcular(){
	float num;
	printf("Digite um numero: ");
	scanf("%f", &num);
	return num*num;
}

int main(){
	
	float resultado = 0;
	resultado = calcular();
	printf("A potencia do numero digita e : %.2f", resultado);
	return 0;
}
