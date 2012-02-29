#include <stdio.h>

int pointer(int *a)
{
	*a = 100;
	printf ("Pointer: %d\n", *a);
}

int soma(int a)
{
	return a + 2;
}

main()
{
	int *a;
	int *c;
	int b;

	b = 2;
	a = &b;
	*c = 3;

	pointer(a);

	printf ("Soma: %d",soma(*a));
}
