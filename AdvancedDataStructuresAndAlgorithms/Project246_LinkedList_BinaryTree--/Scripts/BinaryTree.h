#pragma once

// Provides I/O
#include <iostream>
#include <string>
#include "./util.h"


template<typename T>
class BNode {
public:
	BNode(const T& data) {		
		_data = data;
		_head = NULL;
		_left = NULL;
		_right = NULL;
	}

	BNode(const T& data,BNode* head , BNode* left, BNode* right) {
		_data = data;
		_head = head;
		_left = left;
		_right = right;
	}

	const T& data() const { return _data; };
	
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
	BNode* _head;
	BNode* _left;
	BNode* _right;
};


template <typename T>
class BinaryTree {
public:
	BinaryTree() {
		_head = NULL;
		
	}
	BNode<T>* head() const {
		return _head;
	}


	void setHead(BNode<T>* node) {
		if (_head != NULL) {
		
		}
		else {
			_head = node;
		}
	}
		

	void setLeft(BNode<T>* leftNode) {
		if (_left != NULL) {

		}
		else {
			_left = leftNode;
		}
	}
	void setRight(BNode<T>* rightNode) {
		if (_right != NULL) {

		}
		else {
			_right = rightNode;
		}
	}

	BNode<T>* find(const T& key, BNode<T>* head) {
		return _head;
	}


	// TODO: add these functions to your BinaryTree class.
	 std::string toDotImpl(BNode<T>* node) {
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
	     str += toDotImpl(node->left());
	   }
	   if (node->right()) {
	     str += toDotImpl(node->right());
	   }
	   return str;
	 }

	 std::string toDot() {
	   using namespace std;
	   string str = "digraph G {\n";
	   str += "graph [ordering=\"out\"]\n";
	   str += toDotImpl(_head);
	   str += "}\n";
	   return str;
	 }


private:
	BNode<T>* _head;
	BNode<T>* _left;
	BNode<T>* _right;
};


















