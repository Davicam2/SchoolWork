#include <vector>

#include "./DisjointSet.h"
#include "./bmp.h"


 Node* makeSet() {
	 Node* newNode = new Node();
	 newNode->setNext(NULL);
	 DisjointSet* Dset = new DisjointSet(newNode);
	 newNode->setHead(Dset);	 
	 return newNode;
 }

 Node* makeSet(int data) {
	 Node* newNode = new Node();
	 newNode->setData(data);
	 newNode->setNext(NULL);
	 DisjointSet* Dset = new DisjointSet(newNode);
	 newNode->setHead(Dset);
	 return newNode;
 }

 Node* find(Node* x) {
	 DisjointSet* setObj = x->nodeSet();
	 return setObj->Dtail();
	 /*if (x->next() != NULL) 
		 find(x->next());	 
	 else
		 return x;*/
 }

////////////////// If the size of x's set is greater than or equal to the
////////////////// size of y's set, then merge y into x. Otherwise, merge x
////////////////// into y. This is the weighted union described in the
////////////////// video and book.
//////////////////
////////////////// After merging, be sure to delete one of the disjoint
////////////////// sets or you will have memory leaks. For example, if
////////////////// merging y into x, then after merging you would do
////////////////// something like
//////////////////     delete y->set();
////////////////// You do not need to delete any nodes, since they are
////////////////// simply transferred from one set to another.
//////////////////
////////////////// This function is called makeUnion() rather than just
////////////////// union() because union is a reserved word in C++.
//////////////////
 void makeUnion(Node* x, Node* y) {	 
	 
	 if (find(x) == find(y)) {
		 return;
	 }
	 else if (find(x)->nodeSet()->size() >= find(y)->nodeSet()->size()) {
		  link(x, y);
	 }
	 else{
		 link(y, x);
	 }		 
 }

 //unions y onto x
 void link(Node* x, Node* y) {
	 DisjointSet* leftSet = x->nodeSet();
	 DisjointSet* rightSet = y->nodeSet();
	 //set the size of the new set.
	 leftSet->setSize(leftSet->size(), rightSet->size());	

	 int xx = rightSet->size();
	 Node* swapNode = rightSet->Dhead();
	 //swap the set object pointed to by the nodes in the set being absorbed.
	 while (xx > 0) {
		 swapNode->setHead(leftSet);
		 xx--;

		 if(xx > 0)
		 swapNode = swapNode->next();		
	 }

	 //set the last node of the absorbed set to the beginning of the growing set
	 rightSet->Dtail()->setNext(leftSet->Dhead());
	 //set the head of the growing set to the beginning of the absorbed set
	 leftSet->setHead(rightSet->Dhead());
	 //delete absorbed DisjointSet
	 delete rightSet;
 }
 void quantizeImage(
     const std::string& infile, const std::string& outfile, int numBins) {
   // Read the image
   Bitmap b;
   b.read(infile);

   for (int i = 0; i < b.width(); i++)
   {
	   for (int j = 0; j < b.height(); j++)
	   {
		  b.setColor(i,j, b.quantized(i, j, numBins));
		   //b.setColor(i, j, 9);
	   }
   }
   // TODO: iterate through each pixel of the image. You can get the
   // dimensions of the image using b.width() and b.height(). You can
   // get a quantized version of a pixel using b.quantized(x,y,numBins).
   // You can write a new value to the pixel using b.setColor(x, y, c)
   // where c is an integer intensity.

   // Write the image
   b.write(outfile);
 }

 void connectedComponents(const std::string& infile, const std::string& outfile, int numBins) {
   // Read the file
   Bitmap b;
   b.read(infile);
   // Create a 2D array of nodes. The node pointers are not initialized.
   std::vector<std::vector<Node*>> nodes(
       b.width(), std::vector<Node*>(b.height()));

   // TODO: initialize the node pointers, one for each pixel.
   double k = 0;
   
   for (int i = 0; i < b.width(); i++)
   {
	   for (int j = 0; j < b.height(); j++)
	   {		   
		   Node* node = makeSet(k);
		   k++;
		   nodes[i][j] = node;
	   }
   }
   k = 0;
   for (int i = 0; i < b.width(); i++)
   {
	   for (int j = 0; j < b.height(); j++)
	   {
		   if (i - 1 >= 0) {
			   if (b.quantized(i, j, numBins) == b.quantized(i - 1, j, numBins) && i - 1 > 0)
			   {
				   makeUnion(nodes[i][j], nodes[i - 1][j]);
			   }
		   }
		   if (j - 1 >= 0) {
			   if (b.quantized(i, j, numBins) == b.quantized(i, j - 1, numBins) && j - 1 != 0)
			   {
				   makeUnion(nodes[i][j], nodes[i][j - 1]);
			   }
		   }		  
	   }
   }

   for (int i = 0; i < b.width(); i++)
   {
	   for (int j = 0; j < b.height(); j++)
	   {
		  Color c = Color::createRandom( find(nodes[i][j])->data());
		  b.setColor(i, j, c);
	   }
   }
   // TODO: Follow the algorithm you wrote in the homework to find
   // connected components. You will use b.quantized(x, y, numBins)
   // to get the pixel intensity.

   // TODO: Overwrite the image giving each connected component a unique
   // color. Each connected component should have a unique ID in the
   // representative node's data(). Use this integer ID to get a unique
   // color using the following code:
   //    Color c = Color::createRandom(id);
   // You can then set the pixel's color in the image using
   //    b.setColor(x, y, c);

   // Write the image
   b.write(outfile);
 }
