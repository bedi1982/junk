#include <stdio.h>

int dig1(){


	char    cpf[9] =  { 1, 1, 1, 4, 4, 4, 7, 7, 7 };
	int compare[9] = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
	int i;
	int tot = 0;

	for (i = 0; i < 9; i++){
		tot = ((( cpf[i] * compare[i])) + tot);
	}

	if ((tot % 11) < 2){
		i = 0;
	} else {
		i = (11 - (tot % 11));
	}

	return i;
}

int dig2(){
	char    cpf[10] =  { 1, 1, 1, 4, 4, 4, 7, 7, 7, 0 };	
	int compare[10] = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
	int i;
	int tot = 0;
	
	cpf[9] = dig1();
	
	for (i = 0; i < 10; i++){
		tot = ((( cpf[i] * compare[i])) + tot);
	}
	
	if ((tot % 11) < 2){
		i = 0;
	} else {
		i = (11 - (tot % 11));
	}

	return i;
}

int main()
{
	//char *cpf = "036811969"; Em andamento

	printf ("Digito 1: %d\n", dig1());
	printf ("Digito 2: %d\n", dig2());
	return 0;
}
