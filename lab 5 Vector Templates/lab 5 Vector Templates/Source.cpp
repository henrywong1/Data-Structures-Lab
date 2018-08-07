#include <iostream>
#include <string>
#include <vector>
#include <fstream>
using namespace std;

void printVector(vector <string> words) {
	for (int i = 0; i < words.size(); i++) {
		cout << words.at(i) << " ";
	}
}
int main() {	
	ifstream instream;
	string temp;
	instream.open("lab5.txt");
	vector <string> words;

	string input, replace;
	int num, pos;

	if (instream.fail()) {
		cout << "Could not open file" << endl;
	}
	while (instream >> temp) {
		words.push_back(temp);
	}
	cout << "Original Text" << endl;
	printVector(words);
	
	cout << endl << endl << "Enter a word to find: ";
	cin >> input;
	cout << endl << endl << "Enter a word to replace it with: ";
	cin >> replace;
	for (int i = 0; i < words.size(); i++) {
		if (words.at(i) == input) {
			words.at(i) = replace;
		}
	}
	cout << endl << "After search and replace:" << endl;
	printVector(words);

	cout << endl << endl << "Enter number of words to remove: ";
	cin >> num;

	for (int i = 0; i < num; i++) {
		words.pop_back();
	}
	cout << endl << "After removal of " << num << " words" << endl;
	printVector(words);
	
	cout << endl << endl << "Size:" << words.size() << "     ";
	cout << "Capacity is " << words.capacity() << endl;

	cout << endl << "Enter a position number: ";
	cin >> pos;
	cout << endl << "Word at position " << pos << " is: " << words.at(pos - 1) << endl;

	system("PAUSE");
	return 0;
}