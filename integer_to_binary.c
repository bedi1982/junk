#include <stdio.h>
#include <string.h>  

int main(){

	int c, k;	
	int n = 100;
        char x[1000];
	x[0] = '\0';//initialize
	int size = sizeof(x)/sizeof(char);
	
	for (c = 31; c >= 0; c--)
	{
		k = n >> c; //binary shifter
		if (k & 1){
			strcat(x, "1");//add to array 
		}else{
			strcat(x,"0");
		}
	}
	
	int i = 0; 
	int j = 0;
	
	//get first non 0 position
	for(i = 0; i < size; i++ ){
		if(!(x[i] == '0')){
			j = i;
			break;
			}
		}

	//iterate from position till  end
	char y[1000];
	y[0] = '\0';//initialize
	int z = 0 ;
	
	for(j=j; j<size; j++){
		y[z] = x[j];
		z++;
		if(x[j] == '\0'){
			break;
		}
	}
	printf("%s \n",y);
}
