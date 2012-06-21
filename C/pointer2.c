#include <stdio.h>

int pointer(int *a) //recebe o endereço de a
{
	return *a + 10; //retorna o valor no endereco *a + 10
}

int soma(int a)
{
	return a + 2;
}

int main()
{
	int *a;
	int b;

	b = 2;
	a = &b;
	
	printf("%d\n", pointer(a));

	printf ("Soma: %d\n",soma(*a));

	return 0;
}
