#pragma once

#include <math.h>

// The division method of hashing. See section 11.3.1 of the textbook.
// m is the size of the table
class DivHash {
 public:
  int operator()(int key, int m) {
	  return (key % m);
  }
};

// TODO: implement class MultHash, similar to DivHash.
// The multiplcation method of hashing. See section 11.3.2 of the textbook.
// Use the A value suggested in equation 11.2.= (sqrt(5)-1)/2
// m is the size of the table

class MultHash {
public:
	int operator()(int key, int m) {
		double hash = (sqrt(5) - 1) / 2;
		hash = key * hash;
		hash = fmod(hash, 1);
		hash = floor(hash * m);
		return hash;		
	}
};