#include <stdio.h>

int main()
{
        int vetora[3] = {1, 2, 3};
        int vetorb[3] = {4, 5, 6};
        int vetorc[6] = {0};
        short i;

        for (i = 0 ; i < 3; i++){
		if ( i % 2 == 0 ){
			vetorc[i] = vetora[i];
		}
	}
        
        for (i = 0 ; i < 3; i++){
		if ( i % 2 != 0 ){
			vetorc[i] = vetorb[i];
		}
	}

	for (i = 0; i < 6; i++){
                printf("%d\n", vetorc[i]);
        }

	return 0;
}
