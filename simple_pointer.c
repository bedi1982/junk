#include <stdio.h>

int main()
{
	int *c;
	int d;

	c = &d;

	*c = 3000;
	printf ("%d",d);
}
