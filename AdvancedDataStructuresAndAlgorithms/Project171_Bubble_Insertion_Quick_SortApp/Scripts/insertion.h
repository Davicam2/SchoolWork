#pragma once
#include <iostream>

template <typename T>
void insertionSort(T* A, int n) {
	int i;
	for (int j = 1; j < n; j++) {
		T currentObj = A[j];
		i = j - 1;
		while (i >= 0 && A[i] > currentObj) {
			swap(A[i + 1], A[i]),
			swap(A[i], currentObj);
			i -= 1;
			j = i;
		}
	}
}
