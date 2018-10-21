#include <string>
using namespace std;
#include <iostream> //cout

int main(){
	string x = "aaaaaaaaaabaaaaaaaaaa";
	int i = 0;
	int j = x.length() - 1;

	while (i <= j){
		if(x[i] != x[j]){
			std::cout << "nao eh palind\n";
			return false;
		}
			i++;
			j--;
	}
	std::cout << "eh palind\n";
	return true;
}
