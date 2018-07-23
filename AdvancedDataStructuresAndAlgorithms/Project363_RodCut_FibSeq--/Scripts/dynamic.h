#pragma once
#include <iostream>
#include <sstream>



int max(int a, int b) {	
	return (a > b) ? a : b;
}

int cutRodNaive(int p[],int n, int& callcount) {
	callcount++;
	if (n == 0)
		return p[0];
	int q = -200;
	for (int i = 1; i <= n; i++)
	{	
		q = max(q, p[i] + cutRodNaive(p, n - i, callcount));
	}
	return q;
}


int cutRodMemo(const int* p, int n, int& callcount) {
	int* r = new int[n];
	r[0] = 0;
	if (n == 0)
		return p[0];	
	for (int i = 1; i <= n ; i++)
	{
		int maxVal = -200;
		for (int j = 0; j <= i; j++)
		{
			callcount++;
			maxVal = max(maxVal, p[j] + r[i - j]);
			r[i] = maxVal;			
		}		
	}
	return r[n];
}
//returns a fibbinochi sequence of size n;
int* fibSequence(int n) {
	int* fibSec = new int[n];

	for (int i = 0; i <= n; i++)
	{
		if (i == 0 || i == 1) {
			fibSec[i] = 1;
		}
		else
		{
			fibSec[i] = (fibSec[i - 1] + fibSec[i - 2]);
		}
	}
	return fibSec;
}


int fibNaive(int n, int& callcount) {
	int* fibSec = fibSequence(n);
	int maxVal = cutRodNaive(fibSec, n, callcount);	
	return maxVal;
}

int fibMemo(int n, int& callcount) {
	int* fibSec = fibSequence(n);
	int maxVal = cutRodMemo(fibSec, n, callcount);
	return maxVal;
}
