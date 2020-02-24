//how would you get the pointer of an array
#include <stdio.h>
#include <string.h>

void array_size(int* array, int size){
	printf("array size function called\n");
	int i = 0;
	printf("\nArray Address: %p\n", array);

	for (i = 0; i < 5; i++){
		printf("x[%d] memory address: %p", i, &array[i]);
		printf(" x[%d] value: %d\n", i, array[i]);
		printf(" Overflowing NOW!!! [%d] value: %d\n", i, array[i]);
	}
	
	//int size = sizeof(*array/sizeof(int));
	printf("Size of array: %d\n", size);
	int x[9];
	int xsize = sizeof(x)/sizeof(int);
	printf("%d\n", xsize);
}

void tests(){
	printf("\nEntered tests functions: ");
	static int i; 
	++i; 
	printf("%d\n",i); 

	// intialize a char variable, print its address and the next address
	char charvar = '\0';
	printf("address of charvar = %p\n", (void *)(&charvar));
	printf("address of charvar - 1 = %p\n", (void *)(&charvar - 1));
	printf("address of charvar + 1 = %p\n", (void *)(&charvar + 1));
}

struct test{
	int a;
	int b;
};

struct cerveja{
	char malte[3]; 
	char nome[];
};

void main(){
	int r[5] = {10,20,30,40,50};
	int x[5] = {10,20,30,40,50};
	float y[5] = {1.1,1.2,1.3,1.4,1.5};
	unsigned long z[5] = {-9999,-9223372036854775807,-9223372036854775807,-9223372036854775807,-9223372036854775807};
	signed long w[5] = {-9999,-9223372036854775807,-9223372036854775807,-9223372036854775807,9223372036854775807};
	int i =0;
	int arrsize = sizeof(x)/sizeof(int);
	printf("sizeof(r) = %lu\n", sizeof(r));

	for (i = 0; i < 5; i++){
		printf("x[%d] memory address: %p", i, &x[i]);
		printf(" x[%d] value: %d\n", i, x[i]);
	}
	for (i = 0; i < 5; i++){
		printf("y[%d] memory address: %p", i, &y[i]);
		printf(" y[%d] value: %f\n", i, y[i]);
	}
	for (i = 0; i < 5; i++){
		printf("z[%d] memory address: %p", i, &z[i]);
		printf(" z[%d] value: %lu\n", i, z[i]);
	}
	for (i = 0; i < 5; i++){
		printf("w[%d] memory address: %p", i, &w[i]);
		printf(" w[%d] value: %ld\n", i, w[i]);
	}

	array_size(x, arrsize);
	tests();
	char charvar = '\0';
	tests();
	char charvara = '\0';
	tests();

	struct test test1;
		test1.a = 1;
		test1.b = 2;

	struct cerveja lala = {"Nao", "Skol"};

	printf("A %s %s tem malte", lala.nome, lala.malte);


}
