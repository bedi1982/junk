#include <stdio.h>

int fila[10];
int cabeca = 0;
int cauda = 0;
int i;

void enqueue(int num){
	for (i = cauda; i > cabeca; i--){
		fila[i] = fila[i-1];
	}
	fila[cabeca] = num;
	cauda++;
	cabeca++;
}

int dequeue(){
	int tmp;
	tmp = fila[0];

	for (i = 0; i < cauda; i++){
		fila[i] = fila[i + 1];
	}
	cabeca--;
	cauda--;
	return tmp;
}


main(){

	enqueue(10);
	enqueue(20);
	enqueue(30);
	enqueue(40);
	printf ("dequeue - %d\n", dequeue());
	enqueue(1000);


	for (i = 0; i < cauda; i++){
		printf("%d", fila[i]);
	}
}

