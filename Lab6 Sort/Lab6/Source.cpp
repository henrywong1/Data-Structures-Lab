#include <iostream>
using namespace std;	

void swap(int *xp, int *yp)
{
	int temp = *xp;
	*xp = *yp;
	*yp = temp;
}

void printArray(int arr[], int size)
{
	int i;
	for (i = 0; i < size; i++)
		printf("%d ", arr[i]);
	printf("\n");
}

void bubbleSort(int arr[], int n)
{
	int i, j;
	int k = 0;
	bool swapped;
	for (i = 0; i < n - 1; i++)
	{
		swapped = false;
		for (j = 0; j < n - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				swap(&arr[j], &arr[j + 1]);
				swapped = true;
				printArray(arr, n);
				k++;
				cout << endl << "TOTAL SWAPS: " << k << endl;
			}
		}

		// IF no two elements were swapped by inner loop, then break
		if (swapped == false) {
			cout << endl << "TOTAL SWAPS: " << k << endl;
			break;
		}
	}
}

int main() {
	int arr[] = {32,31,30,29,28,27,26,25,24,23,22,21,20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1};
	int n = sizeof(arr) / sizeof(arr[0]);
	bubbleSort(arr, n);
	cout << endl << "Sorted Array: ";
	printArray(arr, n);

	system("PAUSE");
	return 0;
}