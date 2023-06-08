#include <stdio.h>
#include <stdlib.h>
int main(int argc, char *argv[]){
	
	char cpf1[14];
	char cpf2[11];
	
	int i=0, n=0;
	printf("Digite seu cpf na forma NNN.NNN.NNN-NN: \n");
	scanf("%s", cpf1);
	
	for(i=0; i<14; i++){
		
		if(cpf1[i] ==' .' || cpf1[i]==' -'){
			continue;
		}
		else{
			cpf2[n] = cpf1[i];
				n++;
		}
	}
	printf("\n CPF FORMATADO = %s", cpf2);
	return 0;
}
