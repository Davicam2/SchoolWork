#include "./Heap.h"
#include <iostream>
#include <sstream>
// Provides floor, ceil, etc.
#include <cmath>
#include "./Patient.h"

using namespace std;

Heap::Heap() {
  arraySize = 0;
  n = 0;
  A = NULL;  
}

// This assumes that every element of the array is an
// element of the heap.
Heap::Heap(Patient* inArray, int inArraySize, int inHeapSize) {	
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

void Heap::maxHeapify(Patient* A, int i) {
	int l = i;
	int r = i;
	

	if (hasLeft(i)) {		
		l = left(i);
	}		
	else
		return;
	if (hasRight(i)) {		
		r = right(i);
	}
		

	int highestPriority;
	Patient placeHold;

	if (arraySize != n)
		return;

	if (l <= n && A[l].priority() > A[i].priority())
		highestPriority = l;
	else
		highestPriority = i;
	if (r <= n && A[r].priority() > A[highestPriority].priority())
		highestPriority = r;
	if (highestPriority != i)
	{
		placeHold = A[i];
		A[i] = A[highestPriority];
		A[highestPriority] = placeHold;
		maxHeapify(A, highestPriority);
	}	
}

void Heap::heapsort() {
	Patient placeHold;
	buildMaxHeap();		
	for (int i = floor(arraySize/2); i > 0; i--)
	{
		placeHold = A[arraySize - n];
		A[arraySize - n] = A[i];				
		A[i] = placeHold;
		n -= 1;
	}
	for (int i = 0; i < arraySize; i++)
	{
		cout << at(i).name() << " - " << at(i).priority() << endl;
	}
}




int Heap::left(int i) const{	
	if (hasLeft(i)) {
		i += 1;
		return (i * 2) - 1;
	}		
	else
		return ( i - 1);
}
int Heap::right(int i) const{
	
	if (hasRight(i)) {
		i += 1;
		return (i * 2);
	}		
	else
		return (i - 1);
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
Patient Heap::at(int i) const {
  return A[i];
}

bool Heap::operator==(const Heap& rhs) {
  if (n != rhs.n) return false;
  for (int i = 0; i < n; ++i) {
    if (A[i] != rhs.A[i]) return false;
  }
  return true;
}

//bool Patient::operator==(const Patient* rhs) {
//  for (int i = 0; i < n; ++i) {
//    if (A[i] != rhs[i]) return false;
//  }
//  return true;
//}

//std::ostream& operator<<(std::ostream& out, const Patient& h) {
//  out << "[";
//  for (int i = 0; i < ; ++i) {
//    out << h.A[i];
//    if (i < h.n-1) {
//      out << ", ";
//    }
//  }
//  out << "]";
//  return out;
//}

//string toDotImpl( Heap& h, int i) {
//  using namespace std;
//  stringstream ss;
//  if (h.hasLeft(i)) {
//    ss << toDotImpl(h, h.left(i));
//    ss << "\"" << h.at(i) << "\" -> \""
//       << h.at(h.left(i)) << "\"\n";
//  }
//  if (h.hasRight(i)) {
//    ss << toDotImpl(h, h.right(i));
//    ss << "\"" << h.at(i) << "\" -> \""
//       << h.at(h.right(i)) << "\"\n";
//  }
//  return ss.str();
//}

//string toDot( Heap& h) {
//  using namespace std;
//  stringstream ss;
//  ss << "digraph G {\n";
//  ss << "graph [ordering=\"out\"]\n";
//  ss << "\"" << h.at(0) << "\"\n";
//  ss << toDotImpl(h, 0);
//  ss << "}\n";
//  return ss.str();
//}


