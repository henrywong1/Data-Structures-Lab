#pragma once
#include "Carriage.h"
class Train :
	public Carriage
{
private:
	int carID, size;
	Carriage *head;
public:
	Train();
	Train(Carriage *h);
	void addCar(string c, string d);
	void print();
	string search(int n);
	void remove(string d);
	~Train();
};

