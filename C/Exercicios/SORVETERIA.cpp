#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	int i;
	do{
	printf("\t\t S O R V E T E R I A   D O C E   M E L");
	printf("\n DIGITE O NUMERO DO SABOR: \n");
	printf("\t (1) SABOR FLOCOS \n");
	printf("\t (2) SABOR MORANGO \n");
	printf("\t (3) SABOR CHOCOLATE \n");
	printf("\t (4) SAIR DO MENU \n");
	printf("PODE DIGITAR: ");
	scanf("%d", &i);
		
}while ((i<1) || (i>4));

	switch(i){
		case 1:
		printf("\t VOCE ESCOLHEU O SABOR FLOCOS");
		printf("\t COM O VALOR DE R$10.00");
		break;
	
		case 2:
		printf("\t VOCE ESCOLHEU O SABOR MORANGO");
		printf("\t COM O VALOR DE R$8.00");
		break;	
	
		case 3:
		printf("\t VOCE ESCOLHEU O SABOR CHOCOLATE \n");
		printf("\t COM O VALOR DE R$8.00 \n");
		break;
	
		case 4:
		printf("OBRIGADO E ATE A PROXIMA");
		break;
	}
		
	return 0;	
}
	
	


