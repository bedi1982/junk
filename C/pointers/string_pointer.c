#include <stdio.h>

char printa_string(char *string)
{
	string = "Lombarde";
	//printf("%s\n", string);
	return *string;
}

main()
{
	char *string;
	printf("%s\n", printa_string(string));
}
