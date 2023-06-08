#include <stdio.h>
#include <stdlib.h>

struct listaProd{
	int codigo;
	char produto[30];
	struct listaProd* prox;
};

typedef struct listaProd Produtos;
Produtos* inicializar(void){
	return NULL;
}

Produtos* inserir (Produtos * 1, int i, char*nprod){
Produtos* novo = (Produtos*) malloc(sizeof(Produtos));

	novo -> codigo = i;
	novo -> produto = nprod;
	novo -> prox = 1;
	return novo;	
}

Produtos* retira (Produtos* 1, int v){
	Produtos* ant = NULL;
	Produtos* p = 1;
	while (p != NULL && p -> codigo != v){
		ant = p;
		p = p -> prox;
	}
	if (p == NULL){
		return 1;
	}		
	if (ant == NULL){
		1 = p -> prox;
	} else {
			ant -> prox = p -> prox;
	}
	return 1;
}

Produtos* busca(Produtos* 1, iint v){
	Produtos* p;
	for (p = 1; p != NULL; p = p -> prox){
		if (p -> codigo == v)
		return p;
	}
		return NULL;
}

int main(){
	int cont, codprod;
	char nprod[30];
	Produtos* listaProdutos;
	listaProdutos = incializar();
	
	for(cont = 0; cont < 3; cont++){
		printf("\n Informe o codigo do produto: ");
		scanf("%d", &codprod);
		printf("\n Informe o nome do produto: ")
		scanf("%s", &nprod);
		listaProdutos = inserir(listaProdutos, codprod, nprod);
	}
	
	printf("Lista produtos: \n");
	imprimir(listaProdutos);
	printf("\n Informe o codigo do produto para a pesquisa: ");
	scanf("%d", &codprod);
	if(busca(listaProdutos, codprod) == NULL){
		print("\n Produto nao encontrado");
	} else {
		printf("\n Produto encontrado");
	}
	printf ("\n"); system("PAUSE");
}
