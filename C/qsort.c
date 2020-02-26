#include <stdio.h>
#include <stdlib.h>


int compare (const void * a, const void * b){
	return ( *(int*)a - *(int*)b );
}

void main(){
	int n;
    int array[] = { 55,56,57,43,23,1,2,0,89 };
	qsort(array, 9, sizeof(int), compare);

	for (n=0; n<9; n++){
		printf ("%d ", array[n]);
	}

}
