#pragma once

// Provides I/O
#include <iostream>

template <typename T>
void bubblesort(T* A, const int n) {
  for (int i = 0; i < n-1; ++i) {
    for (int j = i+1; j < n; ++j) {
      if (A[j] < A[i]) {
        swap(A[i], A[j]);
      }
    }
  }
}



template <typename T>
void reverseBubblesort(T* A, const int n) {
	for (int i = n-1; i >= 0; i--) {
		for (int j = i-1; j >= 0; j--){
			if (A[j] < A[i]) {
				swap(A[i], A[j]);
			}
		}
	}
}

