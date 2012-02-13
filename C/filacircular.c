#include <stdio.h>

	int filac[10];
	int cont = 0; // conta o numero de elementos inseridos
	int cabeca = 0;
	int cauda = 0;

	void enqueue(int num){
		cont++;

		filac[cauda] = num;
		if(cauda == 9){
			cauda = 0;
		}else{
			cauda++;
		}
	}

	int dequeue(){
		int tmp;

		tmp = filac[cabeca];
		cont--;

		if (cabeca == 9){
			cabeca = 0;
		}else{
			cabeca++;
		}
		return tmp;
	}



main(){
	int i;

	enqueue(10);
	enqueue(11);
	enqueue(12);
	enqueue(13);
	enqueue(14);
	enqueue(15);
	enqueue(16);
	enqueue(17);
	enqueue(18);
	enqueue(19);


	
	for (i = cabeca; i < cont; i++){
		printf("%d\n ", filac[i]);
	}
	
	printf ("\n dequeue: %d\n", dequeue());

	for (i = cabeca; i <= cont; i++){
		printf("%d \n", filac[i]);
	}

}
