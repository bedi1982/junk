#include <stdio.h>
#include <string.h>

int main(){
	int A[] = {1,7,8,9};
	
	//array size//
	int size = sizeof(A)/sizeof(int);
	
	int pos = 2;//to remove
	int i = 0;
	
	printf("size: %d", size);

	//https://stackoverflow.com/questions/46932199/c-delete-element-of-an-array//
	if(pos >= size || pos < 0){
		printf("Invalid position! Please enter position between 1 to %d", size);
	}else{
		for(i=pos; i<size-1; i++){
			A[i] = A[i + 1];
		}
	//size--;
	}

	printf("\nElements of array after delete are : ");

	for(i=0; i<size; i++){
		printf("%d ", A[i]);
	}
}
