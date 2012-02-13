#include <stdio.h>

main()

{
	int i, j;
	int vetor[9] = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
	int matriz[3][3];

	for (i = 0;i < 3; i++) {
		for (j=0; j<3; j++){
			matriz[i][j] = vetor[i * 3 + j];
		}
	}

	for (i = 0; i < 3; i++){
		for (j = 0; j < 3; j++){
			printf("Matriz Linha %d Coluna %d: %d \n", i, j, matriz[i][j]);
		}
	}
}


