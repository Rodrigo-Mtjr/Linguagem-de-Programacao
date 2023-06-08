#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
int main(){
	
	char nome[30];
	int i;
	
	printf("Digite o sobrenome do aluno ou aluna: \n");
	gets(nome);
	for (i=0; nome[i] != ' '; i++);
	nome[i] = tolower(nome[i]);
	printf("\n\n sobrenome convertido: %s ", nome);
	
	
	return 0;
}
