#include <stdio.h>

void main(){

int x[10] = {9,8,7,6,5,4,3,2,1,10};

int i;
int store;

for (i = 0; i < 9; i++){
	if(x[i] > x[i+1]){
		store = x[i];
		x[i] = x[i+1];
		x[i+1] = store;
		i = 0;
	}
}

for (i = 0; i < 10; i++){
	printf("%d", x[i]);
}
}
