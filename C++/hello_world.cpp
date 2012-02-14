#include <iostream>
using namespace std;

void teste(int n1, int n2)
{
	int soma;
	soma = n1 + n2;

	cout << "n1 + n2 = " << soma << ", sacou?" << endl;
/*	cout << "Seu burro, entre aspas vai imprimir o texto." <<endl;*/
}

int main()
{
	int n1;

	n1 << cin;

	teste(1, 2);
	return 0;
}
