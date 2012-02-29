#include <stdio.h>

int troca(int *a)
{
	a = 1000;
	return a;
}

void main()
{
	int *a;
	int b;

	a = &b;
	
	printf ("%d", troca(a));
}
