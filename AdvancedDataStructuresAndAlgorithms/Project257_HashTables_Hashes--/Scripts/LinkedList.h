#pragma once

// Provides I/O
#include <iostream>
#include <sstream>
#include <string>

//------------------------------------------------------------
// ListNode class
// ListNodes are singly-linked.
//------------------------------------------------------------
template <typename T>
class ListNode {
 public:
  ListNode(const T& data) {
    _data = data;
    _next = NULL;
  }
  ListNode(const T& data, const int& key) {
	  _data = data;
	  _key = key;
	  _next = NULL;
  }

  ListNode(const T& data, ListNode* next) {
    _data = data;
    _next = next;
  }
 
	  const T& data() const { return _data; }
	  const int& key() const { return _key; }
	  const ListNode* next() const { return _next; }
	  ListNode* next() { return _next; }
	  void setNext(ListNode* next) { _next = next; }
	  void setKey(ListNode* key) { _key = key; }


 private:
  T _data;
  ListNode* _next;
  int _key;
};

//------------------------------------------------------------
// LinkedList class
//------------------------------------------------------------
template <typename T>
class LinkedList {
	
 public:
  LinkedList() {
    _head = NULL;
  } 

  // TODO: implement - set node to _head. If _head is non-null
  // then update next pointers so that node->next() points to
  // _head.
  void insert(ListNode<T>* node) {	 
	  if (_head != NULL) {
		  node->setNext(_head);
		  _head = node;
	  }
	  else {
		  _head = node;
	  }	 
  }
  
  

  // TODO: implement
  ListNode<T>* find(const T& data) {
	  ListNode<T>* list = _head;
	  while (list != nullptr)
	  {
		  if (list->data() == data) {
			  return list;
		  }
		  else {
			  list = list->next();
		  }
	  }
	  return NULL ;
  }
  ListNode<T>* find(const T& data, const int& key) {
	  ListNode<T>* list = _head;
	  while (list != nullptr)
	  {
		  if (list->key() == key) {
			  return list;
		  }
		  else {
			  list = list->next();
		  }
	  }
	  return NULL;
  }

  // Removes and deletes the first node in the linked list that has
  // data equal to key. To delete a node:
  //
  //   ListNode<T>* node = ...
  //   delete node;
  void remove(const T& key) {
	  ListNode<T>* nodeToRemove = find(key);	
	  if (nodeToRemove == NULL)
		  return;
	  ListNode<T>* disjointNode = nodeToRemove->next();
	  ListNode<T>* indexNode = _head;	 	 
	  
	  while (indexNode != nullptr)
	  {
		  if (nodeToRemove == _head) {
			  _head = disjointNode;
			  delete nodeToRemove;
			  return;			  
		  }
		  else if (indexNode->next() == nodeToRemove) {
			  indexNode->setNext(disjointNode);
			  delete nodeToRemove;
			  return;
		  }
		  else if (indexNode->next() == nodeToRemove && disjointNode == nullptr) {
			  indexNode->setNext(nullptr);
			  delete nodeToRemove;
			  return;
		  }
		  indexNode = indexNode->next();
	  }	  	 	 	  
  }
public:
	int listNodesCount() {
		int count = 0;
		ListNode<T>* indexNode = _head;
		while (indexNode != nullptr)
		{
			count += 1;
			if (indexNode->next() != nullptr)
				indexNode = indexNode->next();
			else
				return count;
		}
		return count;
  }
public:
	T nodeData() {				 
		return _head->data();
	}
public:
	ListNode<T>* node(){
		return _head;
	}


  friend std::ostream& operator<<(std::ostream& out, const LinkedList& list) {
    ListNode<T>* node = list._head;
    while (node != NULL) {
      out << node->data();
      if (node->next() != NULL) {
        out << " -> ";
      }
      node = node->next();
    }
    return out;
  }

  std::string toString() const {
    std::stringstream ss;
    ss << *this;
    return ss.str();
  }

 private:
  ListNode<T>* _head;
};
