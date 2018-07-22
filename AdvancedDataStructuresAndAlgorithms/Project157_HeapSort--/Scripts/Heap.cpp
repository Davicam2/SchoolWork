#include "./Heap.h"
#include <iostream>
#include <sstream>
// Provides floor, ceil, etc.
#include <cmath>


using namespace std;

Heap::Heap() {
  arraySize = 0;
  n = 0;
  A = NULL;  
}

// This assumes that every element of the array is an
// element of the heap.
Heap::Heap(int* inArray, int inArraySize, int inHeapSize) {	
	A = inArray;
	arraySize = inArraySize;
	n = inHeapSize;				
}

void Heap::buildMaxHeap() {	
	for (int i = arraySize ; i >= 0; i--)
	{
		maxHeapify(A, i);
	}
}
void Heap::maxHeapify(int i) {
	maxHeapify(A, i);
}

void Heap::maxHeapify(int* A, int i) {
	int l = i;
	int r = i;
	if (hasLeft(i))
		l = left(i);
	else
		return;
	if (hasRight(i))
		r = right(i);

	int largest = 0;
	int placeHold = 0;	
	
	if (arraySize != n)
		return;
	
	if (l <= n && A[l] > A[i])
		largest = l;
	else
		largest = i;
	if (r <= n && A[r] > A[largest])
		largest = r;
	if (largest != i)
	{
		placeHold = A[i];
		A[i] = A[largest];
		A[largest] = placeHold;
		maxHeapify(A, largest);
	}	
}

int Heap::left(int i) const{	
	if (hasLeft(i)) {
		i += 1;
		return (i * 2) - 1;
	}		
	else
		return i - 1;
}
int Heap::right(int i) const{
	
	if (hasRight(i)) {
		i += 1;
		return (i * 2);
	}
		
	else
		return i - 1;
}
int Heap::parent(int i) const {
	i += 1;
	return floor((i / 2) - 1);
}

bool Heap::hasLeft(int i) const{	
	if ((i * 2) - 1 <= n)
		return true;
	else
		return false;
}
bool Heap::hasRight(int i) const {
	if ((i * 2) <= n)
		return true;
	else
		return false;
}

// Destructor. Cleans up memory.
Heap::~Heap() {
  delete [] A;
}

// Note: the function name is prefixed by Heap:: (the class
// name followed by two colons). Any function defined in
// the .cpp file must have this prefix.
int Heap::at(int i) const {
  return A[i];
}

bool Heap::operator==(const Heap& rhs) {
  if (n != rhs.n) return false;
  for (int i = 0; i < n; ++i) {
    if (A[i] != rhs.A[i]) return false;
  }
  return true;
}

bool Heap::operator==(const int* rhs) {
  for (int i = 0; i < n; ++i) {
    if (A[i] != rhs[i]) return false;
  }
  return true;
}

std::ostream& operator<<(std::ostream& out, const Heap& h) {
  out << "[";
  for (int i = 0; i < h.n; ++i) {
    out << h.A[i];
    if (i < h.n-1) {
      out << ", ";
    }
  }
  out << "]";
  return out;
}

string toDotImpl( Heap& h, int i) {
  using namespace std;
  stringstream ss;
  if (h.hasLeft(i)) {
    ss << toDotImpl(h, h.left(i));
    ss << "\"" << h.at(i) << "\" -> \""
       << h.at(h.left(i)) << "\"\n";
  }
  if (h.hasRight(i)) {
    ss << toDotImpl(h, h.right(i));
    ss << "\"" << h.at(i) << "\" -> \""
       << h.at(h.right(i)) << "\"\n";
  }
  return ss.str();
}

string toDot( Heap& h) {
  using namespace std;
  stringstream ss;
  ss << "digraph G {\n";
  ss << "graph [ordering=\"out\"]\n";
  ss << "\"" << h.at(0) << "\"\n";
  ss << toDotImpl(h, 0);
  ss << "}\n";
  return ss.str();
}


