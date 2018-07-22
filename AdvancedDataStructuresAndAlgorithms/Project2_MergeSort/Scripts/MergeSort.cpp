#include "./MergeSort.h"
#include <iostream>

using namespace std;

///////////////////////////////////////////////////////////
//Cameron Davis-1/17/17
//Splits an array into two sections and sorts each section.
///////////////////////////////////////////////////////////
void merge(int arr[], int p, int q, int r) {
	int n1 = q - p + 1;
	int n2 = r - q;
	int *L,*R;
	//temp arrays
	L = new int[n1];
	R = new int[n2];

	//fills temp arrays
	for (int i = 0; i < n1; i++)
		L[i] = arr[p + i];
	for (int j = 0; j < n2; j++)
		R[j] = arr[q + 1 + j];	

	//initial indexs for sub arrays
	int i = 0, j = 0 , k = p;

	//merges thhe temp arrs back into original array sorted.
	while (i < n1 && j < n2){
		if (L[i] <= R[j])
			arr[k] = L[i], ++i;
		else
			arr[k] = R[j], ++j;
		k++;
	}
	//picks up residual elements from Left arr
	while (i < n1) {
		arr[k] = L[i];
		++i, ++k;
	}
	//picks up residual elements from Right arr
	while (j < n2) {
		arr[k] = R[j];
		++j, ++k;
	}		
}

/////////////////////////////////////////////////////////////////////////////////////////////////////
//Cameron Davis-1/17/17
//recursiveley sorts each half of the array passed in, then merges the two halfs with a merge call.
/////////////////////////////////////////////////////////////////////////////////////////////////////
void mergeSortImpl(int arr[], int l, int r) {
	int m;
	if (l < r) {
		m = (l + r) / 2;
		mergeSortImpl(arr, l, m);
		mergeSortImpl(arr, m + 1, r);
		merge(arr, l, m, r);
	}
}
/////////////////////////////////////////////////////////////////
//Cameron Davis-1/17/17
//convienience method for simpler user interface with the program
/////////////////////////////////////////////////////////////////
void mergeSort(int arr[], int r) {
	if (r % 2 == 0)
		mergeSortImpl(arr, 0, (r / 2) + 2);
	else
		mergeSortImpl(arr, 0, ((r + 1) / 2) + 2);
}
