#include <iostream>
#include <string>
#include "Student.h"
#include <sstream>

#include "./util.h"


template<typename T, typename KeyType>
class BNode {
public:
	BNode(const T& data, const int& key) {
		_data = data;
		_key = key;
		_head = NULL;
		_left = NULL;
		_right = NULL;
	}
	BNode(const T& data) {
		_data = data;
		studentKey = Student().id();
		_head = NULL;
		_left = NULL;
		_right = NULL;
	}
	BNode(const T& data, const KeyType(key)) {
		_data = data;
		_treeKey = key;
		_head = NULL;
		_left = NULL;
		_right = NULL;
	}

	BNode(const T& data, BNode* head, BNode* left, BNode* right) {
		_data = data;
		_head = head;
		_left = left;
		_right = right;
	}
	//meant to be a null node for use in stuff
	BNode() {		
		_head = NULL;
		_left = NULL;
		_right = NULL;
	}

	const T& data() const { return _data; };
	const KeyType& key() const { return _key; };

	const BNode* head() const { return _head; };
	BNode* head() { return _head; };
	void setHead(BNode* head) { _head = head; };

	const BNode* left() const { return _left; };
	BNode* left() { return _left; };
	void setLeft(BNode* left) { _left = left; };

	const BNode* right() const { return _right; };
	BNode* right() { return _right; };
	void setRight(BNode* right) { _right = right; };

private:
	T _data;
	int _key;
	KeyType _treeKey;
	int studentKey;
	BNode* _head;
	BNode* _left;
	BNode* _right;
};


template <typename T, typename treeKey>
class BinarySearchTree {
public:
	BinarySearchTree() {}
	BinarySearchTree(const T& data, const T& key) {
		_root = NULL;
		_keyType = treeKey();
		_fuckingStupidToDotString = "";

	}

	//get the head of the tree.
	BNode<T, treeKey>* head() const {
		return _root;
	}

	//set the head of the tree.
	void setHead(BNode<T, treeKey>* node) {
		if (_root != NULL) {
			insert(_root, node);
		}
		else {
			_root = node;
		}
	}

	//set the left pointer for current node
	void setLeft(BNode<T, treeKey>* leftNode) {
		if (_left != NULL) {

		}
		else {
			_left = leftNode;
		}
	}
	//set right pointer for current node
	void setRight(BNode<T,treeKey>* rightNode) {
		if (_right != NULL) {

		}
		else {
			_right = rightNode;
		}
	}

	//find info on a node
	BNode<T, treeKey>* find(const T& key, BNode<T,treeKey>* head) {
		return _root;
	}



	//insert function, args startingNode, NodeToAdd sorts by data!
	void insertData(BNode<T, treeKey> *rootNode, BNode<T,treeKey> *newNode) {		
		

		if (rootNode->data() == newNode->data()){			
			return;
		}
		if (rootNode->data() > newNode->data()){
			if (rootNode->left() != NULL){
				insertData(rootNode->left(), newNode);
			}
			else{
				rootNode->setLeft(newNode);								
				newNode->setHead(rootNode);
				newNode->setLeft(NULL);
				newNode->setRight(NULL);							
				return;
			}
		}
		else{
			if (rootNode->right() != NULL){
				insertData(rootNode->right(), newNode);
			}
			else{
				rootNode->setRight(newNode);
				newNode->setHead(rootNode);								
				newNode->setRight(NULL);
				newNode->setLeft(NULL);							
				return;
			}
		}
	}
	//insert function, args startingNode, NodeToAdd sorts by student id.
	void insertID(BNode<T, treeKey> *rootNode, BNode<T, treeKey> *newNode)
	{


		if (_keyType(rootNode->data()) == _keyType( newNode->data())) {
			return;
		}
		if (_keyType(rootNode->data()) > _keyType( newNode->data())) {
			if (rootNode->left() != NULL) {
				insertID(rootNode->left(), newNode);
			}
			else {
				rootNode->setLeft(newNode);
				newNode->setHead(rootNode);
				newNode->setLeft(NULL);
				newNode->setRight(NULL);
				return;
			}
		}
		else {
			if (rootNode->right() != NULL) {
				insertID(rootNode->right(), newNode);
			}
			else {
				rootNode->setRight(newNode);
				newNode->setHead(rootNode);
				newNode->setRight(NULL);
				newNode->setLeft(NULL);
				return;
			}
		}
	}


	//master search function, arg desired key, returns the desired node.
	BNode<T, treeKey>* nodeSearch(int key) {
		
		BNode<T, treeKey>* searchNode = _root;	
		if (_root == NULL)
			return false;
		else if (_keyType(_root->data()) == key)
			return _root;
		else
			while (true) {
				if (_keyType(searchNode->data()) == key) {
					return searchNode;
				}
				else if (searchNode->left() != NULL && key < _keyType(searchNode->data())) {
					searchNode = searchNode->left();
				}
				else if (searchNode->right() != NULL && key > _keyType(searchNode->data())  ) {
					searchNode = searchNode->right();
				}
				else
					return NULL;
			}
	}

public:
	void insert(int data) {
		BNode<T,treeKey>* newNode = new BNode<T, treeKey>(data, data);
		if (_root != NULL) {
			insertData(_root, newNode);
		}
		else
			_root = newNode;
	}
	void insert(Student student) {
		
		BNode<T,treeKey>* newNode = new BNode<T,treeKey>(student,treeKey());
		if (_root != NULL)
			insertID(_root, newNode);
		else
			_root = newNode;
	}


	T min() {
		BNode<T, treeKey>* searchNode = _root;
		while (searchNode->left()) {
			searchNode = searchNode->left();
		}
		return searchNode->data();
	}

	T max() {
		BNode<T,treeKey>* searchNode = _root;
		while (searchNode->right()) {
			searchNode = searchNode->right();
		}
		return searchNode->data();
	}

	bool contains(int key) {
		BNode<T, treeKey>* keyNode = nodeSearch(key);
		if (keyNode != NULL) 
			return true;
		else
			return false;
	}

	//returns a node searched by its key
	T get(int key) {
		BNode<T,treeKey>* keyNode = nodeSearch(key);
		return keyNode->data();
	}
	//order by student id
	void getInOrder(T *arr) {
		int size = 0;
		while (_keyType(arr[size]) == 0)
		{
			size++;
		}
		_inorderNodeArr = new T[size];
		const T *orderedArr = inorderData(_root,_i);
		
	}
	//returns a set of the nodes in order from least to greatest
	const T *inorderData(BNode<T,treeKey>* node, int itterator) {		
		if (!node)
			return _inorderNodeArr;
		
		inorderData(node->left(), itterator++);				
		_inorderNodeArr[_i] = node->data();		
		inorderData(node->right(), itterator);	
		return _inorderNodeArr;
	}

	void remove(int nodeData) {
		BNode<T,treeKey>* nodeToRemove = nodeSearch(nodeData);
		if (!nodeToRemove->left() && !nodeToRemove->right()) {
			delete nodeToRemove;
			
		}
		else if (!nodeToRemove->left()) {
			BNode<T, treeKey> *temp = nodeToRemove;
			nodeToRemove = nodeToRemove->right();
			delete temp;
			
		}
		else if (!nodeToRemove->right()) {
			BNode<T, treeKey> *temp = nodeToRemove;
			nodeToRemove = nodeToRemove->left();
			delete temp;
			
		}
		else {
			return;
		}
	}


	




	///////////////////////////////////////////////////////toDot stuff//////////////////////////////
	std::string toDotEdges(BNode<T,treeKey>* node) {
		using namespace std;
		if (!node) return "";
		string str;
		if (node->left()) {
			str += dotEdge(node->data(), node->left()->data());
		}
		if (node->right()) {
			str += dotEdge(node->data(), node->right()->data());
		}

		if (node->left()) {
			str += toDotEdges(node->left());
		}
		if (node->right()) {
			str += toDotEdges(node->right());
		}
		return str;
	}

	std::string toDotNodes(BNode<T, treeKey>* node) {
		using namespace std;
		if (!node) return "";
		string str;
		_fuckingStupidToDotString = "";
		 str = inorder(node);
		 return str;		
	}
	//when accessing this you must set _fuckingstupidtodotstring to ""; returns an in order set of the data in a string
	std::string inorder(BNode<T, treeKey>* node)
	{
		if (!node)
			return "";
		inorder(node->left());
		_fuckingStupidToDotString += dotNode(node->data());
		inorder(node->right());
		return _fuckingStupidToDotString;
	}

	

	std::string toDot() {
		using namespace std;
		string str = "digraph G {\n";
		str += "graph [ordering=\"out\"]\n";
		str += toDotNodes(_root);
		str += toDotEdges(_root);
		str += "}\n";
		return str;
	}


private:
	BNode<T,treeKey>* _root;
	BNode<T,treeKey>* _left;
	BNode<T, treeKey>* _right;
	T *_inorderNodeArr;
	std::string _fuckingStupidToDotString;
	treeKey _keyType;
	int _i = 0;

};