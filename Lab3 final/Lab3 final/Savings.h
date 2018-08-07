#pragma once
#include "account.h"

class Savings: public Account
{
public:
	
	Savings();
	void setInterest(double i);
	Savings(std::string n, double b, double i);
	void print();
	void update();
	void updateBal(double n);
	~Savings();
	

private:
	double rate;
	double balance;
};


