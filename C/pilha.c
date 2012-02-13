#include <stdio.h>

int pilha[10];
int topo = 0;

void push(int num){
	topo++;
	pilha[topo] = num;
}

int pop(){
	while(topo >= 1 ){
		topo--;
		return pilha[topo+1];
	}
}

int peek(){
	return pilha[topo];
}

int vazia(){
	if (topo == 0){
		return 1;
	}else{
		if( topo == 10){
			return 0;
		}
	}
}

int operacao(int num){
	int valor;

	switch(num){
		case 1:
			printf ("Valor?\n");
			scanf ("%d", &valor);
			push(valor);
			printf ("Posicao no indice: %d de 10\n", topo);
			break;
		case 2:
			printf ("Removido: %d\n", pop());
			printf ("Posicao no indice: %d de 10\n", topo);
			break;
		case 3:
			printf ("Numero no topo %d\n", peek());
			printf ("Posicao no indice: %d de 10\n", topo);
			break;
	}
}


int main(){

	int option;
	char esvaziar;

	if (vazia()){

		while (topo <= 10){
			printf ("Escolha:\n");
			printf ("1 - Inserir\n");
			printf ("2 - Remover\n");
			printf ("3 - Consultar\n");

			scanf("%d", &option);
			operacao(option);

			if(topo == 10){
				printf ("Pilha Cheia, esvaziar?\n");
				scanf(" %c", &esvaziar);

				if(esvaziar == 's'){
					topo = 0;
				}else{
					printf ("Saindo\n");
					topo = 11;
				}
			}else{
				if (topo == 0){
					printf ("Pilha vazia\n");
				}
			}
		}
	}else{
		return 0;
	}
}
