#include "Carriage.h"

Carriage::Carriage(int num, string c, string d, Carriage* n)
{
	number = num;
	cargo = c;
	destination = d;
	next = n;
}

int Carriage::getNumber()
{
	return number;
}

string Carriage::getCargo()
{
	return cargo;
}

string Carriage::getDestination()
{
	return destination;
}

Carriage* Carriage::getNext()
{
	return next;
}

void Carriage::setNumber(int n)
{
	number = n;
}

void Carriage::setCargo(string c)
{
	cargo = c;
}

void Carriage::setDestination(string d)
{
	destination = d;
}

void Carriage::setNext(Carriage* n)
{
	next = n;
}