#include <sstream>
#include <algorithm>

#include "./huffman.h"


void getCodeWordsRec(Node* root, string codewords[], string code) {
	if (!root) {
		return;
	}
	if (root->data() != 0) {
		codewords[root->data()] = code;
	}
	getCodeWordsRec(root->left(), codewords, code + "0");
	getCodeWordsRec(root->right(), codewords, code + "1");
}



//calls the getCodeWordsRec(root,codewords[], code) function
void getCodewords(Node* root, string codewords[]) {
		getCodeWordsRec(root, codewords, "");
}

//builds a huffmans binary tree
Node* buildBinaryTree(const int* freq) {
	Node* left = new Node(0,0);
	Node* right = new Node(0, 0);

	priority_queue<Node*, vector<Node*>, NodeComp> queue;
	for (int i = 0; i < 256; i++)
	{
		if (freq[i] != 0) {			
			queue.push(new Node(freq[i],i));
		}
	}
	while (queue.size() != 1)
	{
		left = queue.top();
		queue.pop();
		right = queue.top();
		queue.pop();
		Node* newTop = new Node(left->key() + right->key(),0);
		newTop->setLeft(left);
		newTop->setRight(right);
		queue.push(newTop);
	}
	
	return queue.top();
}

//counts the occurence of values in a freq table.
void countFrequencies(const string& data, int* freq) {
	for (int i = 0; i < data.size(); i++)
	{
		++freq[data[i]];		
	}
}

string getHeader(int* freq) {
  std::stringstream ss;
  int numChars = 0;
  for (int i = 0; i < 256; ++i) {
    if (freq[i] > 0) numChars++;
  }
  ss << numChars << std::endl;
  for (int i = 0; i < 256; ++i) {
    if (freq[i] > 0) {
      ss << i << " " << freq[i] << std::endl;
    }
  }
  return ss.str();
}

string compressData(const string& data) {  

  int freq[256];
  std::fill(freq, freq + 256, 0);

  countFrequencies(data, freq);

  Node* root = buildBinaryTree(freq);

  // Write the header.
   std::stringstream ss;
   ss << getHeader(freq);
  
   //get code words
   string codewords[256];
   getCodewords(root, codewords);


  // TODO: Iterate through the data and write the corresponding
  // codeword for each character to the bit buffer. See comments
  // at the top of bit_buffer for usage instructions.
   bit_buffer buf;
   string codeWord = "";
   for (int i = 0; i < data.size(); i++)
   {
	   codeWord += codewords[data[i]];
	   for (int j = 0; j < codeWord.size(); j++)
	   {
		   if (codeWord[j] == '0')
			   buf.add(0);
		   else
			   buf.add(1);
	   }
	   codeWord = "";
   }

  // Write the data portion
   string compressed = ss.str();
   std::stringstream ss2;
   ss2 << buf;
   compressed += ss2.str();
   return compressed;
  
}

string uncompressData(const string& data) {
  // Read frequencies from the header
  std::stringstream ss(data);
  int count;
  ss >> count;
  
  int freq[256];
  std::fill(freq, freq+256, 0);
  for (int i = 0; i < count; ++i) {
    int c;
    int f;
    ss >> c >> f;
    freq[c] = f;
  }
  //ss >> getHeader(freq);
  Node* root = buildBinaryTree(freq);
  // TODO: build the binary tree

  bit_buffer buf(ss);
  std::stringstream out;
  // TODO: Use the binary tree to get the characters back from the buffer.

  

  Node* letterNode = root;
  while(buf.hasNext())
  {
	
	  int i = buf.next();
	  if (i == 0)		  
		letterNode =letterNode->left();
	 
	  else 
		letterNode = letterNode->right();

	  i = -1;
		if (letterNode->data() > 0) {
			out << letterNode->data();
			letterNode = root;
		}
  }


  // Note that you should use the binary tree itself and not the
  // codewords to decompress the data.
  // Once you find the next character, add it to the output stream as
  //   out << c;

  return out.str();
}

