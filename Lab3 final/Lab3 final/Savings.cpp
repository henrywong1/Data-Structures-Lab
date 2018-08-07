#include "Savings.h"

Savings::Savings()
{
	name = " ";
	balance = 0.0;
	rate = 0.0;
}

void Savings::setInterest(double i)
{
	rate = i;
}

Savings::Savings(std::string n, double b, double i) : Account(n, b)
{
	rate = i;
}

void Savings::print()
{
	cout << "Name : " << name << endl;
	cout << "Interest rate(after one year) : " << rate << endl;
	cout << "Balance(With Interest): " << balance << endl;
	
}

void Savings::update()
{
	
	balance = getBalance() * (1 + rate);
	setBalance(balance);
}


Savings::~Savings()
{
}


