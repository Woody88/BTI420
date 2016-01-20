#ifndef OBJECT_H
#define OBJECT_H

class Object{
	int* _buffer;
	size_t _size;
	int _index;

	Object(int size);
	~Object();
	void display() const;
	Object& operator+=(int);

};



#endif 