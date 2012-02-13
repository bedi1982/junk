#include <stdio.h>
#include <string.h>

int main(){
	FILE *arquivo;
	arquivo = fopen("reuniao", "w");
	fprintf(arquivo, "Testing...\n");
}

