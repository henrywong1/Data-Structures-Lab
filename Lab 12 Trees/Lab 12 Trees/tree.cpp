#include "tree.h"
#include <time.h>
using namespace std;

Tree::Tree(TNode *r)
{
	root = r;
}

void Tree::insert(int item)
{
	if (root == NULL)
		root = new TNode(item);
	else
		root->insert(item);

}

void Tree::print()
{
	if (root == NULL)
		cout << "Tree is empty.\n";
	else
		root->print();
}

void Tree::printDescending()
{
	if (root == NULL)
		cout << "TREE is empty" << endl;
	else
		root->printDescending();
}

void Tree::increment()
{
	if (root == NULL)
		return;
	else
		root->increment();
}

void Tree::printLeaves()
{
	if (root == NULL)
		return;
	else
		root->printLeaves();
}

void Tree::addLayer()
{
	if (root != NULL) {
		root->addLayer();
	}
	else {
		srand(time(NULL));
		int x = rand() % 100 + 1;
		insert(x);
	}
	
}


