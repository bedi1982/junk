#include <stdio.h>

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
	
	printf ("%d",soma(*a));
}
