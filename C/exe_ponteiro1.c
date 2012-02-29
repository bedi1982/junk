#include <time.h>
#include <stdio.h>

//Elabore um programa que armazene valores aleatórios em um vetor de 
//inteiros de 10 posições e depois, em outro vetor de ponteiros de inteiros
//de tamanho 10, coloque os endereços dos valores do vetor de inteiros de
//forma ordenada crescente, ficando a primeira posição do vetor de 
//ponteiros com o endereço do menor valor até a última posição que 
//conterá o endereço do maior valor.

int main()
{
	int inteiros[9];
	int *enderecos[9];
	int i,j;
	int *tmp;

	srand ( time(NULL) );
	
	for(i=0; i<10; i++){
		inteiros[i] = rand()%100;
	}
	
	for(i=0; i<10; i++){
		enderecos[i] = &inteiros[i];
	}
	
	printf("Antes de ordenar:\n");

	for(i=0; i<10; i++){
		printf ("Endereco: %p Valor nele: %d \n", enderecos[i], *enderecos[i]);
	}

	for(i=0; i<10; i++){
		for(j=0; j<9; j++){
			if(*enderecos[j] > *enderecos[j+1]){
				tmp = enderecos[j];
				enderecos[j] = enderecos[j+1];
				enderecos[j+1] = tmp;
			}
		}
	}

	printf("depois de ordenar:\n");

	for(i=0; i<10; i++){
		printf ("Endereco: %p Valor nele: %d \n", enderecos[i], *enderecos[i]);
	}

}
