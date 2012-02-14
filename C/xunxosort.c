#include <stdio.h>

void mostravetor( int *vet, int tam){
	int i;

	for (i = 0; i < tam; i++){
		printf ("%d ", vet[i]);
	}
}

void dance(int *vet, int tam){
	int swap, i, j;
	for (j = tam - 1; j >= 0; j--){

		for (i = 0; i < j; i++){
			if (vet[i] > vet[i+1]){
				swap = vet[i];
				vet[i] = vet[i+1];
				vet[i+1] = swap;

			}
		mostravetor(vet, tam);
		printf ("\n");
		}


	}
}


int main(){
	int vet[10] = {10,9,8,7,6,5,4,3,2,1};
	int tam = 10;

	dance(vet, tam);

	return 0;
}
