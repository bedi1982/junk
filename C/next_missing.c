int solution(int A[], int N) {
  
    int i ,j, swap;

    for (i = 0; i < N; ++i){
        for (j = i + 1; j < N; ++j){
            if(A[i] > A[j]){
                swap = A[i];
                A[i] = A[j];
                A[j] = swap;
            }
        }
    }
    
    if(N == 1){
        return A[0];
    }
    
    for (i = 0; i< N; i++){
        if(A[i]+1 != A[i+1]){
            return A[i]+1;
        }
    }
    return 1;
}
