#include "./MaxSubarray.h"
#include <iostream>
// Provides floor, ceil, etc.
#include <cmath>

using namespace std;
//////////////////////////////////////////////////////////////
//Cameron Davis 1/26/17
//CS 3385 Max Subarray Project 72
//////////////////////////////////////////////////////////////

//Finds the max value contiguous subarray that crosses the midpoint of the total array.
Result findMaxCrossingSubarray(int A[],int low, int mid,int high) {
	int sum = 0;
	int leftSum = 0;
	int leftMax = 0;
	for (int i = mid; i >= low ; i--){
		sum += A[i];
		if (sum > leftSum){
			leftSum = sum; 
			leftMax = i;
		}
	}
	sum = 0;
	int rightSum = 0;
	int rightMax = 0;
	for (int j = mid + 1; j <= high ; j++){
		sum += A[j];
		if (sum >= rightSum) {
			rightSum = sum;
			rightMax = j;
		}
	}
	Result MaxCrossingSubarray(leftMax, rightMax, leftSum + rightSum);
	return MaxCrossingSubarray;
}

//Finds the max value contiguous subarray in the given array.
Result findMaxSubarray(int A[], int low, int high) {
	int mid = 0;
	int leftSum = 0 , leftMax = 0;
	int rightSum = 0, rightMax = 0;
	int sum = 0;
	if (high == low)
		return Result(low, high, A[low]);
	else
		//finds mid value
		mid = floor((high - low) / 2);
	//finds max left subarray value, could implement recursively
	for (int i = low; i <= mid; i++) {
		sum += A[i];
		if (sum > leftSum) {
			leftSum = sum;
			leftMax = i;
		}
	}
		sum = 0;
	//finds max right subarray, could implement recursively
	for (int j = mid + 1; j <= high; j++){
		sum += A[j];
		if (sum >= rightSum) {
			rightSum = sum;
			rightMax = j;
		}		
	}
	//finds max value crossing subarray 
	Result r = findMaxCrossingSubarray(A, low, mid, high);
	//checks which array has greatest value
	if (leftSum >= rightSum && leftSum >= r.sum) {
		return Result(low, leftMax, leftSum);
	}
	else if (rightSum >= leftSum && rightSum >= r.sum) {
		return Result(mid + 1, rightMax, rightSum);
	}
	else
		return r;		
}