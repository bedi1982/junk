//3. Faça um programa onde um vetor de ponteiros tenha cada uma das suas
// posições apontando para as equivalentes de um vetor de valores float. 
// A posição 0 do vetor ponteiro deve apontar para a posicao 0 do vetor 
// float e assim por diante.
//Exercicio pego em: http://www3.di.ufpb.br/liliane/aulas/ponteiros.html//

#include <stdio.h>
#include <stdio.h>

main()
{
	float *ponteiros[10];
	float floats[10];
	int i;
	
	//Popular o vetor de float//
	srand ( time(NULL) );
	for(i=0; i<10; i++){
		floats[i] = rand()%100;
	}

	for(i=0; i<10; i++){
		ponteiros[i] = &floats[i];
	}
	
	for(i=0; i<10; i++){
		printf("Valor no vetor de float[%d]: %f\n", i, floats[i]);
		printf("Valor no vetor de point[%d]: %f\n\n", i, *ponteiros[i]);
	}	
}
