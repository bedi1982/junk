#include <stdio.h>

int main(){

	int silvio=45; //variavel silvio de inteiro valendo 45
	int *santos;  //declaro um ponteiro chamado santos


	//Quando voce quer colocar um endereco no seu ponteiro, use apenas o nome dele:
	santos=&silvio; //ponteiro santos recebe o endereco de silvio

	printf ("O endereco de silvio na Ram eh: %p - Mostrado aqui pelo ponteiro santos\n", santos);

	printf ("O valor que esta no endereco %p(de silvio) eh %d (mostrado aqui com com *santos e nao silvio)\n",santos, *santos);

	printf ("Quando voce quiser mandar algo para a variavel do endereco ao qual o ponteiro aponta use o *\n\n\n");

	printf ("Vou mandar 99 para a variavel ao qual o endereco *santos aponta, como esta acima\n");
	
	printf ("ex: *santos = 99; - O endereco silvio recebe 99\n");

	*santos=99;
	
	printf ("Agora Silvio vale %d porque mandei este valor para *santos que eh o ponteiro para o endereco da variavel silvio\n", silvio);

	printf ("O ponteiro santos continua a apontar para o endereco da variavel silvio que eh %p\n", santos);
       	
	printf ("O inteiro *santos mostra o valor(%d) do endereco silvio e nao o endereco(%p) de silvio\n", *santos, santos);

	return 0;
}
