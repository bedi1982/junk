#include <stdio.h>

int lista[100];
int cabeca = 0;
int cauda = 0;

//Se verdadeiro ele retorna 1
int vazia(){
	return (cauda == 0);
}

//Se verdadeiro ele retorna 1
int cheia(){
	return (cauda == 9);
}

void inserecabeca (int num){
	int i;

	if (cheia()){
		printf ("cheia\n");
	}else{
		for (i = cauda; i > 0; i--){
			lista[i] = lista[i-1];
		}
		cauda++;
		lista[0] = num;
	}
}

void menorpratras(){
	int tmp, i,j;
	int menor;
	int indice;

	menor = lista[cabeca];

	for(i = cabeca; i < cauda; i++){
		if(lista[i] < menor){
			menor = lista[i];
			indice = i;
		}
	}

	tmp = lista[cauda - 1];
	lista[cauda - 1] = menor;
	lista[indice] = tmp;
}

void inserecauda (int num){
	int i;

	if (cheia()){
		printf ("cheia\n");
	}else{
		lista[cauda] = num;
		cauda++;
	}
}

void posespecifica(int pos, int num){
	int i;

	if (cheia()){
		printf("cheia");
	}else{
		for (i = cauda; i > pos; i--){
			lista[i] = lista[i-1];
		}
		cauda++;
		lista[pos] = num;
	}
}

void ordena(){
	int tmp, i,j;

	for (j = cabeca; j < cauda; j++){
		for (i = cabeca; i < cauda; i++){
			if (lista[i] > lista[i+1]){
				tmp = lista[i];
				lista[i] = lista[i+1];
				lista[i+1] = tmp;
			}
		}
	}
}

main(){
	int i;

	inserecabeca(2);
	inserecabeca(3);
	inserecabeca(23);
	inserecabeca(56);
	inserecabeca(0);
	inserecabeca(-1);
	inserecabeca(6);
	inserecabeca(7);
	inserecauda(100);
	menorpratras();
	ordena();

	for (i = 0; i < cauda; i++){
		printf("indice %d tem o valor %d\n", i, lista[i]);
	}
}
