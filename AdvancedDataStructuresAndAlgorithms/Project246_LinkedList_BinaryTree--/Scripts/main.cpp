//------------------------------------------------------------
//
// CS 3385
// Project p246
//
// In this project you will be making additions to a linked
// list class and then creating a binary tree class from
// scratch.
//
// You can visualize your tree by calling toDot() and then
// plugging the result in to www.webgraphviz.com.
//
// Be sure to use the code checker (linked to from the syllabus
// web page) to make sure your code will work when graded.
//
// Files to submit:
//   * LinkedList.h
//   * BinaryTree.h
// 
//------------------------------------------------------------

#include <iostream>
#include <sstream>
#include <math.h>



using namespace std;

//------------------------------------------------------------
// Tests
//------------------------------------------------------------


int main() {
	double x = 0;
	double y = 0;
	cin >> x;
	y = (sqrt(5) - 1)/ 2;
	x = x * y;
	x = fmod(x,1);
	x = x * 1000;
	x = floor(x);
	cout << x << endl;
	return x;

}

