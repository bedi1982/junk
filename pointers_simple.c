int main(){
        //4 variaveis de numero inteiro:
        printf("Declarando 4 variaveis de inteiro: a,b,c,d\n\n");
        int a,b,c,d;

        //4 ponteiros de inteiro:
        printf("Declarando 4 ponteiros: *e,*f,*g,*h\n\n");
        int *e,*f,*g,*h;

        //Ponteiros recebendo enderecos de memoria das variaveis a, b, c, d:
        printf("Ponteiros recebendo endereco das variaveis de inteiro:\n");
        printf("e = &a;\nf = &b;\ng = &c;\nh = &d\n");

        e = &a;
        f = &b;
        g = &c;
        h = &d;

        //Vejamos os enderecos de a,b,c,d:
        printf("\nEndereco no ponteiro e: %p \n", e);
        printf("Endereco no ponteiro f: %p \n", f);
        printf("Endereco no ponteiro g: %p \n", g);
        printf("Endereco no ponteiro h: %p \n", h);

        //Enviando valores para os ponteiros, eles estao apontando para a, b, c, d:
        printf("\nEnviando valores para os ponteiros:\n");
        printf("*e = 10;\n*f = 20;\n*g = 30;\n*g = 40;\n");
        *e = 10;
        *f = 20;
        *g = 30;
        *h = 40;

        //Vamos printar a,b,c,d Note que acima em nenhum momento a,b,c,d receberam valor, o valor foi enviado 'via ponteiro'.
        printf("\nValor em a: %d \n", a);
        printf("Valor em b: %d \n", b);
        printf("Valor em c: %d \n", c);
        printf("Valor em d: %d \n", d);
}
