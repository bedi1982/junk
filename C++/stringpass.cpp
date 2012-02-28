#include <iostream>
using namespace std;

void convite(char *nome)
{
	cout << nome << endl;
}

int main()
{
	char nome[10] = "Lombo";
		convite(nome);
	return 0;
}
