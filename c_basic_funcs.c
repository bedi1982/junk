#include <stdio.h>
#include <string.h>

int main(){

int A[] = {1, 100, 4, 1, 50,1,1,1,1,1,1,1,1,2,3,4,5,4,5,6,7,6,7,67,8,9};

//array size//
int size = sizeof(A)/sizeof(int);

//array sorter <//
        int i, j, swap, n;

	for (i = 0; i < size; ++i)
    		for (j = i + 1; j < size; ++j){
        		if(A[i] > A[j]){
            			swap =  A[i];
            			A[i] = A[j];
            			A[j] = swap;
			}
		}
//end array sorter//

//print array//
int p = 0;
for(p = 0; p< size; p++){
	printf("%d ", A[p]);
}
	
	char x[] = "lala";
	//printf("%d", strlen(x));
	printf("\n");
}
