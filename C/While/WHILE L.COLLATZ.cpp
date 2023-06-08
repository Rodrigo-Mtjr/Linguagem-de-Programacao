#include <stdio.h>
int main(){
	
	int num, i;
	
	printf("\n DIGITE UM NUMERO PARA O PROBLEMA DE L. COLLATZ: ");
	scanf("%d", &num);
	i=0;
	
	while (num>1){
		if(num%2 == 0)
		num=num/2;
		else 
		num=3*num+1;
		printf("\n %d", num);
		
		i++;
	}
	return 0;
}
