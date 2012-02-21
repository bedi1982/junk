#include <stdio.h>

int pointer(int *a)
{
	printf ("Pointer: %p\n", a);
}

int soma(int a)
{
	return a + 2;
}

main()
{
	int *a;
	int b;

	b = 2;
	a = &b;
	
	pointer(a);

	printf ("Soma: %d",soma(*a));
}
