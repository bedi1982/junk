#include <stdio.h>

void bubble(char ordem, int *vetor, int n)
{
	int i,j,tmp;

	for (i = 0; i < n; i++) {
		for (j = 0; j < i; j++) {
			if ((ordem == 'c') ^ (vetor[i] > vetor[j])) {
				tmp = vetor[i];
				vetor[i] = vetor[j];
				vetor[j] = tmp;
			}
		}
	}
}


int main(int argc, char **argv)
{
	char ordem;
	int vetor[9];
	int i;

	printf ("Populemos o vetor, digite 9 numeros:\n");
	for (i = 0; i < 9; i++ ) {
		scanf ("%d", &vetor[i]);
	}

	if (argc > 1) {
		ordem = *argv[1];
	} else {
		printf ("Ordem (C)rescente ou (D)ecrescente?\n");
		scanf (" %c", &ordem);
	}

	printf("Ordenacao:\n");

	bubble(ordem, vetor, 9);

	for (i = 0; i < 9; i++) {
		printf ("%d\n", vetor[i]);
	}

	return  0;
}
