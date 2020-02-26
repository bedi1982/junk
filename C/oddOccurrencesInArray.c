#include <stdio.h>

int main() {

	int A[]= {23,44,10000,44,10000,78,2,1,6,2,6,1,23};
	int size = sizeof(A)/sizeof(int);
	int i = 0;

        for(i = 0; i< size; i++){
                for(int j = i+1; j<size; j++){
                        if(A[i] == A[j] ){
				A[i] = -1;
				A[j] = -1;
                                break;
			}
			}
                }
	i = 0;
	while(i < size){
		if(A[i] != -1){
			printf("%d", A[i]);
			break;
		}
	i++;
	}

return 0;

}
