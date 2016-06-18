// Problem01.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

int main()
{
	string input;
	int countOfUppercase=0;
	int countOfLowercase=0;
	int countOfOtherSymbols=0;
	getline(cin, input);
	for each (char eachChar in input)
	{
		if (eachChar >= 65 && eachChar <= 95)
		{
			countOfUppercase++;
		}
		else if (eachChar >= 97 && (int)eachChar <= 122) 
		{
			countOfLowercase++;
		}
		else 
		{
			countOfOtherSymbols++;
		}

	}
	cout << "UpperCase letters: " << countOfUppercase << endl;
	cout << "LowerCase letters: " << countOfLowercase << endl;
	cout << "Other Symbols letters: " << countOfOtherSymbols << endl;
    return 0;
}

