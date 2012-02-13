#include  <stdio.h>

int pilha[10] = {0,1,2,3,4,5,6,7,8,9};
int topo = 0;

//retorna 1 para vazia;
int vazia(){
	return (topo == 0);
}

//retorna 1 para cheia;
int cheia(){
	return (topo == 9);
}

void push(int num){
	if (cheia()){
		printf ("cheia\n");
	}else{
		pilha[topo + 1] = num;
		topo++;
	}
}

int pop(){
	if (vazia()){
		printf("vazia\n");
		return -1;
	}else{
		topo--;
		return (pilha[topo+1]);
	}
}

int peek(){
	if (vazia()){
		printf ("vazia\n");
		return -1;
	}else{
		return pilha[topo];
	}
}

int main(){
	printf ("retorna 0 para nao vazia e 1 para vazia: ");
	printf ("%d \n", vazia());

	push (999);
	push (666);

	printf ("%d - peek \n", peek());
	printf ("%d - pop \n", pop());
	printf ("%d - peek \n", peek());

	push(100);
	printf ("%d - peek \n", peek());
	printf ("%d - pop \n", pop());
}
