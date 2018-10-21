#include <string>
#include <iostream> //cout
//#include <stdio.h>
#include <vector> //vector


int main(){
	std::vector<int> A = {-23,4,-3,8,-12};
	//std::cout << "array size" << A.size() << "\n";
		
	int prod = -9999999;
	
	int ap1 = 0;
	int ap2 = 0;

	for(int i = 0; i<A.size()-1; i++){
		if((A[i] * A[i+1]) > prod){
			prod = (A[i] * A[i+1]);
			std::cout << "array: " << i << "\n";
			ap1=i;
			ap2=i+1;
		}
	}
		std::cout << "Array pos: " << ap1;
		std::cout << "\nArray pos: " << ap2 << "\n";
		std::cout << "\nProduct: " << prod << "\n";
}

