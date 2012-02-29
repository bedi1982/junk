#include <stdio.h>

int main(){

	int a;
	int *b; //ponteiro

	b = &a; //b recebe o endereco de a
	printf("O endereco de a na memoria eh %p \n", b);

	a = 100;

	printf ("O Valor contido no endereco de a(*b) mostrado acima eh %i \n", *b);

	printf ("E o 'a' proprimente dito vale %i \n", a);

	*b = 50;

	printf ("Vou mandar 50 para *b (*b = 50;), portando a devera valer 50, vejamos:\n");
	printf ("a = %i\n",a);

	return 0;
}
