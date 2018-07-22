#pragma once

// Provides I/O
#include <iostream>
#include <sstream>
#include <string>

#include "./LinkedList.h"

//------------------------------------------------------------
// Instructions: your chained hash table will contain an array
// of linked lists (you're welcome to copy your templated
// LinkedList class from the binary tree project). Your
// array will be declared as
//    LinkedList<KeyValue>* A;
// In your constructor it will be allocated as
//    A = new ListNode<KeyValue>[m];
//------------------------------------------------------------


// This class takes two template parameters: T is the type of value
// stored in the hash table. The second is the type of hash
// function to use. In member functions of HashTable,
// you can hash a key as follows:
//    int key = ...
//    Hash h;
//    int hash = h(key);
template <typename T, typename Hash>
class HashTable {
 private:
  //--------------------------------------------------
  // Utility class. The chains will hold instances of
  // KeyValue. The KeyValue stores both the key and
  // the value. This class is an inner class of
  // HashTable.
  //--------------------------------------------------
  class KeyValue {
   public:
    KeyValue() {}
    KeyValue(const int key, const T& value) {
      _key = key;
      _value = value;
    }
    int key() const { return _key; }
    const T& value() const { return _value; }
    bool operator==(const KeyValue& rhs) {
      return _key == rhs._key;
    }
   private:
    int _key;
    T _value;
  };

public:
	HashTable(){}
	HashTable(const int tblSize) {
		_tblSize = tblSize;
		hashTbl = new LinkedList<T>[tblSize];
		_hash = Hash();
	}
public:
	int size() {
		int count = 0;
		LinkedList<T> list = hashTbl[0];
		for (int i = 0; i < _tblSize; i++)
		{
			list = hashTbl[i];
			count += list.listNodesCount();
		}
		return count;
	}
public:
	int size(int arrPos) {
		
		LinkedList<T> List = hashTbl[hashKey(arrPos,_tblSize)];
		return List.listNodesCount();
	}
public:
	void put(int arrPos, T element) {
		
		LinkedList<T>* list = &hashTbl[hashKey(arrPos,_tblSize)];
		ListNode<T>* node = new ListNode<T>(element, arrPos);
		list->insert(node);
	}
public:
	bool contains(const int value) {
		try {
			LinkedList<T> list = hashTbl[hashKey(value, _tblSize)];
			if (list.listNodesCount() > 0)
				return true;
			else
				return false;
		}
		catch(exception& e){}
				
	}
	///String A needs to be replaced, should take in a key and return the hashtable value stored at that location.
	///TODO:NEED TO FIX THIS!!!!
public:
	T get(int key) {
		string A = "A";
		LinkedList<T> list = hashTbl[hashKey(key, _tblSize)];
		ListNode<T>* node = list.find(A, key);
		return node->data();		
	}
public:
	//TODO: not iterating through everything, check indexes
	void getKeys(int* keyArr) {
		LinkedList<T> list = hashTbl[0];
		ListNode<T>* node;
		int keyArrTraverse = 0;
		int linkedListTraverse = 0;
		while (keyArrTraverse < this->size()){
			list = hashTbl[linkedListTraverse];
			if (list.listNodesCount() > 0 && linkedListTraverse < list.listNodesCount()) {
				//list = hashTbl[linkedListTraverse];
				node = list.node();
				keyArr[keyArrTraverse] = node->key();
				node = node->next();
				++keyArrTraverse;
			}
			else if (list.listNodesCount() == 0) {
				++linkedListTraverse;
			}			
			else {
				++linkedListTraverse;
			}
		}		
	}



private:
	int hashKey(int key, int tblSize) {
		return _hash(key, tblSize);
	}

private:
	
	int index = 0;
	int _tblSize;
	LinkedList<T>* hashTbl;
	Hash _hash;
	

  //--------------------------------------------------
  // Remaining implementation of the HashTable.
  //--------------------------------------------------


  // TODO: uncomment this function after implementing getKeys().
   friend std::ostream& operator<<(std::ostream& out, HashTable& t) {
     const int n = t.size();
     int* keys = new int[n];
     t.getKeys(keys);
     for (int i = 0; i < n; ++i) {
       const int key = keys[i];
       out << t.get(key) << "; ";
     }
     delete [] keys;
     return out;
   }

 
};
