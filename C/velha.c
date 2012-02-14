#include <stdio.h>

char matriz[3][3] = {'2','7','6','9','5','1','4','3','8'};

void exibir_matriz()
{

	int  i, j;

	for (i = 0; i<3; i++){
		for (j=0; j<3; j++){
			printf ("%c ", matriz[i][j]);
		}
		printf ("\n");
	}
}

void preenche_tabuleiro(int quem, int aonde)
{
	switch (aonde){
		case '0':
			matriz[0][0] = quem;
			break;
		case '1':
			matriz[0][1] = quem;
			break;
		case '2':
			matriz[0][2] = quem;
			break;
		case '3':
			matriz[1][0] = quem;
			break;
		case '4':
			matriz[1][1] = quem;
			break;
		case '5':
			matriz[1][2] = quem;
			break;
		case '6':
			matriz[2][0] = quem;
			break;
		case '7':
			matriz[2][1] = quem;
			break;
		case '8':
			matriz[2][2] = quem;
			break;
	}

//	printf (" A resposta da comparacao eh: %d\n", comparacoes());

	exibir_matriz();
}

int comparacoes()
{
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[1][0] + matriz[1][1] + matriz[1][2]) == 15){
		return 1;
	}
	if ((matriz[2][0] + matriz[2][1] + matriz[2][2]) == 15){
		return 1;
	}
	if ((matriz[1][0] + matriz[1][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
	if ((matriz[0][0] + matriz[0][1] + matriz[0][2]) == 15){
		return 1;
	}
}

int main()
{
	int aonde;
	char quem;

	exibir_matriz();

	printf ("Quem vai comecar, X ou 0 ?\n");
	scanf (" %c", &quem);

	printf ("%c, Em qual posicao deseja jogar (0 ate 8)?\n",quem );
	scanf (" %c", &aonde);

	preenche_tabuleiro(quem, aonde);
	
	return 0;
}
