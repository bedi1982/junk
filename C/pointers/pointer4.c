#include <stdio.h>

main()
{
	int *a;
	int *b;

	a = 2;
	b = 2;

	printf ("%p", *a + *b);
}
