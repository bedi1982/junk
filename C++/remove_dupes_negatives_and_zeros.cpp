//#include <stdio.h>
#include <vector> //vector
#include <iostream> //cout
#include <algorithm> //sort

int main(){
	
	//my vector
	std::vector<int> A = {-1,0,0,0,2,3,6,4,1,2,0,0,0,0,-1,-2,-3, -100000, 1000000};

	//remove negatives and 0s
	for (int i=0; i<A.size(); i++ ){
		if(A[i] == 0 || A[i] < 1){
			A.erase(A.begin()+i);
			i--;
		}
	}

//	std::cout << A.end();

	//sort and remove dupes 
	//https://stackoverflow.com/questions/1041620/whats-the-most-efficient-way-to-erase-duplicates-and-sort-a-vector#1041939 //
	sort(A.begin(), A.end());
	A.erase(unique(A.begin(), A.end()), A.end());
	
	//just a print to see array status
	std::cout << "Vector status after cleanup: \n";
	for (int i=0; i<A.size(); i++ ){
		std::cout << " "  << A[i];
	}

	//compare iterator to value (iterator)
	for (int i=1; i<=A.size(); i++ ){
		if(i != A[i-1]){
			std::cout << "\n\nSmallest mising: " << i << "\n";
			break;
		}
	}
	return 0;
}

