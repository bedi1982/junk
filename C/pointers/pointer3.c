#include <stdio.h>

int ponteiro(int *a) //Vai receber um ponteiro(em enderecço na memoria)
{
	printf ("Pointer(endereco de b): %p \n", a);
	printf ("Value in pointer + 2: %d \n", *a + 2);
	return 0;
}

main()
{
	int *a;
	int b = 2;

	a = &b; //  a recebe o endereço de b(a é um ponteiro pra lá);

	ponteiro(a); 	//Vai mandar o endereco de A porque A é um pointer
			// e a funcao ponteiro() espera um ponteiro
}
