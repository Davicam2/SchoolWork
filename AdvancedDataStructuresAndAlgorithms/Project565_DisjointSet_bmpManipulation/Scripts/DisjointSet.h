#pragma once

#include <cstddef>
#include <string>

// Your Node and DisjointSet classes will have references to each other.
// Circular references are handled by
//   1) making sure each least one of the references is a pointer.
//   2) declaring one of the classes before it is defined.
// For example,
//
//   // declaration of DisjointSet
class Node;

   // definition of DisjointSet
   class DisjointSet {
   public:
	   DisjointSet(Node* node) {
		   _setHead = node;
		   _setTail = node;
		   _size = 1;
	   }

	   //first node in the set objects set
	    Node* Dhead()  { return _setHead; }
		//last node in the set objects set
	    Node* Dtail()  { return _setTail; }
		//amount of nodes tracked by this set object
		const int size() const { return _size; }

	   void setHead(Node* head) { _setHead = head; }
	   void setTail(Node* tail) { _setTail = tail; }
	   void setSize(int setX, int setY) { _size = setX + setY; }
	   

   private:
	   Node* _setHead;
	   Node* _setTail;
	   int _size;
   };


   class Node {
   public:
	   Node() {
		   _nodeData = NULL;
		   _nodeNext = NULL;
		   _nodeHead = NULL;
	   }
	  // DisjointSet* Dset = new DisjointSet(Node);
	   
		//data the node contains
	    const int& data() const { return _nodeData; }
		//node the current node is pointing to
	    Node* next()  { return _nodeNext; }
		//set the node belongs to
	    DisjointSet* nodeSet()  { return _nodeHead; }

		//set the data containded in the node
	   void setData(int data) { _nodeData = data; }
	   //set the node the current node points to
	   void setNext(Node* next) { _nodeNext = next; }
	   //set the set object the node points to
	   void setHead(DisjointSet* head) { _nodeHead = head; }

   private:
	   int _nodeData;
	   Node* _nodeNext;
	   DisjointSet* _nodeHead;
   };

  

// TODO: place Node and DisjointSet classes here

// TODO: uncomment function declarations and implement them in
// DisjointSet.cpp

 Node* makeSet();

// // A node can hold data.
 Node* makeSet(int data);

 Node* find(Node* x);

// // If x is greater than or equal to y, then merge y into x.
// // Otherwise, merge x into y. After merging, be sure to delete
// // one of the disjoint sets or you will have memory leaks.
// // For example, if merging y into x, then after merging
// // you would do something like
// //     delete y->set();
// // You do not need to delete any nodes, since they are
// // simply transferred from one set to another.
// //
// // This function is called makeUnion() rather than just
// // union() because union is a reserved word in C++.
 void makeUnion(Node* x, Node* y);

// // This function converts the input image to grayscale and quantizes the
// // intensities into numBins unique intensities. In effect, it reduces
// // the number of colors in the image. This function is a warm-up
// // to learn the Bitmap interface so you can use it for finding
// // connected components in the connectedComponents() function.
 void quantizeImage(
     const std::string& infile, const std::string& outfile, int numBins);

// // This function finds all connected components in the quantized input
// // image and writes a new image with each connected component having
// // its own color.
 void connectedComponents(
     const std::string& infile, const std::string& outfile, int numBins);

 void link(Node* x, Node* y);