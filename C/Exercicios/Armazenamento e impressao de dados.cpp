#include <stdio.h>

int main() {
	
	char nome[200];
	int idade = 0;
	char endereco[200];
	
	printf("\n Digite o seu nome: ");
	scanf("%s", &nome);
	
	printf("\n Digite a sua idade: ");
	scanf("%d", &idade);
	
	printf("\n Digite o seu endereço: ");
	scanf("%s", &endereco);
	
	printf("\n o seu nome e: %s", nome);
	printf("\n a sua idade e: %d", idade);
	printf("\n e voce mora na rua: %s", endereco);
	
}
