#ifndef CARRIAGE_H
#define CARRIAGE_H

#include <string>
#include <iostream>
using namespace std;

class Carriage
{
protected:
	// data
	int number;
	string cargo, destination;
	// pointer to next one
	Carriage* next;
public:
	// default and general constructor
	Carriage(int num = 0, string c = "nothing", string d = "nothing", Carriage* n = NULL);

	// accessors
	int getNumber();
	string getCargo();
	string getDestination();
	Carriage* getNext();

	// mutators
	void setNumber(int n);
	void setCargo(string c);
	void setDestination(string d);
	void setNext(Carriage* n);
};

#endif
