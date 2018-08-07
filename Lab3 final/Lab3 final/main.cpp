/*******************************************************************************
 * File: main.cpp
 * Author: E. Bowring
 * Description: Skeleton code for lab 3.
 ******************************************************************************/

#include "account.h"
#include "Savings.h"
#include <iostream>

int main()
{
	int years;
	years = 10;

	Account a1;
	Savings a2;
	a1.setName("Account 1");
	a1.setBalance(1000);
	a1.print();
	a2.setName("Account 2");
	a2.setBalance(2000);
	a2.setInterest(.5);
	cout << endl;
	for (int i = 0; i < years; i++)
	{
		cout << "______________" << endl;
		a2.update();
		a2.print();
	}

	system("PAUSE");


}