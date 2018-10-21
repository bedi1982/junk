

// you can use includes, for example:
// #include <algorithm>

// you can write to stdout for debugging purposes, e.g.
// cout << "this is a debug message" << endl;
#include <algorithm> //sort

int solution(vector<int> &A) {
        //http://www.cplusplus.com/reference/vector/vector/
        sort(A.begin(), A.end());

        int i, j, count = 0;

        for (i = 0; i < (signed)A.size(); i++) {
                for (j = i + 1; j < (signed)A.size(); j++) {
                        if (A[i] == A[j])
                                count++;
                        else
                                break;
                }
                if (count % 2 == 0)
                        return A[i];
                else {
                        count = 0;
                        i = j - 1;
                }
        }
        return 0;
}


