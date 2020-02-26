#include <stdio.h>

void print_array(int *x){

    int i;
    
    printf("Mem address of x: %p \n", &x);
    for(i=0; i < 10; i++){
        printf("%d", x[i]);
    }
}


void main(){
    
    int x[10] = {11,2,3,4,5,6,7,8,9,10};
    int i, store;
    int y = 9;
    int size = sizeof(x)/sizeof(int);

    for(i=0; i<(size/2); i++,y--){
        printf("i: %d \n", i);
        printf("y: %d \n", y);
        store = x[i];
        x[i] = x[y];
        x[y] = store;
    }

    print_array(x);

}
