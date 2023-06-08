#include <stdio.h>
#include <stdlib.h>

int main(){
	
	int a, b, c;
	 
	printf("Classificacao do triangulo");
	printf("\n Digite o tamanho do primeiro lado: ");
	scanf("%d", &a);
	
	printf("\n Digite o tamanho do segundo lado: ");
	scanf("%d", &b);
	
	printf("\n Digite o tamanho do terceiro lado: ");
	scanf("%d", &c);
	
	if (a < b + c && b < a + c && c < a + b){
		printf("\n dadas as medidas: %d, %d, %d temos um triangulo", a, b, c);

	}
	
		if (a == b && a == c){
			printf("Este e um triangulo EQUILATERO! \n");
		}
		else 
		   if (a == b || a == c || b == c){
			printf ("este e um triangulo ISOSCELES! \n");				
			}
				else
				   printf("Este e um triangulo ESCALENO! \n");{
				}
					else
						prinf("As medidas fornecidas, %d, %d, %d nao formam um triangulo", a, b, c);{
					}
	return 0;				
}
