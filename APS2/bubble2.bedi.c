#include <stdio.h>

void bubble(char ordem, int *vetor, int n){

	int i,j,tmp;

	printf("Ordenacao:\n");

	switch (ordem){
		case  'd' :

			for (i = 0; i < n; i++){
				for (j = 0; j < i; j++){
					if (vetor[i] > vetor[j]){
						tmp = vetor[i];
						vetor[i] = vetor[j];
						vetor[j] = tmp;
					}
				}
			}
			break;

		default:

			for (i = 0; i < n; i++){
				for (j = 0; j < i; j++){
					if (vetor[i] < vetor[j]){
						tmp = vetor[i];
						vetor[i] = vetor[j];
						vetor[j] = tmp;
					}
				}
			}
			break;
	}




	for (i = 0; i < 9; i++){
		printf ("%d\n", vetor[i]);
	}
}


int main(){

	char ordem;
	int vetor[9];
	int i;

	printf ("Populemos o vetor, digite 9 numeros:\n");
	for (i = 0; i < 9; i++ ){
		scanf ("%d", &vetor[i]);
	}

	printf ("Ordem (C)rescente ou (D)ecrescente?\n");
	scanf (" %c", &ordem);
	bubble(ordem, vetor, 9);

	return  0;
}
