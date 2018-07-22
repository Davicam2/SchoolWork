#pragma once

// Provides I/O
#include <iostream>
int i = 0;

template <typename T>
void partition(T* A, const int p, const int r) {
	T x = A[r];
	i = p - 1;
	for (int j = p; j < r; j++) {
		if (A[j] <= x) {
			i += 1;
			swap(A[i], A[j]);
		}
	}
	swap(A[i + 1], A[r]);
}

template <typename T>
void quicksort(T* A, int p, const int r) {
	if (p < r) {
		partition(A, p, r);
		quicksort(A, p, i);
		quicksort(A, i + 1, r);
	}
}


template <typename T>
void quicksort(T* A, const int r) {
	int p = 0;
	quicksort(A, p, r - 1);
}









