#include "Train.h"

Train::Train()
{
	head = NULL;
	size = 0;
}

Train::Train(Carriage *h)
{
	head = h;
}

void Train::addCar(string c, string d)
{
	Carriage *node = new Carriage(size++, c, d, head);
	node->setNext(head);
	head = node;
}

void Train::print()
{
	Carriage *ptr = head;
	if (size == 0) {
		cout << "No carriages in the train" << endl;
	}
	else {
		while (ptr != NULL) {
			cout << "{ ";
			cout << ptr->getNumber() + 1 << " , ";
			cout << ptr->getCargo() << " , ";
			cout << ptr->getDestination() << "} ";
			ptr = ptr->getNext();
		}
		
	}
}

string Train::search(int n)
{
	Carriage *ptr = head;
	while (ptr != NULL) {
		if (ptr->getNumber() + 1 == n) {
			return ptr->getCargo();
		}
		ptr = ptr->getNext();
	}
	return string();
}

void Train::remove(string d)
{
	if (head == NULL) {
		return;
	}
	else if (d == head->getDestination()) {
		Carriage *temp = head;
		head = head->getNext();
		delete temp;
	}
	else {
		Carriage *ptr = head;
		while (ptr->getNext() != NULL) {
			if (ptr->getNext()->getDestination() == d) {
				Carriage *temp = ptr->getNext();
				ptr->setNext(temp->getNext());
				delete temp;
				size--;
				return;
			}
			ptr = ptr->getNext();
		}
	}
}


Train::~Train()
{
}
