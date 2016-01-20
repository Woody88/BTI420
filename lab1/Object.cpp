#include <iostream>
#include "Object.h"

Object::Object(int size) {
	_buffer = new int[size];
	_size = size;
	_index = 0;
}
Object::~Object() {
	if(_buffer != nullptr){
		delete [] _buffer;
		_buffer = nullptr;
	}
}
void Object::display() const {
	std::cout << "Buffer: ";
	for(int i = 0; i < _size; i++)
		std::cout << _buffer[i] << ", ";

	std::cout << std::endl;
}

Object& Object::operator+=(int value) {

	_buffer[_index] = value;
	_index++;
	
	return *this;
}