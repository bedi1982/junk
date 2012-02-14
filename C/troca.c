#include <stdio.h>

char bagunca(char *palavra, int tamanho)
{

        int i;
        int num = 0;
        int tmp;

        //Embaralhador de tudo menos primeira e ultima de preguicoso, bubblesort//
        for (i = 1; i < tamanho - 2; i++){
                if (palavra[i] > palavra[i+1]){
                        tmp = palavra[i+1];
                        palavra[i+1] = palavra[i];
                        palavra[i] = tmp;
                }
        }

	return *palavra;
}

main()
{
        char palavra[10];
        char c;
        int ok, i = 0;
	int letras = 0;

        while((c = getchar()) != EOF){
                if (isalpha(c)){ //se eh caracter valido
                        palavra[letras] = c;
                        letras++;
                        ok = 1;
                }else{
                        if(ok == 1 ){ //se o ultimo caracter foi valido, embaralha//
				*palavra = bagunca(palavra, letras); //Vai retornar a palavra baguncada

				for (i = 0 ; i < letras ; i++){
					printf("%c", palavra[i]);
				}
                                letras = 0;
                        }
                }

                if (!isalpha(c)){ //se nao eh valido
                        printf("%c", c);
                        ok = 0;
                }
        }
}
