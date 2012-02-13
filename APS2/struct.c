#include <stdio.h>

struct user {
	char nome[50];
	int idade;
};


int main() {
	int i;

	struct user cadastro[3];

	for (i = 0; i < 3; i++){

		printf ("Insira seu nome:\n");
		scanf (" %s", &cadastro[i].nome);

		printf ("Insira sua idade\n");
		scanf ("%d", &cadastro[i].idade);
	}

	for (i = 0; i < 3; i++){
		printf ("Nome: %s \n", cadastro[i].nome);
		printf ("Idade: %d \n\n", cadastro[i].idade);
	}
	return 0;
}
