#include "tnode.h"

TNode::TNode(int d, TNode* l, TNode* r)
{
	data = d;
	lchild = l;
	rchild = r;
}

void TNode::insert(int item)
{
	if (item < data) // belongs to left
	{
		if (lchild == NULL)
			lchild = new TNode(item);
		else
			lchild->insert(item);
	}
	else // belongs to right
	{
		if (rchild == NULL)
			rchild = new TNode(item);
		else
			rchild->insert(item);
	}
}

void TNode::print()
{
	if (lchild != NULL)
		lchild->print();
	cout << data << " ";
	if (rchild != NULL)
		rchild->print();
}

void TNode::printDescending()
{
	if (rchild != NULL)
		rchild->printDescending();
	cout << data << " ";
	if (lchild != NULL)
		lchild->printDescending();
}

void TNode::increment()
{
	data++;
	if (lchild != NULL) {
		lchild->increment();
	}
	if (rchild != NULL) {
		rchild->increment();
	}

}

void TNode::printLeaves()
{
	
	if (lchild == NULL && rchild == NULL) {
		cout << data << " ";
	}
	else {
		if (lchild != NULL) {
			lchild->printLeaves();
		}
		if (rchild != NULL) {
			rchild->printLeaves();
		}
	}
}

void TNode::addLayer()
{
	if (lchild != NULL && rchild != NULL) {
		rchild->addLayer();
		lchild->addLayer();
	}
	else {
		rchild = new TNode(data + 1);
		lchild = new TNode(data - 1);
	}

}
