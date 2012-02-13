#include <stdio.h>

int lista[10];
int cauda=0;
int cabeca=0;

int cheia(){
	return cauda == 10;
}

int vazia(){
	return cauda == -1;
}

void icauda(int num){
	if (!cheia()){
		lista[cauda] = num;
		cauda++;
	}
}

void icabeca(int num){
	int i;

	if (!cheia()){
		for (i = cauda; i > cabeca; i--){
			lista[i] = lista[i-1];
	}
		cauda++;
		lista[cabeca] = num;
	}
}

int compos(int num){
	int i;
	int pos = -1;

	for (i = cabeca; i < cauda; i++){
		if (lista[i] == num){
			pos = i;
			return pos;
		}
	}
}

int pares(){
	int i;
	int cont = 0;

	if (!cheia()){
		for (i = cauda; i > cabeca; i--){
			if ( lista[i]%2 == 0 ){
				cont++;
			}
		}
	}
		return cont;
}

main(){

	int i;

	icabeca(100);
	icabeca(100);
	icabeca(100);
	icabeca(100);
	icabeca(999);
	icabeca(100);
	icabeca(100);
	icauda(200);

	for (i = cabeca; i < cauda; i++){
		printf ("%i <- pos %i \n", lista[i], i);
	}

	printf ("%i <- pos 999\n", compos(999));
	printf ("%i <- pares deve ser 7\n", pares());
}
