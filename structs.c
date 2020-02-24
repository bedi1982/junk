#include <stdio.h>
#include <string.h>

void main(){

struct beer{
	char name[15];
	char malte[4];
};

struct beer pomerode;
	strcpy(pomerode.name, "Zinke");
	strcpy(pomerode.malte, "sim");

	printf("%s \n", pomerode.name);
}
