#include "Carriage.h"
#include "Train.h"

int main() {
	Train list;
	int x;
	//Before
	cout << "Before Adding any Carriages: " << endl;
	list.print();
	//Adding carriages
	list.addCar("Computers", "San Francisco");
	list.addCar("Avocados", "Oregon");
	list.addCar("Steel", "Stockton");
	list.addCar("Bronze", "Seattle");
	list.addCar("Grain", "Las Vegas");
	cout << endl << "After adding 5 carriages." << endl;
	list.print();
	cout << endl;
	//Search
	cout << endl << "Carriage 2 has the following cargo: " << list.search(2) << endl;
	//Unload
	list.remove("Oregon");
	cout << endl << "After unloading Oregon Cargo" << endl;
	list.print();
	cout << endl << endl;
	cout << "Search for cart contents" << endl;
	cout << "Enter cart number" << endl;
	cin >> x;
	list.search(x);
	


	system("PAUSE");
}