#include <iostream>
using namespace std;

class Account {
	
public:
	Account();
	Account(double getBalance, double getInterest);
	friend ostream& operator <<(ostream& wd, const Account& ttl);
	void operator++();

	bool operator> (Account ok);

private:
	double balance;
	double interest;
};





int main() {
	Account A1(1000, 0.1);
	cout << "Account 1" << endl;
	cout << A1 << endl;
	
	Account A2(1500, 0.3);
	cout << "Account 2" << endl;
	cout << A2 << endl;
	if (A1 > A2) {
		cout << "Account 1 is greater than 2" << endl << endl;
	}
	else if (A2 > A1) {
		cout << "Account 2 is greater than 1" << endl << endl;
	}

	++A1;
	cout << "After one year Account 1 would have " << endl;
	cout << A1 << endl;

	++A2;
	cout << "After one year Account 2 would have " << endl;
	cout << A2 << endl;
	system("PAUSE");
	return 0;
}

Account::Account()
{
	balance = 0.0;
	interest = 0.0;
}

Account::Account(double getBalance, double getInterest)
{
	balance = getBalance;
	interest = getInterest;
}

void Account::operator++()
{
	balance = balance * (1 + interest);
	
}

bool Account::operator>(Account ok)
{
	if (balance > ok.balance) {
		return true;
	}
	else
		return false;

}

ostream & operator<<(ostream & wd, const Account & ttl)
{
	wd << "Total balance: $" << ttl.balance << endl;
	wd << "Interest Rate : " << ttl.interest << endl;
	return wd;
}
