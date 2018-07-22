#include "./InsertionSort.h"
////////////////////////////////////////////////
//Cameron Davis-1/9/17
//sorts an array of ints based on insertion sort logic.
////////////////////////////////////////////////
void insertionSort(int* A, int n) {
	int i, j;
	for (int j = 1; j < n; j++) {
		int currentInt = A[j], i = j - 1;
		while (i >= 0 && A[i] > currentInt){
			A[i + 1] = A[i], 
				A[i] = currentInt, 
				--i,
				j = i;									
		}
	}	
}
