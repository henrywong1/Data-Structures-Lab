#include "tree.h"
#include "tnode.h"
int main()
{
	Tree b1;
	
	
	b1.insert(50);
	b1.insert(22);
	b1.insert(24);
	b1.insert(19);
	b1.insert(29);
	b1.insert(76);
	
	b1.print();
	cout << endl;
	b1.printDescending();
	cout << endl;
	b1.increment();
	b1.print();
	cout << endl;
	b1.printLeaves();
	cout << endl << endl;
	b1.print();
	cout << endl;
	b1.addLayer();
	b1.print();
	cout << endl;
	system("PAUSE");
}