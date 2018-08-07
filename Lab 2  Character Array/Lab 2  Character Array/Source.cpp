#include <iostream>
#include <string>
using namespace std;


void printWord(char* words, int size) {
	cout << "Your word is : ";
	for (int i = 0; i < size; i++) {
		cout << words[i];
	}
	cout << endl;

}
int main() {
	int size = 0;
	char letter = ' ';
	char* words = new char[size];

	cout << "Please enter the length of your word: " << endl;
	cin >> size;
	cout << "Please enter your word: " << endl;
	for (int i = 0; i < size; i++) {
		cin >> words[i];
	}
	printWord(words, size);

	cout << "Enter a letter to search for : " << endl;
	cin >> letter;
	for (int i = 0; i < size; i++) {
		if (*(words + i) == letter){
			cout << "Found " << letter << " at position " << i + 1 << endl;
			}
	}

	char* firstLetter = &words[0];
	char* lastLetter = &words[size - 1];

	while (firstLetter <= lastLetter) {
		if (*firstLetter != *lastLetter) {
			cout << "Not a palindrome. " << endl;
			break;
		}
			firstLetter++;
			lastLetter--;
	}
	if (firstLetter > lastLetter) {
		cout << "Is a palindrome." << endl;
	}
	system("PAUSE");
} 