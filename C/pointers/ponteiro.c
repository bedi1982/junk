#include <stdio.h>
#include <stdlib.h>
int main()
{
	int i=10;
	int *p;                         /* a pointer to an integer */

	p = &i;                         /*associamos o endereço de i ao ponteiro p*/
	printf("p aponta para o endereco %d\n",p);
	*p=5;                          /*atribuímos o valor 5 ao endereco que p aponta*/

	printf("o endereco de i recebeu: %d\n endereco do ponteiro: %d\n endereco do ponteiro: %p\n", i, *p, p);     /*imprimimos a variável i e para onde aponta p e ainda o endereço para onde aponta*/
	return 0;
}
