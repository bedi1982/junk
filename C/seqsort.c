#include <stdio.h>

int arr[] = {55,3,5,34,2};

void main(){

	int i,j;
	int store;
	
	for(i=0; i<5; ++i){
		for(j = i+1; j < 5; ++j){
			if(arr[i] > arr[j]){
				store = arr[i];
				arr[i] = arr[j];
				arr[j] = store;
			}
		}
		
	}

	for(i=0; i<5; i++){
		printf("%d ", arr[i]);
	}


}
