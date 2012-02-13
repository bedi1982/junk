#include <stdio.h>

char menu(){

	char escolha;
	printf ("\n \t\t  MENU PRINCIPAL \n");
	printf ("(V)endas\n");
	printf ("(E)stoque\n");
	printf ("(R)elatorios\n");
	printf ("(C)onfiguracoes\n");
	printf ("(S)air\n");

	scanf (" %c", &escolha);
	return escolha;
}

char vendas(){

	char escolha;

	printf ("\n \t\t VENDAS \n");
	printf ("As opções com * ainda não foram implementadas e farao sair do sistema.\n");
	printf ("* Lancar Item\n");
	printf ("* Cancelar Item\n");
	printf ("* Finalizar Venda\n");
	printf ("(M)enu Principal\n");
	printf ("(S)air\n");

	scanf (" %c", &escolha);
	return escolha;
}

char estoque(){

	char escolha;

	printf ("\n \t\t ESTOQUE \n");
	printf ("As opções com * ainda não foram implementadas e farao sair do sistema.\n");
	printf ("* Cadastrar Produto\n");
	printf ("* Alterar dados de um produto\n");
	printf ("(M)enu principal\n");
	printf ("(S)air\n");

	scanf (" %c", &escolha);
	return escolha;
}

char relatorios()
{
	char escolha;

	printf ("\n \t\t RELATORIOS \n");
	printf ("As opções com * ainda não foram implementadas e farao sair do sistema.\n");
	printf ("* Relatorio de vendas\n");
	printf ("* Imprimir Estoque\n");
	printf ("* Imprimir configuracoes do sistema\n");
	printf ("(M)enu Principal\n");
	printf ("(S)air\n");

	scanf (" %c", &escolha);
	return escolha;
}

char configure(){

	char escolha;

	printf ("\n \t\t CONFIGURACOES \n");
	printf ("As opções com * ainda não foram implementadas e farao sair do sistema.\n");
	printf ("* Configurar Idioma\n");
	printf ("* Configurar mensagem do dia\n");
	printf ("* Configurar leitor de codigo de barras\n");
	printf ("* Configurar Impressora\n");
	printf ("(S)air\n");

	scanf (" %c", &escolha);
	return escolha;
}

void sair(){
	printf("\t\tObrigado por usar este software.\n");
	printf("\t\tObrigado por usar este software.\n");
	printf("\t\tObrigado por usar este software.\n");
	printf("\t\tObrigado por usar este software.\n");
}

main()
{

	switch (menu()){
		case 'v' : if (vendas() == 'm')
				   main();
			   else
				   sair();
			   break;

		case 'e' :
			   if (estoque() == 'm')
				   main();
			   else
				   sair();
			   break;  

		case 'r' : if (relatorios() == 'm')
				   main();
			   else
				   sair();
			   break;

		case 'c' : if (configure() == 's')
				   sair();
			   break;

		case 's' : sair(); 
			   break;

		default  :
			   printf("Opcao invalida\n");
			   main();
			   break;
	}
}
