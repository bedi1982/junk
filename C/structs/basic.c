#include <stdio.h>

struct cadastre {
	unsigned cod;
	char name;
	unsigned age;
	char genre;
};

main()
{
	struct cadastre users[5];
	int i;

	for (i=0; i<5; i++){
		scanf("%d", &users[i].age);
	}

	for (i=0; i<5; i++){
		printf ("%d", users[i].age);
	}
}
