#include <stdio.h>

void main(){

int i,lines, space, x;
lines = 10;
int k = 0;

for (i=1; i<=lines; ++i,k=0){
    for(space=1; space<=lines-i; ++space){
        printf("@ ");}
            while (k!=2*i-1){
                printf("* ");
                ++k;
            }
        printf("\n");
        }
}
