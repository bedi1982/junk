#include <vector> //vector
#include <iostream> //cout
#include <algorithm> //sort

int solution(vector<int> &A) {
    
    //tests//
    //A = {1,3,6,4,1,2};
    //A = {1,2,3};
    //A = {-1,-3};

    for (unsigned int i=0; i<A.size(); i++ ){
		if(A[i] == 0 || A[i] < 1){
			A.erase(A.begin()+i);
			i--;
		}
    }
    
    if(A.empty()){
        return 1;
    }
    
    //sort and erase duplicates
	sort(A.begin(), A.end());
	A.erase(unique(A.begin(), A.end()), A.end());

    int y = 0;
	for (unsigned int i=1; i<= A.size(); i++ ){
		if(i !=  (unsigned)A[i-1]){
			y = i;
			break;
		}else{
		    y = i+1;
		};
    } 
    return y;
}
