#include <stdio.h>
#include <string.h>

struct pessoa{
        int idade;
	char nome[50];
};

void bla(struct pessoa *t){
        printf("%s tem %d anos\n", t->nome, t->idade);
}

void main (){
        struct pessoa x;
	x.idade = 26;
	strcpy(x.nome, "bedi");
        bla(&x);
}

