#include <string>
using namespace std;
#include <iostream> //cout
#include <vector> //vector

int main(){
	//http://www.cplusplus.com/reference/vector/vector/
	vector<int> A;// = {3,8,9,7,6};
	int K = 3;
	
	int size = A.size();
	
	if(A.empty()){
		return A;
	}

	for(int i = 0; i < K; i++){
		int last = A.back();
	
		for(int i = size-1; i >= 0; i--){
			A[i] = A[i-1];
		}
		
		A[0] = last;
	}
	
	for (int x : A){ //prints ok//
		cout << x;
	}
}
